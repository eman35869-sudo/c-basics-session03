using System.Text;

namespace C__Basics_Session03
{
    internal class Program
    {
        static void Main(string[] args)
        {///C# Assignment 3

            /*Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print
             both title and upperTitle to show that title did not change*/
            //Q1
            Console.WriteLine("Q1");
            string title = "clean code";
           string upperTitle = title.ToUpper();
            Console.WriteLine(title);
            Console.WriteLine(upperTitle);
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            //Q2
            /*
             Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals()
             to check if they point to the same object in memory
             */
            Console.WriteLine("Q2");
            string val1 = "Clean Code";
            string val2 = "Clean Code";
            Console.WriteLine(ReferenceEquals(val1, val2));
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            //Q3
            /*
             Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same
             object. Print the final result.

             */

            Console.WriteLine("Q3");
            StringBuilder sb = new StringBuilder("Book List");
            sb.Append(" - Updated");
            Console.WriteLine(sb.ToString());

            StringBuilder sb1 = new StringBuilder();
            sb1.Append("Book List");
            sb1.Append(" - Updated");
            Console.WriteLine(sb1.ToString());

            Console.WriteLine("\n");
            Console.WriteLine("\n");

            //Q4
            /*
             Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library".
              Print the result.

             */
            Console.WriteLine("Q4");
            sb.Replace("Book List", "Library");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("\n");
            Console.WriteLine("\n");



            //Q5
            /*
             * Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code,
                Pages: 464" using the + operator.
             */
            Console.WriteLine("Q5");
            title = "Clean Code";
            int pages = 464;
            Console.WriteLine("Book: " + title+","+ "Pages:"+ pages);
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            //Q6
            /*
             *Build the same sentence as above, but using string interpolation ($"...").
 
             */
           
            Console.WriteLine("Q6");
            Console.WriteLine($"Book: {title},Pages:{pages}");
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            //Q7
            /*
             Build the same sentence again, but using string.Format().
            */

            Console.WriteLine("Q7");
            Console.WriteLine(string.Format("Book: {0},Pages:{1}", title, pages));
            Console.WriteLine("\n");
            Console.WriteLine("\n");


            //Q8
            /*
             Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than
            300, otherwise prints "Short Book".

             */
            Console.WriteLine("Q8");
            int pages1 = 464;
            if(pages1>300)
            {
                Console.WriteLine("Long Book");
            }
            else
            {
                Console.WriteLine("Short Book");
            }
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            //Q9
            /*Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is
             greater than 300 and isAvailable is true. Use the && operator.

             * */
            Console.WriteLine("Q9");
            int pages2 = 464; 
            bool isAvailable = true;
            if (pages2>300&& isAvailable == true)
            {
                Console.WriteLine("You can borrow this book");
            }
            else
            {
                Console.WriteLine("error message");
            }
            Console.WriteLine("\n");
            Console.WriteLine("\n");


            //Q10
            /*
             * Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is
             "Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else
             * */

            Console.WriteLine("Q10");
            string title1 = "Refactoring";
            switch(title1)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;

                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;
                default:
                    Console.WriteLine("Never heard of it");
                    break;


            }
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            //Q11
            /*
             Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into a
            variable sizeLabel (same rule as question 8: long if pages > 300).
             */
            Console.WriteLine("Q11");
            int pages12 = 464;
            string sizeLabel = (pages12 > 300 ? "Long Book" : "Short Book");
            Console.WriteLine(sizeLabel);
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            //Q12
            /*
             * Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };, use a for loop
             to print each book with its position number, like 1. Clean Code.

             * */
            Console.WriteLine("Q12");
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for(int i=0;i < books.Length; i++)
            {
                Console.WriteLine((i+1)+"." + books[i]);
                

            }
            
           /* for (int i = 0; i < books.Length; i++)
            {
               
              Console.WriteLine($"{i + 1}.{books[i]}");

            }*/
            Console.WriteLine("\n");
            Console.WriteLine("\n");



            //Q13
            /*
             Using the same books array, use a while loop to print every book title
             */
            Console.WriteLine("Q13");
            int j= 0;
            while (j< books.Length)
            {
                Console.WriteLine((j + 1) + "." + books[j]);
               j++; 
            }
            Console.WriteLine("\n");
            Console.WriteLine("\n");


            //Q14
            /*
             * Write a do-while loop that prints "Checking book..." exactly 3 times.
             * */
            Console.WriteLine("Q14");
            int z = 1;
            do
            {
                Console.WriteLine("Checking book...");
                z++;
            }
            while (z < 4);
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            //Q15
            /*
             * Using the same books array, use a foreach loop to print every book title
             * */
            Console.WriteLine("Q15");
            foreach (string everybook in books)
            {
                Console.WriteLine(everybook);
            }
            Console.WriteLine("\n");
            Console.WriteLine("\n");



            //Q16
            /* 
             Using the same books array, loop through it and print each title, but stop completely (break) once
             you reach "Refactoring"

             */
            Console.WriteLine("Q16");
            string[] books1 = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for (int i = 0; i < books.Length; i++)
            {                 
                if (books1[i] == "Refactoring")
                    break;
                Console.WriteLine((i + 1) + "." + books[i]);

            }
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            //Q17
            /*
             * Using the same books array, print every title except "The Pragmatic Programmer" (skip it with
              continue, don't stop the loop)
            */
            Console.WriteLine("Q17");
            string[] books2 = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for (int i = 0; i < books.Length; i++)
            {
                

                if (books1[i] == "The Pragmatic Programmer")
                    continue;
               Console.WriteLine((i + 1) + "." + books[i]);

            }
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("Q17");
            PrintFirstBook(books2);


        }

        //Q18
        /*Write a method PrintFirstBook() that prints the first book in the books array. If the array is empty,
          use return to exit the method early instead of printing anything.
         * */
        static void PrintFirstBook(string[] books2)
        {
            if(books2.Length==0)
            {
                return;
            }
            Console.WriteLine(books2[0]);
        }
    }
}
