function getFibonator() {
    let previous = 1;
    let current = 0;
    
    return fibonaci;

    function fibonaci() {
        let sum = previous + current;
        previous = current;
        current = sum;

        return current;
    }
}

let fib = getFibonator();
console.log(fib()); // 1
console.log(fib()); // 1
console.log(fib()); // 2
console.log(fib()); // 3
console.log(fib()); // 5
console.log(fib()); // 8
console.log(fib()); // 13
