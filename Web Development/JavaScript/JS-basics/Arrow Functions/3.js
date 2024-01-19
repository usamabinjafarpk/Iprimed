function fn(f1,f2){
    console.log(f1());
    console.log(f2());
}

fn(
    ()=>"Hi",
    ()=>"Hello"
)

setTimeout(function(){
    console.log("Hello all");
},5000)


setTimeout(()=>console.log("Heheheh"),6000)