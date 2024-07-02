import { useState } from 'react';
import './App.css';
import { BrowserRouter as Router, Route, Routes, Navigate } from "react-router-dom";
import { GameLog } from "./Pages/GameLog";
import { CreateGameLog } from "./Pages/CreateGameLog";
import { EditGameLog } from "./Pages/EditGameLog";

function App() {

    return (
        <>
            <div>
                <Router>
                    <Routes>
                        <Route path="/" element={<GameLog />} />
                        <Route path="/creategamelog" element={<CreateGameLog />} />
                        <Route path="/editgamelog" element={<EditGameLog />} />
                    </Routes>
                </Router>
            </div>
        </>
    );
};

export default App;
