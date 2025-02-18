
import React, { act, useReducer, useState } from 'react'

const initialState =
{
    tasks : []
};
const reducer = (state, action)=>
{
    if(action.type=="ADD-TASK")
    {
       return {...state, tasks:[...state.tasks, action.payload]}; 
    }
    if(action.type=="REMOVE-ITEM")
    {
        return {...state,
            tasks : state.tasks.filter(task=>task.id!==action.payload)};

    }
        return state;
}

export default function TaskList() {
    
const addTask = () =>
    {
        alert("a");
        dispatch({type:'ADD-TASK',
            payload: {id:Date.now(), text :task}
         });
         setTask(' ');
    }
 const removeTask = (id)=>
    {
         dispatch({type:"REMOVE-ITEM",
            payload:id
         });
    }   
   const [state, dispatch] =  useReducer (reducer, initialState);
   const [task, setTask] = useState('');
   return (
    <div><h1> TaskList </h1> 
    <b> Add Task </b>
    <input type='text' value={task} onChange={(e) => setTask(e.target.value)}/>
    <button onClick={addTask}> Add New Task </button>
    <ul>
        {state.tasks.map(task=>(
        
            // <li> {task.id} </li>
         <li key={task.id}> {task.text} 
         <button onClick={()=> removeTask(task.id)}> Remove Task </button>
         </li> ))
    }
    </ul>
    </div>
  )
}
