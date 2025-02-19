// import ReactDOM from "react-dom/client";
import useFetch from "./useFetch";

export const Home1 = () => {
  const [data] = useFetch("https://jsonplaceholder.typicode.com/todos");

  return (
    <>
    <b> IN HOME ! </b>
      {data &&
        data.map((item) => {
          return <p key={item.id}>{item.title}</p>;
        })}
    </>
  );
};