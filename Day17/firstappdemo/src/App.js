import './App.css';
import { Departments, Employees } from './Components';
import Category from './Category';
import Product from './Product';
import Employee from './Employee';
import Welcome from './Welcome';
import Greet from './Greet';

function App() {
  return (
    <div>
      <Welcome></Welcome>
      <Employee name="Zara" salary="80000" dname="Developer" mgrname="Zahir"></Employee>
      <Employees name="Zara" salary="80000"></Employees>
      <Departments depname="Developer" mgrname="Zahir"></Departments>
      <Greet name="Ash"/>
      <Product Pname="Laptop" Cname="Computers"></Product>
      <Category Cname="Electronics"></Category>
    </div>
  );
}

export default App;
