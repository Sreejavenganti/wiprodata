"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var EmployNew_1 = require("./EmployNew");
var employs = [
    new EmployNew_1.Employ(1, "Keshav", 88200),
    new EmployNew_1.Employ(2, "Rudra", 88264),
    new EmployNew_1.Employ(3, "Arnav", 82248),
    new EmployNew_1.Employ(4, "Venkata", 88222)
];
employs.forEach(function (x) {
    console.log(x.empno + " " + x.name + " " + x.basic);
});
