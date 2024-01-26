class BookStore{
    constructor(isbn,bookname,booktitle,bookauthor,quantityofbooks,bookprice){
        this.isbn=isbn
        this.bookname=bookname
        this.booktitle=booktitle
        this.bookauthor=bookauthor
        this.quantityofbooks=quantityofbooks
        this.bookprice=bookprice
    }
    Display(){
        let billAmount=this.bookprice*this.quantityofbooks
        console.log(`ISBN:${this.isbn}, Book Name:${this.bookname}, Book Title:${this.booktitle}, Author:${this.bookauthor}, Qty:${this.quantityofbooks}, Book Price:${this.bookprice}, Bill Amount=${billAmount}`);
    }
}

let obj=new BookStore(123,"ABC","BCD","DEF",10,100)
obj.Display()