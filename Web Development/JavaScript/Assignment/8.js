let arr=[1,2,3,4,5,6]
let temp=arr[0]
arr[0]=arr[arr.length-1]
arr[arr.length-1]=temp
arr.forEach(element => {
    console.log(element);
});