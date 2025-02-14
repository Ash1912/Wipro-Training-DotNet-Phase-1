import {Component} from "react";

class Greet extends Component {
    render() {
        return (
            <>
            <h1>Welcome to class component</h1>
            <p>This is class component</p>
            <h3>Hello !! {this.props.name} </h3>
            </>

        )
    }
}

export default Greet;