export const Employees = ({name,salary})=> {
    return (
        <div className='container'>
            <h5>EmployeeDetails</h5>
            <h5>Name: {name}</h5>
            <h5>Salary: {salary}</h5>
        </div>
    )
}

export const Departments = ({depname,mgrname})=> {
    return (
        <div>
            <h3>DepartmentName: {depname}</h3>
            <h3>ManagerName: {mgrname}</h3>
        </div>
    )
}