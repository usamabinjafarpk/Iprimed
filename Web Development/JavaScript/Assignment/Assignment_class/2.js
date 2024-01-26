
class Student{
    constructor(RollNo,StudName,MarksInEng,MarksInMaths,MarksInScience){
        this.RollNo=RollNo
        this.StudName=StudName
        this.MarksInEng=MarksInEng
        this.MarksInMaths=MarksInMaths
        this.MarksInScience=MarksInScience
    }
    Display(){
        let total=this.MarksInEng+this.MarksInMaths+this.MarksInScience
        let percentage=(total/300)*100
        console.log(`Roll No:${this.RollNo}, Name:${this.StudName}, Mark in English:${this.MarksInEng}, Mark in Maths:${this.MarksInMaths}, Mark in Science:${this.MarksInScience}, Total Mark=${total}, Percentage:${percentage}%`);
    }
}

let obj=new Student(12,"Usama",100,100,100)
obj.Display()