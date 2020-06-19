function sortArray(inputArray, sortType) {
    let ascSortFn = (a, b) => a - b;
    let descSortFn = (a, b) => b - a;

    return inputArray.sort(sortType === "asc" ? ascSortFn : descSortFn);
}

console.log([14, 7, 17, 6, 8], 'asc');