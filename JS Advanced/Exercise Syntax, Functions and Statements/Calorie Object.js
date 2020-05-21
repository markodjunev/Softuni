function solve(params){
    let obj = {};
    for(let i=0; i<params.length; i+=2){
        let propName = params[i];
        let value = Number(params[i + 1]);

        obj[propName] = value;
    }

    console.log(obj);
}

solve(['Potato', '93', 'Skyr', '63', 'Cucumber', '18', 'Milk', '42']);