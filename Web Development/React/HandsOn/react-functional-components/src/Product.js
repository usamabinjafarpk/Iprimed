const Product=(props)=>{
    return(
        <>
            <pre>
                Name:{props.item.name}<br/>
                price:{props.item.price}
            </pre>
        </>
    )
}

const Shop=()=>{
    const product={name:"IPhone" ,price:145000}
    return(
        <>
            <Product item={product}/>
            <Product item={{name:"Lap",price:45000}}/>
        </>
    )
}
export default Shop