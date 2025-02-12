function getEmployee(emp) {
    return "".concat(emp.empid, " ").concat(emp.empname, " ").concat(emp.dept, " ").concat(emp.salary);
}
var emp1 = {
    empid: 9,
    empname: 'Uru',
    salary: 50000,
    dept: 'HR',
};
console.log(getEmployee(emp1)); // This should work now
// Object destructuring
function getEmployeeobjdestruc(_a) {
    var empname = _a.empname, dept = _a.dept;
    return "".concat(empname, " ").concat(dept);
}
var emp2 = {
    empid: 11,
    empname: 'Uru',
    salary: 50000,
    dept: 'HR',
};
console.log(getEmployeeobjdestruc(emp2)); // This should work now
