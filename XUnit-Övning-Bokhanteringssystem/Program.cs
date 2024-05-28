using XUnit_Övning_Bokhanteringssystem.Models;

namespace XUnit_Övning_Bokhanteringssystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var library = new Library();

            var book1 = new Book { ISBN = "123", Title = "Inte Alla Hästar Hemma", Author = "Herr Gnägg", Year = 2024 };
            var book2 = new Book { ISBN = "456", Title = "Inte Alla Hästar Hemma", Author = "Herr Gnägg", Year = 2024 };
        }
    }
}
