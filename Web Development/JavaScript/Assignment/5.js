let str="hello world"
const arr = str.split(" ");
let res=arr.map((item)=>{
    let c=item[0].toUpperCase()+item.slice(1,item.length)
    return c
})
console.log(res.toString());