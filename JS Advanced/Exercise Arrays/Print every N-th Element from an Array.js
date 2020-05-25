function solve(arr){
    let nth = +arr.pop();

    for (let i = 0; i < arr.length; i+=nth) {
        const element = arr[i];
        console.log(element);
    }
}