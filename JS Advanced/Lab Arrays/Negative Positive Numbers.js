function solve(arr){
    let result = [];

    for (let i = 0; i < arr.length; i++) {
        const element = Number(arr[i]);
        
        if(element < 0){
            result.unshift(element);
        }
        else{
            result.push(element);
        }
    }

    for (let i = 0; i < result.length; i++) {
        const element = result[i];
        
        console.log(element);
    }
}