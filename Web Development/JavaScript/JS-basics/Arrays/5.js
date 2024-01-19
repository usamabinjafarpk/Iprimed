let n=[12,24,35,67,89,90]
n.forEach((i)=>console.log(i))
n.forEach((i)=>console.log(i*i))
console.clear()
n.forEach((i)=>{
    if(i%2==0){
        console.log(i);
    }
})
console.clear()
let k=n.find((i)=>i>50)
console.log(k);
k=n.find((i)=>i%2!=0)
console.log(k);


let a=n.filter((i)=>i>35)
console.log(a);
a=n.filter((i)=>i%2==0)
console.log(a);
