namespace CSharp.Deconstruction.Demo
{
    // declare a class with Deconstruct method(s)
    class MyBook
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public MyBook(int id, string title, string author)
        {
            Id = id;
            Title = title;
            Author = author;
        }

        public void Deconstruct(out int id, out string title, out string author)
        {
            id = Id;
            title = Title;
            author = Author;
        }

        public void Deconstruct(out string title, out string author)
        {
            title = Title;
            author = Author;
        }
    }
}