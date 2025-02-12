interface Employee {
    empid: number;
    empname: string;
    salary: number;
    dept: string;
}

function getEmployee(emp: Employee) {
    return `${emp.empid} ${emp.empname} ${emp.dept} ${emp.salary}`;
}

let emp1 = {
    empid: 9,
    empname: 'Uru',
    salary: 50000,
    dept: 'HR',
};
console.log(getEmployee(emp1)); // This should work now

// Object destructuring

function getEmployeeobjdestruc({ empname, dept }: Employee) {
    return `${empname} ${dept}`;
}

let emp2 = {
    empid: 11,
    empname: 'Uru',
    salary: 50000,
    dept: 'HR',
};

console.log(getEmployeeobjdestruc(emp2)); // This should work now
