// Array manipulation using map
const marks: number[] = [70, 80, 90, 87, 95, 90];

// Applying a bonus of +5 to each mark without modifying the original array
const withbonus = marks.map(m => m + 5);
console.log("Marks with Bonus:", withbonus);
console.log("Original Marks:", marks);

// Class declaration in TypeScript
class Employee {
    empid: number;
    empname: string;
    salary: number;

    constructor(empid: number, empname: string, salary: number) {
        this.empid = empid;
        this.empname = empname;
        this.salary = salary;
    }
}

// Creating an array of Employee objects
let emps: Employee[] = [
    new Employee(1, 'Ashish', 50000),
    new Employee(2, 'Urvashi', 60000),
    new Employee(3, 'Ayush', 70000),
    new Employee(4, 'Anushka', 750000),
];

// Using map to update salaries without modifying original objects
let updateemp = emps.map(em => em.salary + 2000);
console.log("Updated Salaries:", updateemp);

// Creating new Employee objects with updated salaries
let updatedemp = emps.map(em => new Employee(em.empid, em.empname, em.salary + 2000));
console.log("Updated Employee Objects:", updatedemp);

// Filtering employees with salary greater than 50,000
let updatednew = emps.filter(e => e.salary > 50000);
console.log("Filtered Employees (Salary > 50,000):", updatednew);

// Filtering and updating salaries
let updatedne = emps
    .filter(e => e.salary > 60000)
    .map(e => new Employee(e.empid, e.empname, e.salary + 5000));
console.log("Filtered and Updated Employees (Salary > 60,000):", updatedne);

// Using reduce to calculate the sum of an array
let values = [10, 20, 30, 40, 50];
let resofreduce = values.reduce((acc, num) => acc + num, 0);
console.log("Sum of Values using Reduce:", resofreduce);

// Using reduce to calculate total salary of employees
const totsal = emps.reduce((acc, emp) => acc + emp.salary, 0);
console.log("Total Salary of Employees:", totsal);

// Finding an element using find
let empFound = emps.find(e => e.empid === 2);
console.log("Employee with ID 2:", empFound);

// Sorting employees by salary in ascending order
let sortedEmps = [...emps].sort((a, b) => a.salary - b.salary);
console.log("Employees Sorted by Salary (Ascending):", sortedEmps);

// Sorting employees by name in alphabetical order
let sortedByName = [...emps].sort((a, b) => a.empname.localeCompare(b.empname));
console.log("Employees Sorted by Name (Alphabetical):", sortedByName);

// Checking if at least one employee has a salary above 1,00,000 using some()
let isHighEarner = emps.some(e => e.salary > 100000);
console.log("Is there any high earner (Salary > 1,00,000)?:", isHighEarner);

// Checking if all employees earn more than 40,000 using every()
let allEarnMoreThan40K = emps.every(e => e.salary > 40000);
console.log("Do all employees earn more than 40,000?:", allEarnMoreThan40K);

// Using forEach to log employee details
console.log("Logging Employee Details:");
emps.forEach(e => console.log(`ID: ${e.empid}, Name: ${e.empname}, Salary: ${e.salary}`));

// Using splice to remove an element from an array
let nums = [1, 2, 3, 4, 5];
nums.splice(2, 1); // Removes the element at index 2
console.log("Array after splice (Removing index 2):", nums);

// Using spread operator to merge two arrays
let arr1 = [1, 2, 3];
let arr2 = [4, 5, 6];
let mergedArray = [...arr1, ...arr2];
console.log("Merged Array using Spread Operator:", mergedArray);

// Using object destructuring
const { empid, empname } = emps[0];
console.log(`Destructured Employee - ID: ${empid}, Name: ${empname}`);

// Using array destructuring
let [first, second, ...rest] = values;
console.log(`First Value: ${first}, Second Value: ${second}, Rest: ${rest}`);

// Using optional chaining to safely access properties
let unknownEmp: Employee | null = null;
console.log("Trying Optional Chaining on null object:", unknownEmp?.empname ?? "No Employee Found");

// Using nullish coalescing operator
let bonus: number | null = null;
console.log("Bonus using Nullish Coalescing:", bonus ?? 1000);

// Using Set to store unique values
let uniqueMarks = new Set(marks);
console.log("Unique Marks using Set:", uniqueMarks);

// Using Map to store key-value pairs
let empMap = new Map<number, string>();
empMap.set(1, "Ashish");
empMap.set(2, "Urvashi");
console.log("Employee Map:", empMap);

// Using a generator function
function* numberGenerator() {
    yield 1;
    yield 2;
    yield 3;
}
let gen = numberGenerator();
console.log("Generator Output:", gen.next().value, gen.next().value, gen.next().value);
