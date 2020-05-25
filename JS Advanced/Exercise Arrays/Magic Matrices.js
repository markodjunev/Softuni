function solve(matrix = []) {
    let sum = 0;

    matrix[0].forEach(x => {
        sum += x;
    });

    for (let row = 1; row < matrix.length; row++) {
        let curSum = 0;
        matrix[row].forEach(x => curSum += x);
        
        if(curSum != sum){
            return false;
        }
    }

    for (let row = 0; row < matrix.length; row++) {
        let curSum = 0;
        
        for (let col = 0; col < matrix.length; col++) {
            curSum += matrix[row][col];
        }
        
        if (curSum != sum){
            return false;
        }
    }

    return true;
}

console.log(solve([[4, 5, 6],
    [6, 5, 4],
    [5, 5, 5]]
   ));