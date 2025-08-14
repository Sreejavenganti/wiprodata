interface  IEmploy {
    empno : number;
    name : string;
    salary : number;

}
const employ1 : IEmploy = {
    empno : 1,
    name : "Krishna",
    salary : 90000
}
console.log(`Employ No ${employ1.empno} Employ Name ${employ1.name} Employ salary ${employ1.salary}`)