namespace COMP003A.Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("The Green Mile", 592, true);
            Book book2 = new Book("The Martian", 369, true);
            Book book3 = new Book("The Long Walk", 370, false);

            bool running = true;

            while (running)
            {
                Console.WriteLine("\n1. Display All Books");
                Console.WriteLine("2. Update One Book");
                Console.WriteLine("3. Exit");
                Console.Write("Enter Choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("\nBook 1:");
                        book1.DisplayBook();

                        Console.WriteLine("\nBook 2:");
                        book2.DisplayBook();

                        Console.WriteLine("\nBook 3:");
                        book3.DisplayBook();
                        break;

                    case "2":

                }
            }
        }
    }
}
