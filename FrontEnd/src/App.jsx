import { useState } from 'react';
import './App.css';
import { BrowserRouter as Router, Route, Routes, Navigate } from "react-router-dom";
import { GameLog } from "./Pages/GameLog";

function App() {

    return (
        <>
            <div>
                <Router>
                    <Routes>
                        <Route path="/" element={<GameLog />} />
                    </Routes>
                </Router>
            </div>
        </>
    );
};

export default App;
