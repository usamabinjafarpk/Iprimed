// 8.	Create a simple class representing a "Book." Include properties such as title, author, and publication year. Write methods for displaying book details.
class Book {
    constructor(title, author, publicationYear) {
      this.title = title;
      this.author = author;
      this.publicationYear = publicationYear;
    }
  
    Display() {
      console.log(`Title:${this.title} Author:${this.author} Published year:${this.publicationYear}`);
    }
  }
  const book = new Book('ABCD', 'asdf', 2022);
  book.Display();
    