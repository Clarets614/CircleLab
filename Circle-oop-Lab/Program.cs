//main program

using Circle_oop_Lab;

Console.WriteLine("Hello Welcome to the Circle of Methods");
Console.WriteLine("Enter Radius:");

//Validation loop
double value = 0;
while (true)
{
    try
    {
        value = double.Parse(Console.ReadLine());

        //if successful
        break;
    }
    catch (Exception e)
    {
        Console.WriteLine("Please enter a valid number");
    }
}
//new circle object
Circle userCircle = new Circle(value);
Console.WriteLine($"Diameter:{userCircle.CalculateDiameter()}");
Console.WriteLine($"Circumference : {userCircle.CalculateCircumference()}");
Console.WriteLine($"Area: {userCircle.CalculateArea()}");

bool growCircle = true;
//asking user if circle should grow
while (true)
{
    Console.WriteLine("\nWould you like the circle to grow?");
    string choice = Console.ReadLine().ToLower().Trim();
    if (choice == "y")
    {
        Console.WriteLine("The Circle grows larger.");
        userCircle.Grow();
        Console.WriteLine($"Diameter:{userCircle.CalculateDiameter()}");
        Console.WriteLine($"Circumference : {userCircle.CalculateCircumference()}");
        Console.WriteLine($"Area: {userCircle.CalculateArea()}");

    }
    else if (choice == "n")
    {
        growCircle = false;
        break;
    }
    else
    {
        Console.WriteLine("that answer is invalid, please type y to continue or n to quit");
    }


}

Console.WriteLine($"The final radius of this circle is {userCircle.GetRadius()}.");
Console.WriteLine("Thank you and have a nice day!");
