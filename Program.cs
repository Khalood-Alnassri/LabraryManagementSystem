using System.Diagnostics;

namespace LabraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //system storge

            string[] BookTittle = new string[100];
            string [] BookISBN = new string[100];
            string[] BookAuther = new string[100];
            string[] BorrowerName = new string[100];
            bool[] BookAvailability = new bool[100];
            int LastBookIndex = -1;

            //seed data
            BookTittle[0] = "Math";
            BookISBN[0] = "1679";
            BookAuther[0] = "Ahmed";
            BorrowerName[0] = "No";
            BookAvailability[0] = true;
            LastBookIndex++;

            BookTittle[0] = "Arbic";
            BookISBN[0] = "4570";
            BookAuther[0] = "Ali";
            BorrowerName[0] = "No";
            BookAvailability[0] = true;
            LastBookIndex++;

            BookTittle[0] = "Math";
            BookISBN[0] = "1679";
            BookAuther[0] = "Ahmed";
            BorrowerName[0] = "No";
            BookAvailability[0] = true;
            LastBookIndex++;


            bool exit = false;
            while (true)
            {

                Console.WriteLine("Welcome to labrary system.");
                Console.WriteLine("Select process you need :");
                Console.WriteLine("1. Add New Book.");
                Console.WriteLine("2. Borrow Book.");
                Console.WriteLine("3. Return Book.");
                Console.WriteLine("4. Search Book.");
                Console.WriteLine("5. List All Available Books.");
                Console.WriteLine("6. Transfer Book.");
                Console.WriteLine("7. Exit.");

                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:

                        Console.WriteLine("Enter Book Tittle : ");
                        BookTittle[LastBookIndexTracker + 1] = Console.ReadLine();
                        Console.WriteLine("Enter Book ISBN : ");
                        BookISBN[LastBookIndexTracker + 1] = Console.ReadLine();
                        Console.WriteLine("Enter Book Auther : ");
                        BookAuther[LastBookIndexTracker + 1] = Console.ReadLine();
                        Console.WriteLine("Enter Borrower Name : ");
                        BorrowerName[LastBookIndexTracker + 1] = Console.ReadLine();

                        LastBookIndex++;

                        break;

                    case 2:

                    break;

                    case 3:

                    break;

                    case 4:

                    break;

                    case 5:

                    break;

                    case 6:

                    break;

                    case 7:

                        exit = true;

                    break;


                    default:

                        Console.WriteLine("Invalid option.");

                    break;


                }

                if (exit == true)
                {
                    break;
                }




            }








        }
    }
}
