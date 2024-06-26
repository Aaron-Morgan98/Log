﻿import * as React from 'react';
import { useState, useEffect } from "react";
import { DataGrid } from '@mui/x-data-grid';
import axios from "axios";

const columns = [
    { field: 'id', headerName: 'ID', width: 70 },
    { field: 'title', headerName: 'Title', width: 300 },
    { field: 'dateReleased', headerName: 'Date Released', width: 130 },
    { field: 'dateStarted', headerName: 'Date Started', width: 130 },
    { field: 'dateCompleted', headerName: 'Date Completed', width: 130 },
    { field: 'review', headerName: 'Review', width: 300 },
    {
        field: 'rating',
        headerName: 'Rating',
        type: "number",
        width: 70,
    },
    {
        field: 'difficulty',
        headerName: 'Difficulty',
        type: "number",
        width: 70,
    },
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
    const [rows, setRows] = useState([]);

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


    return (
        <div style={{ height: 800, width: '100%' }}>
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
            />
        </div>
    );
}