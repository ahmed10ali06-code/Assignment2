using System.Drawing;
using System.Text;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle.Print both title and upperTitle to show that title did not change.
            //string title = "clean code";
            //string upperTitle = title.ToUpper();
            //Console.WriteLine(title);
            //Console.WriteLine(upperTitle);
            #endregion

            #region Q2 
            //Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals()  to check if they point to the same object in memory.
            //string Code1 = "Clean Code";
            //string Code2 = "Clean Code";
            //Console.WriteLine(ReferenceEquals(Code1, Code2));
            #endregion

            #region Q3
            //Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same object.Print the final result.
            var Book = new StringBuilder();
            Book.Append("Book List");
            Book.Append(" - Updated");
            Console.WriteLine(Book);
            #endregion


        }
    }
}
