function area() {
    return this.x * this.y;
}

function vol() {
    return this.x * this.y * this.z;
}

function solve(area, vol, inputJson) {
    const objArr = JSON.parse(inputJson);
    return objArr.map(obj => {
        const a = Math.abs(area.call(obj));
        const v = Math.abs(vol.call(obj));
        return { area: a, volume: v };
    });
}

const jsonString = "[{ \"x\": 1, \"y\": 2, \"z\": 3 }, { \"x\": 4, \"y\": 5, \"z\": 6 }]";
solve(area, vol, jsonString);

