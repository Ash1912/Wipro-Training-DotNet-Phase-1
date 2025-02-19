import React from 'react'
import useToggle from './useToggle'
export default function CustomHook() {
    const [value, toggleValue] = useToggle(false);
  return (
    <div> 
        <div> {value.toString()} </div>
        <button onClick={toggleValue}> Toggle </button>

    </div>
  )
}
