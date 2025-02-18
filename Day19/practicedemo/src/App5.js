// import { ChangeStream } from 'mongodb';
import React, { useEffect, useState } from 'react'

export default function App7() {
    const [count1, setCount1] = useState(10);
    const [count2, setCount2] = useState(20);
    useEffect(()=>
    {
        // console.log(`this func will be called ,
        //     when the component will mount
        //     when state will chnage
        //     when prop wiull change`);
         console.log("useEffect");
         
    },[count1])
  return (
    <div>
       count1   {count1} <br/>
       count2 {count2}
       <br/>
        <button onClick={()=>setCount1(count1+1)}> Update Value of count1</button>
        <button onClick={()=>setCount2(count2+1)}> Update Value of count2</button>
    
    </div>
  )
}
