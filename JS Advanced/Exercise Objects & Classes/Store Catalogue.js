function solve(input) {
    let result = {};
    for (const item of input) {
        let [product, price] = item.split(' : ');
        let letter = product[0];

        if(!result.hasOwnProperty(letter)){
            result[letter] = {};
        }

        result[letter][product] = Number(price);
    }

    let sortedKeys = Object.keys(result).sort((a, b) => a.localeCompare(b));

    for (const key of sortedKeys) {
        console.log(key);
        let sortedProducts = Object.keys(result[key]).sort((a, b) => a.localeCompare(b));
        for (const item of sortedProducts) {
            console.log(` ${item}: ${result[key][item]}`);
        }
    }
}

solve(['Appricot : 20.4',
    'Fridge : 1500',
    'TV : 1499',
    'Deodorant : 10',
    'Boiler : 300',
    'Apple : 1.25',
    'Anti-Bug Spray : 15',
    'T-Shirt : 10']
);