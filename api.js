// This file will handle all AJAX requests to the backend API for players, matches, and openings.

const API_BASE = "http://localhost:5000/api";

// Players
async function apiGetPlayers() {
    const res = await fetch(`${API_BASE}/players`);
    return res.json();
}
async function apiAddPlayer(player) {
    const res = await fetch(`${API_BASE}/players`, {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(player)
    });
    return res.json();
}

// Matches
async function apiGetMatches() {
    const res = await fetch(`${API_BASE}/matches`);
    return res.json();
}
async function apiAddMatch(match) {
    const res = await fetch(`${API_BASE}/matches`, {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(match)
    });
    return res.json();
}

// Openings
async function apiGetOpenings() {
    const res = await fetch(`${API_BASE}/openings`);
    return res.json();
}
async function apiAddOpening(opening) {
    const res = await fetch(`${API_BASE}/openings`, {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(opening)
    });
    return res.json();
}
