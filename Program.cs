// declare a tuple
var book = ("C-Sharp Basics", "Jon Doe", 1.99);

// now we can destruct the tuples into individual items
var (title, author, price) = book;

// use them like variables
Console.WriteLine($"Title: {title}");
Console.WriteLine($"Author: {author}");
Console.WriteLine($"Price: {price}");


// declare a dictionary object
var books = new Dictionary<string, string>{
    {"Book One", "Author One"},
    {"Book Two", "Author Two"},
};

// unpack each item into a key/value pair (title/author pair) and loop through
foreach((string k, string v) in books)
{
    Console.WriteLine($"\"{k}\" written by {v}");
}

// instantiate the "MyBook" class
var mybook = new MyBook(1, "CSharp Bacis", "Jon Doe");

// deconstruct class properties into a collection of variables
var (myBookTitle, myBookAuthor) = mybook;

// use the variables as needed
Console.WriteLine($"\"{myBookTitle}\" by {myBookAuthor}");
