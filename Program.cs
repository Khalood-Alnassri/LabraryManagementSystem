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
            BorrowerName[0] = "Salim ";
            BookAvailability[0] = false;
            LastBookIndex++;

            BookTittle[0] = "Arbic";
            BookISBN[0] = "4570";
            BookAuther[0] = "Ali";
            BorrowerName[0] = "Sara";
            BookAvailability[0] = false;
            LastBookIndex++;

            BookTittle[0] = "Math";
            BookISBN[0] = "1679";
            BookAuther[0] = "Ahmed";
            BorrowerName[0] = " ";
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
                        //add new book

                        Console.WriteLine("Enter Book Tittle : ");
                        BookTittle[LastBookIndex + 1] = Console.ReadLine();
                        Console.WriteLine("Enter Book ISBN : ");
                        BookISBN[LastBookIndex + 1] = Console.ReadLine();
                        Console.WriteLine("Enter Book Auther : ");
                        BookAuther[LastBookIndex + 1] = Console.ReadLine();

                        LastBookIndex++;

                        break;

                    case 2:
                        //Check if book exists and is available before lending

                        Console.WriteLine("choice : \n a. Enter book tittle. \n b. Enter book ISBN. ");
                        string choice = Console.ReadLine();
                        
                        if (choice == "a")
                        {
                            Console.WriteLine("Enter book tittle :");
                            string tittle = Console.ReadLine();

                            bool book_tittleFound = false;
                            bool availability ;
                            for (int i = 0; i < 100; i++)
                            {
                                if (tittle == BookTittle[i])
                                {
                                    book_tittleFound =true;
                                    availability =BookAvailability[i];
                                    Console.WriteLine("Enter borrow name :");
                                    BorrowerName[i] = Console.ReadLine();
                                    Console.WriteLine("The book boroow successfully.");
                                    break;

                                }
                            }
                            if (book_tittleFound == false)
                            {
                                Console.WriteLine("Book tittle not found.");
                            }


                        }

                        else if (choice == "b")
                        {
                            Console.WriteLine("Entetr book ISBN :");
                            string book_num = Console.ReadLine();

                            bool book_ISBNFound = false;
                            bool availability;
                            for (int i = 0; i < 100; i++)
                            {
                                if (book_num == BookTittle[i])
                                {
                                    book_ISBNFound = true;
                                    availability = BookAvailability[i];
                                    BorrowerName[i] = Console.ReadLine();
                                    Console.WriteLine("The book boroow successfully.");
                                    break;

                                }
                            }
                            if (book_ISBNFound == false)
                            {
                                Console.WriteLine("Book ISBN not found.");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Invalid choice.");
                        }


                    break;

                    case 3:
                        //Return Book 

                        Console.WriteLine("choice : \n a. Enter book tittle. \n b. Enter book ISBN. ");
                        string choices = Console.ReadLine();

                        if (choices == "a")
                        {
                            Console.WriteLine("Enter book tittle :");
                            string tittle = Console.ReadLine();

                            bool availability =true;
                            for (int i = 0; i < 100; i++)
                            {
                                if (tittle == BookTittle[i])
                                {
                                    availability = false;
                                    BorrowerName[i] = Console.Clear();
                                    Console.WriteLine("The book boroow successfully.");
                                    break;

                                }
                            }
                            if (availability == true)
                            {
                                Console.WriteLine("Book is available.");
                            }


                        }

                        else if (choices == "b")
                        {
                            Console.WriteLine("Entetr book ISBN :");
                            string book_num = Console.ReadLine();

                            bool book_ISBNFound = false;
                            bool availability;
                            for (int i = 0; i < 100; i++)
                            {
                                if (book_num == BookTittle[i])
                                {
                                    book_ISBNFound = true;
                                    availability = BookAvailability[i];
                                    BorrowerName[i] = Console.ReadLine();
                                    Console.WriteLine("The book boroow successfully.");
                                    break;

                                }
                            }
                            if (book_ISBNFound == false)
                            {
                                Console.WriteLine("Book ISBN not found.");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Invalid choice.");
                        }



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

                Console.WriteLine("Press any key to continue....");
                Console.ReadKey();
                Console.Clear();


            }
            
           







        }
    }
}
