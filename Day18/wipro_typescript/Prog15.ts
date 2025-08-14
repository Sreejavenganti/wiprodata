const calc = (a:number, b:number, c?:number) => {
    if (typeof c !=='undefined') {
        return a + b + c;
    }
    return a + b;
}

console.log(calc(8,7,14));
console.log(calc(7,8));