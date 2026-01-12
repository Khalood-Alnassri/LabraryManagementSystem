internal class LabraryManagementSystem

{
    static void Main(string[] args)
    {
        

//system storge

string[] BookTittle = new string[100];
string[] BookISBN = new string[100];
string[] BookAuthor = new string[100];
string[] BorrowerName = new string[100];
bool[] BookAvailability = new bool[100];
int LastBookIndex = -1;

//seed data
BookTittle[0] = "Math";
BookISBN[0] = "1679";
BookAuthor[0] = "Ahmed";
BorrowerName[0] = "Salim ";
BookAvailability[0] = false;
LastBookIndex++;

BookTittle[1] = "Arbic";
BookISBN[1] = "4570";
BookAuthor[1] = "Ali";
BorrowerName[1] = "Sara";
BookAvailability[1] = false;
LastBookIndex++;

BookTittle[2] = "Math";
BookISBN[2] = "1679";
BookAuthor[2] = "Ahmed";
BorrowerName[2] = " ";
BookAvailability[2] = true;
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
            BookAuthor[LastBookIndex + 1] = Console.ReadLine();

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
                bool availability;
                for (int i = 0; i < 100; i++)
                {
                    if (tittle == BookTittle[i])
                    {
                        book_tittleFound = true;
                        availability = BookAvailability[i];
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

            Console.WriteLine("Enter book tittle or book ISBN. ");
            string book_detail = Console.ReadLine();

            bool bookFound = false;
            for (int i = 0; i < 100; i++)
            {
                if (book_detail == BookTittle[i] || book_detail == BookISBN[i])
                {
                    bookFound = true;
                    BookAvailability[i] = true;
                    BorrowerName[i] = " ";
                    Console.WriteLine("The is return.");
                    break;
                }
            }

            if (bookFound == false)
            {
                Console.WriteLine("Sorry book not found. ");
            }
            else
            {
                Console.WriteLine("Invalid book detail.");
            }



            break;

        case 4:
            //Search Book
            Console.WriteLine("Enter book tittle or book ISBN. ");
            string bookDetail = Console.ReadLine();

            bool book_Found = false;
            for (int i = 0; i < 100; i++)
            {
                if (bookDetail == BookTittle[i] || bookDetail == BookISBN[i])
                {
                    book_Found = true;
                    Console.WriteLine("Book tittle is : " + BookTittle[i]);
                    Console.WriteLine("Book ISBN is : " + BookISBN[i]);
                    Console.WriteLine("Book availability is : " + BookAvailability[i]);
                    Console.WriteLine("Book author is : " + BookAuthor[i]);

                    break;

                }
            }

                if (book_Found == false)
                {
                    Console.WriteLine("Book not found. ");
                }

                else
                {
                    Console.WriteLine("Invalid book detail. ");
                }


                break;

        case 5:
                  //List All Available Books

                Console.WriteLine("List available books. "); 

                bool available = false;
                for(int i = 0; i < 100; i++)
                {
                if (available = BookAvailability[i])
                {
                    available = true;
                    Console.WriteLine("Book tittle is : " + BookTittle[i]);
                    Console.WriteLine("Book ISBN is : " + BookISBN[i]);
                    Console.WriteLine("Book author is : " + BookAuthor[i]);

                }
                
                }

                if (available == false)
            {
                Console.WriteLine("No book is available.");
            }

            
        break;

        case 6:
                    //Transfer Book
                    Console.WriteLine("Enter book tittle or book ISBN : ");
                    string BookDetail = Console.ReadLine();

                    bool isBookFound = false;
                    for (int i = 0; i < 100; i++)
                    {
                        if (BookDetail == BookTittle[i] || BookDetail == BookISBN[i])
                        {
                            isBookFound = true;
                            if (BookAvailability[i] == true)
                            {
                                BookAvailability[i] = false;
                                Console.WriteLine("Book is transfer successfully.");
                                Console.WriteLine("The book unavailable now.");

                            }
                            else
                            {
                                Console.WriteLine("The book currently is unavailable.");
                            }

                        }
                    }
                    if (isBookFound == false)
                    {
                        Console.WriteLine("Invalid book detail.");
                    }





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
