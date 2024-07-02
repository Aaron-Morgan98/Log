import * as React from 'react';
import { useState, useEffect } from "react";
import { DataGrid } from '@mui/x-data-grid';
import axios from "axios";
import Button from '@mui/material/Button';
import Stack from '@mui/material/Stack';
import { useNavigate } from "react-router-dom";

const columns = [
    { field: 'id', headerName: 'ID', width: 70 },
    { field: 'title', headerName: 'Title', width: 300 },
    { field: 'dateReleased', headerName: 'Date Released', width: 130 },
    { field: 'dateStarted', headerName: 'Date Started', width: 130 },
    { field: 'dateCompleted', headerName: 'Date Completed', width: 130 },
    { field: 'review', headerName: 'Review', width: 300 },
    { field: 'rating', headerName: 'Rating', type: "number", width: 70},
    { field: 'difficulty', headerName: 'Difficulty', type: "number", width: 70},
    { field: 'story', headerName: 'Story', type: "number", width: 70},
    //{
    //    field: 'fullName',
    //    headerName: 'Full name',
    //    description: 'This column has a value getter and is not sortable.',
    //    sortable: false,
    //    width: 160,
    //    valueGetter: (value, row) => `${row.title || ''} ${row.dateReleased || ''}`,
    //},
];


export const GameLog = () => {
    const navigate = useNavigate();

    const [rows, setRows] = useState([]);

    const [selectedRows, setSelectedRows] = useState([]);


    useEffect(() => {
        const fetchData = async () => {
            try {
                const result = await axios.get("http://localhost:40316/GameLog/GetAllGames");

                //mapping data for each id
                const mappedData = result.data.map(game => ({
                    id: game.gameId,
                    ...game,
                }));

                setRows(mappedData);
                console.log('Fetched data:', mappedData);

            } catch (err) {
                console.error("Error retrieving data:", err);
            }
        };

        fetchData();
    },[]);


    const handleSelectionChange = (selection) => {
        if (selection.length > 1) {
            //if more than 1 row is selected, keep only the first
            setSelectedRows([selection[0]]);
        } else {
            setSelectedRows(selection);
        }

    };


    const handleEdit = () => {
        if (selectedRows.length === 1) {
            const selectedRowData = rows.find(row => row.gameId === selectedRows[0]);
            navigate("/editgamelog", { state: { game: selectedRowData } });
        } else {
            alert("Please select a single row to edit.");
        }
    }

    const handleDelete = async () => {
        try {
            console.log("IDs selected for Delete:", selectedRows);

            for (let id of selectedRows) {
                await axios.delete(`http://localhost:40316/GameLog/DeleteGame/${id}`);
            }

            console.log("Delete completed");

            // Refresh the data after deletion
            setRows((prevRows) => prevRows.filter((row) => !selectedRows.includes(row.id)));
            setSelectedRows([]);
        } catch (err) {
            console.error("Error deleting selected rows:", err);
        }
    };



    return (
        <>
            <div style={{ height: 800, width: '110%' }}>
                <DataGrid
                    rows={rows}
                    columns={columns}
                    initialState={{
                        pagination: {
                            paginationModel: { page: 0, pageSize: 5 },
                        },
                    }}
                    pageSizeOptions={[5, 10]}
                    checkboxSelection
                    onRowSelectionModelChange={handleSelectionChange}
                />
            </div>
            <div>
                <Stack direction="row" spacing={2} justifyContent="flex-end" mt={3 }>
                    <Button variant="outlined" href="/creategamelog">Create</Button>
                    <Button variant="outlined" onClick={handleEdit}>Edit</Button>
                    <Button variant="outlined" onClick={handleDelete}>Delete</Button>
                </Stack>
            </div>
        </>
    );
}