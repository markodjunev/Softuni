function solve(matrix = []) {
    //console.log(matrix.length);
    let sumLeft = 0;
    let sumRight = 0;
    let rightIndex = matrix.length - 1;

    for (let i = 0; i < matrix.length; i++) {
        let leftElement = Number(matrix[i][i]);
        sumLeft+=leftElement;
        let rightElement = Number(matrix[rightIndex][i]);
        rightIndex--;
        sumRight+=rightElement;
    }

    console.log(sumLeft + ' ' + sumRight);
}

solve([[3, 5, 17],
[-1, 7, 14],
[1, -8, 89]]
);