import { Component } from "react";

class Category extends Component {
    render() 
    {
        return <div>
            <h2> Category Details</h2>
            <p>
                <label>CategoryName:{this.props.Cname}</label>
            </p>
        </div>
    }
}

export default Category;