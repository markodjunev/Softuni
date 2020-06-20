function solve(input) {
    const object = {};
    const parsed = JSON.parse(input);

    parsed.forEach(prop => {
        const entries = Object.entries(prop);
        entries.forEach(entry => {
            const [key, value] = entry;
            object[key] = value;
        });
    });

    return object;
}

console.log(solve(`[{"canMove": true},{"canMove":true, "doors": 4},{"capacity": 5}]`));