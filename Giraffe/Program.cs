using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// The namespace keyword is used to declare a scope that contains a set of related objects. You can use a namespace to organize code elements and to create globally unique types
namespace Giraffe
{
    // class
    class Program
    {
        // method
        static void Main(string[] args)
        {
            //Variables:

            //string characterName = "George";
            //int characterAge;
            //characterAge = 70;

            //Console.WriteLine("Hello Ashwin");
            //Console.WriteLine("There once was a man named " + characterName);
            //Console.WriteLine("He was " + characterAge + " years old");
            //characterName = "Tom";
            //Console.WriteLine("He really liked the name " + characterName);
            //Console.WriteLine("But didn't like being " + characterAge);

            //Data Types:

            //string phrase = "Ashwin is a FullStack Developer";
            //char grade = 'A';
            //int age = 28;
            //float exactAge = 28.5f;
            //double exactAge2 = 28.50;
            //double exactAge2a = 28.50d;
            //decimal exactAge3 = 28.5m;
            //bool married = false;

            //Working with Strings

            //string phrase = "Ashwin " + "is cool";
            //string phrase2 = " always";
            ////Console.WriteLine(phrase.Length);
            //Console.WriteLine(phrase.ToLower());
            //Console.WriteLine(phrase.Contains("is"));
            //Console.WriteLine(phrase.IndexOf("is"));
            //Console.WriteLine(phrase.Substring(7, 2));
            //Console.WriteLine(phrase[4]);

            //Working with Numbers

            //int num = 5;
            //Console.WriteLine(num);
            //Console.WriteLine(num % 2);
            //Console.WriteLine(num + 2 * 3);
            //num++;
            //Console.WriteLine((num + 2) * 3);
            //Console.WriteLine(num.ToString());
            //Console.WriteLine(Math.Abs(-40));
            //Console.WriteLine(Math.Pow(3, 2));
            //Console.WriteLine(Math.Sqrt(25));

            //Getting User Input

            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();
            //Console.Write("Enter your age: ");
            //string age = Console.ReadLine();
            //Console.WriteLine("Hello " + name + ", you are " + age);

            //Building a Calculator

            //Console.Write("Enter a number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter another number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(num1 + num2);

            //Building a Mad Libs Game

            //string color, pluralNoun, celebrity;
            //Console.Write("Enter a color: ");
            //color = Console.ReadLine();
            //Console.Write("Enter a Plural Noun: ");
            //pluralNoun = Console.ReadLine();
            //Console.Write("Enter a Celebrity: ");
            //celebrity = Console.ReadLine();
            //Console.WriteLine("Roses are " + color);
            //Console.WriteLine(pluralNoun + " are blue");
            //Console.WriteLine("I Love " + celebrity);

            //Arrays

            //int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            //string[] friends = new string[3];
            //friends[0] = "Akshay";
            //friends[1] = "Amruth";
            //friends[2] = "Nitin";
            //luckyNumbers[1] = 900;
            //Console.WriteLine(luckyNumbers[3]);
            //Console.WriteLine(luckyNumbers[1]);
            //Console.WriteLine(friends[1]);

            //Methods Calling

            //SayHi("Ashwin", 28);
            //SayHi("Akshay", 25);
            //SayHi("Udaya Ravi", 32);

            //Return statement

            //Console.WriteLine(Cube(3));
            //Console.WriteLine(Cube(4));
            //Console.WriteLine(Cube(5));

            //If Statements

            //bool isMale = true;
            //bool isTall = false;

            //if (isMale && isTall)
            //{
            //    Console.WriteLine("You are a tall male");
            //}
            //else if (isMale && !isTall) {
            //    Console.WriteLine("You are a short male");
            //}
            //else
            //{
            //    Console.WriteLine("You are either not male or not tall or both");
            //}

            //Console.WriteLine(GetMax(3, 5));
            //Console.WriteLine(GetMax(8, 4));
            //Console.WriteLine(GetMax(7, 7));

            //Switch Statements

            //Console.WriteLine(GetDay(5));
            //Console.WriteLine(GetDay(1));
            //Console.WriteLine(GetDay(3));
            //Console.WriteLine(GetDay(10));

            //While Loops

            //int index = 1;
            //while (index <= 5)
            //{
            //    Console.WriteLine(index);
            //    index++;
            //}
            //Console.WriteLine("");
            //do
            //{
            //    Console.WriteLine(index);
            //    index++;
            //} while(index <= 5);

            //string secretWord = "giraffe";
            //string guess = "";
            //int guessCount = 0;
            //bool outOfGuess = false;

            //while (guess != secretWord && !outOfGuess)
            //{
            //    if (guessCount < 3) {
            //        Console.Write("Enter your Guess: ");
            //        guess = Console.ReadLine();
            //        guessCount++;
            //    } else
            //    {
            //        outOfGuess = true;
            //    }
            //}
            //if (outOfGuess) Console.WriteLine("You lose!");
            //else Console.WriteLine("You win!");

            //For Loops

            //for(int i = 1; i <= 5 ; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            //for(int i = 0; i < luckyNumbers.Length; i++)
            //{
            //    Console.WriteLine(luckyNumbers[i]);
            //}

            //Building an Exponent exponent

            //Console.WriteLine(GetPow(5, 3));
            //Console.WriteLine(GetPow(8, 1));
            //Console.WriteLine(GetPow(12, 2));

            //2D arrays

            //int[,] numberGrid = {
            //    { 1, 2 },
            //    { 3, 4 },
            //    { 5, 6 },
            //};
            //Console.WriteLine(numberGrid[2,0]);

            //Exception Handling

            //try
            //{
            //    Console.Write("Enter a number: ");
            //    double num1 = Convert.ToDouble(Console.ReadLine());
            //    Console.Write("Enter another number: ");
            //    double num2 = Convert.ToDouble(Console.ReadLine());
            //    Console.WriteLine(num1 / num2);
            //} catch(DivideByZeroException e) { 
            //    Console.WriteLine("Error: " + e.Message);
            //} catch(FormatException e) { 
            //    Console.WriteLine("Error: " + e.Message);
            //} finally
            //{
            //    Console.WriteLine("Calculator job is done");
            //}

            //Classes & Objects

            //Book book1 = new Book();
            //book1.title = "Harry Potter";
            //book1.author = "J. K. Rowling";
            //book1.pages = 400;

            //Book book2 = new Book();
            //book2.title = "Lord of the Rings";
            //book2.author = "Tolkein";
            //book2.pages = 700;

            //Console.WriteLine(book1.title);
            //Console.WriteLine(book1.author);
            //Console.WriteLine(book1.pages);
            //Console.WriteLine(book2.title);
            //Console.WriteLine(book2.author);
            //Console.WriteLine(book2.pages);

            //Constructors

            //Book book3 = new Book("Harry Potter", "J. K. Rowling", 400);
            //Book book4 = new Book("Lord of the Rings", "Tolkein", 700);

            //Console.WriteLine(book3.title);
            //Console.WriteLine(book3.author);
            //Console.WriteLine(book3.pages);
            //Console.WriteLine(book4.title);
            //Console.WriteLine(book4.author);
            //Console.WriteLine(book4.pages);

            //Object Methods

            //Student student1 = new Student("Jim", "Business", 2.8);
            //Student student2 = new Student("Pam", "Art", 3.6);

            //Console.WriteLine(student1.HasHonors());
            //Console.WriteLine(student2.HasHonors());

            //Getters and Setters

            //Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            //Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");

            //avengers.Rating = "XYZ";
            //avengers.Rating = "R";
            //Console.WriteLine(avengers.Rating);

            //Static Class Attributes

            //Song holiday = new Song("Holiday", "Green Day", 200);
            //Console.WriteLine(Song.songCount);
            //Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            //Console.WriteLine(Song.songCount);

            //Console.WriteLine(kashmir.artist);
            //Console.WriteLine(holiday.title);
            //Console.WriteLine(holiday.getSongCount());

            //Static Methods and Classes

            //Console.WriteLine(Math.Sqrt(144));
            //UsefulTools.SayHi("Ashwin");

            //Inheritance

            //Chef chef = new Chef();
            //chef.MakeChicken();
            //ItalianChef italianChef = new ItalianChef();
            //italianChef.MakeSalad();
            //italianChef.MakePasta();
            //chef.MakeSpecialDish();
            //italianChef.MakeSpecialDish();

            Console.ReadLine();
        }

        //Methods

        //static void SayHi(string name, int age)
        //{
        //    Console.WriteLine("Hello " + name + ", you are " + age + " years old.");
        //}

        //Return statement

        //static int Cube(int num)
        //{
        //    int result = num * num * num;
        //    return result;
        //}

        //If Statements

        //static int GetMax(int num1, int num2)
        //{
        //    if(num1 >= num2) return num1;
        //    else return num2;
        //}

        //Switch Statements

        //static string GetDay(int dayNum)
        //{
        //    string dayName;

        //    switch (dayNum)
        //    {
        //        case 0:
        //            dayName = "Sunday";
        //            break;
        //        case 1:
        //            dayName = "Monday";
        //            break;
        //        case 2:
        //            dayName = "Tuesday";
        //            break;
        //        case 3:
        //            dayName = "Wednesday";
        //            break;
        //        case 4:
        //            dayName = "Thursday";
        //            break;
        //        case 5:
        //            dayName = "Friday";
        //            break;
        //        case 6:
        //            dayName = "Saturday";
        //            break;
        //        default:
        //            dayName = "Invalid day number passed";
        //            break;
        //    }

        //    return dayName;
        //}

        //Building an Exponent exponent

        //static int GetPow(int baseNum, int powNum) {
        //    int result = 1;
        //    for (int i = 0; i < powNum; i++) { 
        //        result *= baseNum;
        //    }
        //    return result;
        //}

    }
}