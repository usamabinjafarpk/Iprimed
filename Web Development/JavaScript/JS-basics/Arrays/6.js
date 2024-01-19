const n=[4,9,16,25]
n.map((i)=>{
    console.log(i);
})
let newArr=n.map((i)=>Math.sqrt(i))
console.log(newArr);
newArr=n.map((i)=>i*10)
console.log(newArr);
newArr=n.map((i)=>i%2==0)
console.log(newArr);
const persons=[
    {fname:"Sachin",lname:"Tendulkar"},
    {fname:"Virat",lname:"Kohli"},
    {fname:"Rohit",lname:"Sharma"}
]

let res=persons.map((item)=>[item.fname,item.lname].join(" "))
console.log(res);

let flowers=["rose","lilly","jasmin"]
let r=flowers.map((f)=>{
    let m=f[0].toUpperCase()+f.slice(1,f.length)
    return m
})
console.log(r);