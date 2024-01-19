const Greet=(name)=>{
    console.log("Hello"+name)
}

Greet("Usama")

const Add=(a,b)=>a+b
console.log(Add(5,5));

let IsEven=(n)=>n%2==0
console.log(IsEven(2)?"Even":"Odd");
console.log(IsEven(3)?"Even":"Odd");

const sum=(a)=>{
    let res=0
    for(let k of a)
    {
        res+=k
    }
    return res
}
console.log(sum([1,2,3,4]));