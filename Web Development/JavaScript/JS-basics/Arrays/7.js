let a=[4,9,16,25]
let b=[5,12,23,45, ...a]
console.log(b);

function Sum(...a){
    let r=0
    for(let k of a){
        r+=k
    }
    console.log("Result="+r);
}


Sum(1,2)
Sum(1,2,3)
