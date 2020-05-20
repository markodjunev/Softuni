function solve(items){
    let sum = 0;
    let sum2 = 0;
    let concat = '';

    for(let i = 0; i < items.length; i++){
        sum += items[i];
        sum2 += 1/items[i];
        concat += items[i];
    }

    console.log(sum);
    console.log(sum2);
    console.log(concat);
}