// import { useEffect, useState } from "react";
// function todosPage ()
// {
//    const [todos, setTodos] = useState([]);
//    useEffect(()=>{
//       async function fetchTodos()
//       {
//         setTimeout(async()=>
//         {
//         const res = await fetch("https://jsonplaceholder.typicode.com/todos");
//         const todos = await res.json();
//         console.log(todos)
//         setTodos(todos); 
//       }, 3000);
//     }
//       fetchTodos();
//    },[])
//  return(
//   <div>
//   {
//   todos.length ==0 ?(
//     <div> Loading </div>
//   ):(
//     todos.map(todo=>(
    
//       <div key={todo.id}>
//         <p> {todo.id} : {todo.title}</p>
//         <br/>
   
//     </div>
//      ))
//   )}

// </div>

 

//  )
// }

// export default todosPage

 
function todosPage ({todos})
{return(
  <div>
  {
  todos?.length ==0 ?(
    <div> Loading </div>
  ):(
    todos?.map(todo=>(
    
      <div key={todo.id}>
        <p> {todo.id} : {todo.title}</p>
        <br/>
   
    </div>
     ))
  )}

</div>

 

 )
}

export async function  getServerSideProps() {
  const res = await fetch("https://jsonplaceholder.typicode.com/todos");
  const todos = await res.json();
  console.log(todos)
  return {
    props:
    {
      todos
    }
  }
}
export default todosPage