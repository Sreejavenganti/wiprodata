import { Employ } from "./EmployNew";

const employs = [
    new Employ(1, "Keshav",88200),
    new Employ(2,"Rudra",88264),
    new Employ(3, "Arnav",82248),
    new Employ(4, "Venkata",88222)
];

employs.forEach(x => {
    console.log(x.empno + " " +x.name + " " +x.basic);
})