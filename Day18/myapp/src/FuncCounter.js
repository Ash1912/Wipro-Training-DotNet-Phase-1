import { useState } from "react";

export default function FuncCounter() {
  const [count, setCount] = useState(0);

  return (
    <div className="text-center">
      <h2>Counter: {count}</h2>
      <button className="btn btn-primary me-2" onClick={() => setCount(count + 1)}>Increase</button>
      <button className="btn btn-danger" onClick={() => setCount(count - 1)}>Decrease</button>
    </div>
  );
}
