# csharp-deconstruct
Example of deconstructing operation - unpacking variables from types - in C#

>Deconstructing is unpacking types into single pieces; for instance, a tuple into its items or a class into its properties.

## Example: Deconstruct tuple

```csharp
// declare a tuple
var book = ("C-Sharp Basics", "Jon Doe", 1.99);

// now we can destruct the tuples into individual items
var (title, author, price) = book;

// use them like variables
Console.WriteLine($"Title: {title}");
Console.WriteLine($"Author: {author}");
Console.WriteLine($"Price: {price}");

```

## Example: Deconstruct dictionary

```csharp
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
```
## Example: Deconstruct class
We need to implement the `Deconstruct` method. We can have multiple implementation of this method by overloading.

```csharp
// declare a class with Deconstruct method(s)
class MyBook
{
    public int Id {get; set;}
    public string Title {get; set;}
    public string Author {get; set;}

    public MyBook(int id, string title, string author)
    {
        Id = id;
        Title = title;
        Author = author;
    }

    // must have the "out" modifier with each param
    public void Deconstruct(out int id, out string title, out string author)
    {
        id = Id;
        title = Title;
        author = Author;
    }

    // must have the "out" modifier with each param
    public void Deconstruct(out string title, out string author)
    {
        title = Title;
        author = Author;
    }
}

```
Let's use the MyBook class

```csharp
// instantiate the "MyBook" class
var mybook = new MyBook(1, "CSharp Bacis", "Jon Doe");

// deconstruct class properties into a collection of variables
var (myBookTitle, myBookAuthor) = mybook;

// use the variables as needed
Console.WriteLine($"\"{myBookTitle}\" by {myBookAuthor}");
```