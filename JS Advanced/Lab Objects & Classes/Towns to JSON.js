function solve(input){
    let [town, latitude, longitude] = input[0].split(' ').join('').split('|').filter(Boolean);

    let result = [];
    for (let i = 1; i < input.length; i++) {
        let currentData = input[i].split('|').filter(Boolean);

        let town = currentData[0].trim();
        let latitudeMetres = Number(Number(currentData[1]).toFixed(2));
        let longitudeMetres = Number(Number(currentData[2]).toFixed(2));

        result.push({Town: town, Latitude: latitudeMetres, Longitude: longitudeMetres});
    }
    console.log(JSON.stringify(result));
}

solve(['| Town | Latitude | Longitude |',
'| Sofia | 42.696552 | 23.32601 |',
'| Beijing | 39.913818 | 116.363625 |']
);