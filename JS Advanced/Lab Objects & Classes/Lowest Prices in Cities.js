function solve(input){
    let result = {};

    for (let i = 0; i < input.length; i++) {
        const [city, product, price] = input[i].split(' | ');
        
        if(!result.hasOwnProperty(product)){
            result[product] = {};
            result[product][city] = Number(price);
        }

        let cityy = Object.keys(result[product]);

        if(result[product][cityy] > Number(price)){
            delete result[product][cityy];
            result[product] = {};
            result[product][city] = Number(price);
        }
    }

    for(let key in result){
        let city = Object.keys(result[key]);

        console.log(`${key} -> ${Number(result[key][city])} (${city})`);
    }
}

solve(['Sample Town | Sample Product | 1000',
'Sample Town | Orange | 2',
'Sample Town | Peach | 1',
'Sofia | Orange | 3',
'Sofia | Peach | 2',
'New York | Sample Product | 1000.1',
'New York | Burger | 10']
);