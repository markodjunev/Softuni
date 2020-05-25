function solve(arr){
    let result = arr.sort(function(a, b){return a-b}).slice(0, 2);

    console.log(result.join(' '));
}

solve([30, 15, 50, 5]);