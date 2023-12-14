//1.In C# Complete the given BorrowerValidator code to validate the given
//borrower. Borrowers are considered valid if: -their name is not null or empty,
//-their Dti is below 25, -their owned properties are less than 3
string name = "";
double Dti = 0;
int ownedProperties = 0;

bool isValid = BorrowerValidator("tom", 0, 3);
static bool BorrowerValidator(string name, double Dti, int properties)
{
if (  name != null && name !="" && Dti <25 && properties <3)
    {
        return true;
    }

else
    {
        return false;

    }
}





//2.In C# create 2 methods: "Ping" and "Pong". Model out these methods as
//described below:
//In C# create 2 methods: "Ping" and "Pong". Model out these methods as described
//below: Ping requirements: -accepts a single integer argument that is named i, -
//ping will add 1 to the value i, and then call pong passing the new value as an
//argument.Pong Requirements: -accepts a single integer argument that is named
//i, - pong will add 10 to the value of i, and then write out the new value to the
//console. - Pong will then call ping passing the new value as an argument.This
//will continue until the integer value is greater than 500, at which point Ping
//Pong will stop. No number is greater than 500 is written to the console. Output
//your results by calling Ping(0) within the Main method (this step is completed
//for you).

Ping(0);
static void Ping(int i)
{
    if (i <= 500)
    {
        i++;
        Pong(i);

    }
}
static void Pong(int i)
{
    if (i <= 490)
    {
        i += 10;
        Console.WriteLine(i);
        Ping(i);

    }
}


//3.You are given: -1 integer full of values, -1 integer array full of targets to
//be found. Implement a method called CountTargets. This method will count the
//number of times any of the targets occur within the values array. An empty list
//should produce a value of "0". Be sure to write out the total number of matches
//to the console.


//int [] value = { 33, 12, 10, 11 };
//int[] targets = { 1, 10, 33, 2, 34, 33, 5, 6, 6 };
//int totalMatches = CountTargets(value, targets);
//static int CountTargets(int[] v, int[] t)
//{
//        int x = 0;
//    foreach (int value in t)
//    {
//        x ++; 
//    }
//    Console.WriteLine(x);
//    return totalMatches;
//}

//4. In C# create a function 'CalculateGradeLetter': -It should accept 1 parameter
//of the type decimal, - it should return a string- if the input is 90 or above
//return 'A' - if the input is 80 or above but less than 90 return 'B' - if the
//input is 70 or above but less than 80 return 'C', - any other test score return
//'F'



//5.Fix an existing function to handle exceptions gracefully. The DivideNumber
//function accepts 2 strings: a numerator and denominator. - if either values
//passed in for the numerator or denominator are not numbers, then the function
//should return "bad data", - if the operation produces a divide by zero
//exception, then the function should return the string "infinity", - if the
//function produces a number, it should be returned as a string. here is the
//function:
//
static string DivideNumber(string numerator, string denominator)
{
    try
    {
        // Attempt to parse numerator and denominator
        decimal n = decimal.Parse(numerator);
        decimal d = decimal.Parse(denominator);

        // Check if the denominator is zero
        if (d == 0)
        {
            return "infinity";
        }

        // Perform the division and return the result as a string
        decimal result = n / d;
        return result.ToString();
    }
    catch (FormatException)
    {
        // Handle the case where either numerator or denominator is not a number
        return "bad data";
    }
    catch (DivideByZeroException)
    {
        // Handle the case where the denominator is zero
        return "infinity";
    }
    catch (Exception)
    {
        // Handle other unexpected exceptions
        return "an error occurred";
    }
}



////method takes in a string and returns if it is a palendrome

string theWord = "racecar";
Console.WriteLine(IsPalendrome(theWord));
static bool IsPalendrome(string palendrome)
{
    for (int i = 0; i < palendrome.Length / 2; i++)
    {
        if (palendrome[palendrome.Length - 1 - i] != palendrome[i])
        {
            return false;
        }
    }
    return true;
}

public class Animal
{
    public string Name { get; set; }
    // Virtual method that can be overridden by child classes
    public virtual void Speak()
    {
        Console.WriteLine("Wich-what-who");
    }
}
public class Dog : Animal
{
    public bool HasFur { get; set; }
    // Override the Speak method from the parent class
    public override void Speak()
    { Console.WriteLine("Ruff!"); }
}
public class Bird : Animal
{
    public bool CanFly { get; set; }
    public override void Speak()
    {
        {
            Console.WriteLine("Tweet");
        }
    }
}
partial class Program
{
    static void Main()
    {
        // Create instances of both the Animal and Dog
        Animal genericAnimal = new Animal();
        Dog myCat = new Dog();
        Bird newBird = new Bird();

        Console.WriteLine("Generic animal says:");
        genericAnimal.Speak();

        Console.WriteLine("My cat says:");
        myCat.Speak();
    }


}