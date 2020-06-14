class Hex {
    constructor(value = 0) {
        this.value = value;
    }

    valueOf() {
        return this.value;
    }

    toString() {
        let result = "0x";

        result = result.concat(this.value.toString(16).toUpperCase());

        return result;
    }

    plus(number) {
        let result;

        if (typeof number === "object") {
            result = this.value + number.value;
            return new Hex(result);
        }

        result = this.value + number;

        return new Hex(result);
    }

    minus(number) {
        let result;
        if (typeof number == "object") {
            result = this.value - number.value;
            return new Hex(result);
        }

        result = this.value - number.value;

        return new Hex(result);
    }

    parse(string) {
        return parseInt(string, 16);
    }
}

let FF = new Hex(255);
console.log(FF.toString());
FF.valueOf() + 1 == 256;
let a = new Hex(10);
let b = new Hex(5);
console.log(a.plus(b).toString());
console.log(a.plus(b).toString()==='0xF');
