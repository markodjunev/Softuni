function solve(input){
    let result = {};

    for (let i = 0; i < input.length - 1; i+=2) {
        const city = input[i];
        
        if(!result.hasOwnProperty(city)){
            result[city] = 0;
        }

        result[city] += Number(input[i + 1]);
    }

    console.log(JSON.stringify(result));
}

solve(['Sofia','20','Varna','3','sofia','5','varna','4']);