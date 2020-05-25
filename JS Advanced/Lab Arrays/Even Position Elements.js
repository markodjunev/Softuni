function solve(arr){
    let result = [];
    for (let i = 0; i < arr.length; i+=2) {
        const element = arr[i];
        
        result.push(element);
    }

    return result.join(' ');
}