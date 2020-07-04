
let expect = require('chai').expect;

const isSymmetric = require("../2. Check for Symmetry").isSymmetric;

describe('isSymmetric', function () {
    it('should return false if the input is not an array', function () {
        const result = isSymmetric("test123");

        expect(result).to.be.false;
    });

    it('should return true if the array is symmetric', function () {
        const result = isSymmetric([1, 1, 1, 1]);

        expect(result).to.be.true;
    });

    it('should return false if the array is not symmetric', function () {
        const result = isSymmetric([5, 6, 7, 8]);

        expect(result).to.be.false;
    });
});