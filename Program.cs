// See https://aka.ms/new-console-template for more information
using lbms;
//book b1 = new book { title = "It starts with us", isbn="123A",author = "Collen Coover" }; //zero constructor
//book b2 = new book { title = "It ends with us", isbn = "345B", author = "Collen Coover" };
book b1=new book("It starts with us","123A","Collen Coover");
book b2=new book("It ends with us","345B","Collen Coover"); //parameter constructor
b1.display();
b2.display();

