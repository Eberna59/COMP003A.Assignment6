namespace COMP003A.Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {    // Book Tracker
            Book book1 = new Book("The Green Mile", 592, true); // 3 sepaart books to display for updates and complete status.
            Book book2 = new Book("The Martian", 369, true);
            Book book3 = new Book("The Long Walk", 370, false);

            bool running = true; // controls when the menu continyes running

            while (running) 
            {   // user meny options
                Console.WriteLine("\n1. Display All Books");
                Console.WriteLine("2. Update One Book");
                Console.WriteLine("3. Exit");
                Console.Write("Enter Choice: ");

                string choice = Console.ReadLine();

                switch (choice) // determines which menu option the user picks
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
                        Console.Write("Select book (1-3): ");
                        string selection = Console.ReadLine();

                        switch (selection)
                        {
                            case "1":
                                book1.MarkComplete();
                                Console.WriteLine("Updated Book 1.");
                                break;

                            case "2":
                                book2.MarkComplete();
                                Console.WriteLine("Updated Book 2.");
                                break;

                            case "3":
                                book3.MarkComplete();
                                Console.WriteLine("Updated Book 3.");
                                break;
                        }break;

                    case "3": // ends the loops and stops program
                        running = false;
                        Console.WriteLine("Progran ended");
                        break;

                }
            }
        }
    }
}
