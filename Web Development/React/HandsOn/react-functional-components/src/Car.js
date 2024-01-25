function Car({name,color}){
    return(
        <>
        <h1>Car:{name}</h1>
        <h2>Color:{color}</h2>
        </>
    )
}


export default function Garage(props) {
    let clr="black"
  return (
    <div>
        <Car name="Audi" color={clr}/>
        <hr></hr>
        <Car name={props.name} color={props.color}/>
    </div>
  )
}
