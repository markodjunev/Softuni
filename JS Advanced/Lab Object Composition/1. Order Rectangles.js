function solve(data) {
    const result = [];

    data.forEach(arr => {
        const [width, height] = arr;
        result.push({ width, height, area, compareTo });
    });

    function area() {
        return this.width * this.height;
    }

    function compareTo(other) {
        return other.area() - this.area() || other.width - this.width;
    }

    return result.sort((a, b) => a.compareTo(b));
}

console.log(solve([[10,5],[5,12]]));