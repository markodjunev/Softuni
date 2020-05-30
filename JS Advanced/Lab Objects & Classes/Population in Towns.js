function solve(input){
    let result = {};
    
    for (let i = 0; i < input.length; i++) {
        const [city, population] = input[i].split(' <-> ');

        if(!result.hasOwnProperty(city)){
            result[city] = 0;
        }

        result[city] += Number(population);
    }

    Object.entries(result).map(([town, population]) => console.log(`${town} : ${population}`));
}

solve(['Sofia <-> 1200000',
'Montana <-> 20000',
'New York <-> 10000000',
'Washington <-> 2345000',
'Las Vegas <-> 1000000']
);