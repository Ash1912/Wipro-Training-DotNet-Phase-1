import React from 'react'
import useFetch from './useFetch'
export default function WCustomHook() {
    const [data] = useFetch("https://jsonplaceholder.typicode.com/todos");
  return (
    <div>
        <b> List of Todo's </b>
        {data && 
        data.map((item) =>{
            return <p key={item.id}> {item.title} </p>;
        })}
    </div>
  )
}
