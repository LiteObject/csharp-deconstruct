namespace CSharp.Deconstruction.Demo
{

    // define a record called "Person" with the props
    public record Person(string FirstName, string LastName);

    public class Program
    {
        public static void Main()
        {
            /******************************************* 
            * Example: Deconstruction of a tuple object 
            *******************************************/

            // declare a tuple
            var book = ("C-Sharp Basics", "Jon Doe", 1.99);

            // now we can destruct the tuples into individual items
            var (title, author, price) = book;

            // use them like variables
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Price: {price}");

            /******************************************* 
            * Example: Deconstruction of a dictionary object 
            *******************************************/

            // declare a dictionary object
            var books = new Dictionary<string, string>
            {
                {"Book One", "Author One"},
                {"Book Two", "Author Two"},
            };

            // unpack each item into a key/value pair (title/author pair) and loop through
            foreach ((string k, string v) in books)
            {
                Console.WriteLine($"\"{k}\" written by {v}");
            }

            /******************************************* 
            * Example: Deconstruction of a class 
            *******************************************/

            // instantiate the "MyBook" class
            var mybook = new MyBook(1, "CSharp Bacis", "Jon Doe");

            // deconstruct class properties into a collection of variables
            var (myBookTitle, myBookAuthor) = mybook;

            // use the variables as needed
            Console.WriteLine($"\"{myBookTitle}\" by {myBookAuthor}");


            /******************************************* 
            * Example: Deconstruction of a record 
            *******************************************/

            // instantitate a Person record
            var person = new Person("Jon", "Doe");

            // deconstruct person record
            var (firstName, lastName) = person;
            Console.WriteLine($"My name is {firstName} {lastName}");


            /******************************************* 
            * Example: Deconstruction using extension method 
            *******************************************/

            // implemeted an extension method in "Extensions.cs" file
            // now instantitate DateTimeOffset
            var date = new DateTimeOffset(2022, 9, 17, 0, 0, 0, 0, TimeSpan.Zero);

            // deconstruct DateTimeOffset objcet
            (int day, int month, int year) = date; 
            Console.WriteLine($"I wrote this example on: {month}/{day}/{year}");
        }
    }
}