function solve(input) {
    let result = {};
    let bottles = {};

    for (const item of input) {
        let [product, quantity] = item.split(' => ');

        if (!result.hasOwnProperty(product)) {
            result[product] = 0;
        }

        result[product] += Number(quantity);

        if (Number(result[product]) >= 1000) {
            if (!bottles.hasOwnProperty(product)) {
                bottles[product] = 0;
            }

            let leftJuice = Number(result[product]) % 1000;
            bottles[product] += ((Number(result[product]) - leftJuice) / 1000);
            result[product] = leftJuice;
        }
    }

    for (let [key, value] of Object.entries(bottles)) {
        console.log(`${key} => ${value}`);
    }
}

solve(['Orange => 2000',
    'Peach => 1432',
    'Banana => 450',
    'Peach => 600',
    'Strawberry => 549']
);