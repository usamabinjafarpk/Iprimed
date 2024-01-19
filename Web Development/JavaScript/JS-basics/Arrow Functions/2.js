let Students=[
    {Id:1, Name:"Amal", Age:22},
    {Id:2, Name:"Anna", Age:20},
    {Id:3, Name:"Usama", Age:21}
]

let GetStud=()=> Students
for(let ob of GetStud()){
    console.log(`Id=${ob.Id} Name=${ob.Name} Age=${ob.Age}`);
}
console.log();
let GetStudById=(id)=>{
    for(let ob of Students){
        if(ob.Id==id){
            return ob;
        }
    }
    return null
}
let obj=GetStudById(1)
if(obj!=null)
    console.log(`Id=${obj.Id} Name=${obj.Name} Age=${obj.Age}`);
else
    console.log("Invalid Id");