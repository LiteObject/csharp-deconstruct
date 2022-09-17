# Deconstruction in C#: Unpacking variables from types 
>Deconstructing is unpacking types into single pieces; for instance, a tuple into its items or a class into its properties.

Let's learn more about this process by looking at the following code examples.

## Example: Deconstruction of a tuple object 

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

## Example: Deconstruction of a dictionary object

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
## Example: Deconstruction of a class
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

## Example: Deconstruction of a record

```csharp
// define a record called "Person" with the props
public record Person(string FirstName, string LastName);
```
```csharp
// instantitate a Person record
var person = new Person("Jon", "Doe");
var (firstName, lastName) = person;
Console.WriteLine($"My name is {firstName} {lastName}");
```

## Example: Deconstruction using extension method 

```csharp
// implemeted an extension method
public static void Deconstruct(this DateTimeOffset date, out int day, out int month, out int year) =>
            (day, month, year) = (date.Day, date.Month, date.Year);
```

```csharp
 // now instantitate DateTimeOffset
var date = new DateTimeOffset(2022, 9, 17, 0, 0, 0, 0, TimeSpan.Zero);

// deconstruct DateTimeOffset objcet
(int day, int month, int year) = date; 
Console.WriteLine($"I wrote this example on: {month}/{day}/{year}");
```

---
## Links:
- [Deconstructing tuples and other types](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/functional/deconstruct)
- [More on C# Record Types](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/tutorials/records)