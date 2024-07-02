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
import { useNavigate } from "react-router-dom";

const defaultTheme = createTheme();

export const CreateGameLog = () => {
    const navigate = useNavigate();

    const [formData, setFormData] = useState({
        Title: "",
        DateReleased: "",
        DateStarted: "",
        DateCompleted: "",
        Rating: "", 
        Difficulty: "",
        Story:"",
        Review: ""
    });

    const [error, setError] = useState(null);

    const handleChange = (e) => {
        const { name, value } = e.target;
        setFormData(prevState => ({
            ...prevState,
            //convert the below fields to int
            [name]: name === "Rating" || name === "Difficulty" || name === "Story" ? parseInt(value) : value
        }));
    };

    const handleSubmit = async (event) => {
        event.preventDefault();
        setError(null);
        try {
            console.log(formData);
            const res = await axios.post("http://localhost:40316/GameLog/AddGame", formData);
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
                        Create Game Log
                    </Typography>
                    {error && <Typography color="error">{error}</Typography>}
                    <Box component="form" onSubmit={handleSubmit} noValidate sx={{ mt: 1 }}>
                        <TextField
                            margin="normal"
                            //required
                            fullWidth
                            id="Title"
                            label="Title"
                            name="Title"
                            autoComplete="Title"
                            autoFocus
                            value={formData.Title}
                            onChange={handleChange}
                        />
                        <TextField
                            margin="normal"
                            //required
                            fullWidth
                            name="DateReleased"
                            label="Date Game Was Released"
                            id="DateReleased"
                            autoComplete="DateReleased"
                            value={formData.DateReleased}
                            onChange={handleChange}
                        />
                        <TextField
                            margin="normal"
                            fullWidth
                            name="DateStarted"
                            label="Date Playthrough Was Started"
                            id="DateStarted"
                            autoComplete="DateStarted"
                            value={formData.DateStarted}
                            onChange={handleChange}
                        />
                        <TextField
                            margin="normal"
                            fullWidth
                            name="DateCompleted"
                            label="Date Playthrough Was Completed"
                            id="DateCompleted"
                            autoComplete="DateCompleted"
                            value={formData.DateCompleted}
                            onChange={handleChange}
                        />
                        <TextField
                            margin="normal"
                            fullWidth
                            name="Rating"
                            label="Rating"
                            id="Rating"
                            autoComplete="Rating"
                            value={formData.Rating}
                            onChange={handleChange}
                            type="number" 
                        />
                        <TextField
                            margin="normal"
                            fullWidth
                            name="Difficulty"
                            label="Difficulty"
                            id="Difficulty"
                            autoComplete="Difficulty"
                            value={formData.Difficulty} 
                            onChange={handleChange}
                            type="number" 
                        />
                        <TextField
                            margin="normal"
                            fullWidth
                            name="Story"
                            label="Story"
                            id="Story"
                            autoComplete="Story"
                            value={formData.Story}
                            onChange={handleChange}
                            type="number"
                        />
                        <TextField
                            margin="normal"
                            fullWidth
                            name="Review"
                            label="Review"
                            id="Review"
                            autoComplete="Review"
                            multiline
                            rows={4 }
                            value={formData.Review}
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
                            sx={{  mb: 2 }}
                        >
                            Back
                        </Button>
                    </Box>
                </Box>
            </Container>
        </ThemeProvider>
    );
};
