function solve(arr){
    const rotations = Number(arr.pop());

    if (rotations % arr.length === 0) {
        return arr.join(' ');
    }

    for (let i = 1; i <= rotations; i++) {
        const lastItem = arr.pop();
        arr.unshift(lastItem);
    }

    return arr.join(' ');
}

console.log(solve(['Banana', 
'Orange', 
'Coconut', 
'Apple', 
'15']
));