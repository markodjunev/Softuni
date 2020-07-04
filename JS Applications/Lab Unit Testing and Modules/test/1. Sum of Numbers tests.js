let expect = require('chai').expect;

const sum = require("../1. Sum of Numbers").sum;

describe("sum", function () {
    it('should return the sum of the array', function () {
        const result = sum([1, 2, 3]);
        expect(result).to.equal(6, "the result should be 6");
    });

    it('should return NaN if the input is a string', function () {
        const result = sum("test");
        expect(result).to.be.NaN;
    });

    it('should return the sum of array of strings', function () {
        const result = sum(["1", "2", "3"]);
        expect(result).to.equal(6, "the result should be 6");
    });

})