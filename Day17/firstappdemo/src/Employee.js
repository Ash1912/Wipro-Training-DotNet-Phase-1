import Department from './Department';

const Employee = ({name,salary,dname,mgrname}) => {
    return (
        <div>
            <h3>EmployeeDetails</h3>
            <h6>Name: {name}</h6>
            <h6>Salary: {salary}</h6>

            <h5>Department: {dname}</h5>
            <Department dname={dname} mgrname={mgrname}></Department>
        </div>
    )
}

export default Employee;