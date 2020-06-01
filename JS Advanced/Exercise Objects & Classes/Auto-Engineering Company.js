function solve(input) {
    let result = {};

    for (const item of input) {
        let [make, model, count] = item.split(' | ');
        count = Number(count);
        if(!result.hasOwnProperty(make)){
            result[make] = {};
        }

        result[make].hasOwnProperty(model) ? result[make][model] += count : result[make][model] = count;
    }

    for (const [make, models] of Object.entries(result)) {
        console.log(make);
        for (let [model, count] of Object.entries(models)) {
            console.log(`###${model} -> ${count}`);
        }
    }
}

solve(['Audi | Q7 | 1000',
    'Audi | Q6 | 100',
    'BMW | X5 | 1000',
    'BMW | X6 | 100',
    'Citroen | C4 | 123',
    'Volga | GAZ-24 | 1000000',
    'Lada | Niva | 1000000',
    'Lada | Jigula | 1000000',
    'Citroen | C4 | 22',
    'Citroen | C5 | 10']
);