let str="paatpsss"
let p=0
let s=0
for(let i=0;i<str.length;i++){
    if(str[i]=="p"){
        p+=1
    }
    else if(str[i]=="s"){
        s++
    }
}
if(p==s){
    console.log("True");
}
else{
    console.log("False");
}