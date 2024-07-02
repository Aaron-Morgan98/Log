import * as React from 'react';
import { useState } from "react";
import Button from '@mui/material/Button';
import CssBaseline from '@mui/material/CssBaseline';
import TextField from '@mui/material/TextField';
import Typography from '@mui/material/Typography';
import Container from '@mui/material/Container';
import Box from '@mui/material/Box';
import { createTheme, ThemeProvider } from '@mui/material/styles';
import axios from "axios";
import { useNavigate, useLocation } from "react-router-dom";

const defaultTheme = createTheme();

export const EditGameLog = () => {
    const navigate = useNavigate();
    const location = useLocation();
    const { game } = location.state;
    const [formData, setFormData] = useState({ ...game });
    const [error, setError] = useState(null);

    const handleChange = (event) => {
        const { name, value } = event.target;
        setFormData({
            ...formData,
            [name]: value,
        });
    };

    const handleSubmit = async (event) => {
        event.preventDefault();
        setError(null);
        try {
            const res = await axios.put(`http://localhost:40316/GameLog/UpdateGame`, formData);
            console.log(res);
            navigate("/");
        } catch (err) {
            console.log(err);
            setError("An error occurred while submitting the form. Please try again.");
        }
    };

    return (
        <ThemeProvider theme={defaultTheme}>
            <Container component="main" maxWidth="xs">
                <CssBaseline />
                <Box
                    sx={{
                        marginTop: 3,
                        display: 'flex',
                        flexDirection: 'column',
                        alignItems: 'center',
                    }}
                >
                    <Typography component="h1" variant="h5">
                        Edit Game Log
                    </Typography>
                    {error && <Typography color="error">{error}</Typography>}
                    <Box component="form" onSubmit={handleSubmit} noValidate sx={{ mt: 1 }}>
                        <TextField
                            margin="normal"
                            fullWidth
                            id="title"
                            label="Title"
                            name="title"
                            autoComplete="title"
                            autoFocus
                            value={formData.title}
                            onChange={handleChange}
                        />
                        <TextField
                            margin="normal"
                            fullWidth
                            name="dateReleased"
                            label="Date Released"
                            id="dateReleased"
                            autoComplete="dateReleased"
                            value={formData.dateReleased}
                            onChange={handleChange}
                        />
                        <TextField
                            margin="normal"
                            fullWidth
                            name="dateStarted"
                            label="Date Started"
                            id="dateStarted"
                            autoComplete="dateStarted"
                            value={formData.dateStarted}
                            onChange={handleChange}
                        />
                        <TextField
                            margin="normal"
                            fullWidth
                            name="dateCompleted"
                            label="Date Completed"
                            id="dateCompleted"
                            autoComplete="dateCompleted"
                            value={formData.dateCompleted}
                            onChange={handleChange}
                        />
                        <TextField
                            margin="normal"
                            fullWidth
                            name="rating"
                            label="Rating"
                            id="rating"
                            autoComplete="rating"
                            value={formData.rating}
                            onChange={handleChange}
                            type="number"
                        />
                        <TextField
                            margin="normal"
                            fullWidth
                            name="difficulty"
                            label="Difficulty"
                            id="difficulty"
                            autoComplete="difficulty"
                            value={formData.difficulty}
                            onChange={handleChange}
                            type="number"
                        />
                        <TextField
                            margin="normal"
                            fullWidth
                            name="story"
                            label="Story"
                            id="story"
                            autoComplete="story"
                            value={formData.story}
                            onChange={handleChange}
                            type="number"
                        />
                        <TextField
                            margin="normal"
                            fullWidth
                            name="review"
                            label="Review"
                            id="review"
                            autoComplete="review"
                            multiline
                            rows={4}
                            value={formData.review}
                            onChange={handleChange}
                        />
                        <Button
                            type="submit"
                            fullWidth
                            variant="contained"
                            sx={{ mt: 3, mb: 2 }}
                        >
                            Submit
                        </Button>
                        <Button
                            color="error"
                            fullWidth
                            variant="contained"
                            href="/"
                            sx={{ mb: 2 }}
                        >
                            Back
                        </Button>
                    </Box>
                </Box>
            </Container>
        </ThemeProvider>
    );
};
