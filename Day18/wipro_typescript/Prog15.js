var calc = function (a, b, c) {
    if (typeof c !== 'undefined') {
        return a + b + c;
    }
    return a + b;
};
console.log(calc(8, 7, 14));
console.log(calc(7, 8));
