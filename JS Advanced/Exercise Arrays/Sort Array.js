function solve(arr){
    arr.sort((a,b) => a.length - b.length || a.localeCompare(b));

    for (let i = 0; i < arr.length; i++) {
        const element = arr[i];
        console.log(element);
    }
}