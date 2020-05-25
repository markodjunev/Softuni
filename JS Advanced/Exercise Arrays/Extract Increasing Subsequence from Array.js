function solve(arr) {
    const first = Number(arr[0]);
    const result = [first];
    let biggestNum = first;
    arr.reduce((_, curr, i) => {
        if (curr >= biggestNum && i !== 0) {
            biggestNum = curr;
            result.push(curr);
        }
    })

    return result.join('\n');
}

solve([20, 
    3, 
    2, 
    15,
    6, 
    1]
     );