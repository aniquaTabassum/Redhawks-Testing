using System;

/**
 * Implements test cases to fulfill the self-assessment test in "The Art of Software Testing, Second
 * Edition" by Glenford Myers.
 * 
 * <i>The program reads three integer values from an input dialog. The three values represent the
 * lengths of the sides of a triangle. The program displays a message that states whether the
 * triangle is scalene, isosceles, or equilateral. </i>
 * 
 * @author Brian Daugherty
 * 
 */
namespace Cs_TriangleType_Code
{
    class Program
    {
        public static void Main(string[] args) 
        {
            //final Scanner userInput = new Scanner(System.in);

            Console.WriteLine("Triangle Classifier");
            Console.WriteLine("Enter the length of the three sides of the triangle");

            Console.WriteLine("\t{0}", "Side a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\t{0}", "Side b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\t{0}", "Side c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The triangle is {0}", TriangleTypeClassifier.classify(a, b, c).ToString());
        } // main
    } // class
} // namespace
