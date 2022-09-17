namespace CSharp.Deconstruction.Demo
{
    public static class Extensions
    {
        public static void Deconstruct(this DateTimeOffset date, out int day, out int month, out int year) =>
            (day, month, year) = (date.Day, date.Month, date.Year);
    }
}