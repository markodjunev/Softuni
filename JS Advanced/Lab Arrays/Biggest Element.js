function solve(matrix = []){
    let max = -200000;

    for (let row = 0; row < matrix.length; row++) {
        for (let col = 0; col <= matrix.length; col++) {
            let element = Number(matrix[row][col]);
            if(element > max){
                max = element;
            }
        }
        
    }

    console.log(max);
}

solve([[20, 50, 10],
    [8, 33, 145]]
   );