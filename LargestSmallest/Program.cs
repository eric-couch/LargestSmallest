//Write a program that receives a series of integers until the user indicates they want to quit by typing 'Q'.  
//The program loop should keep track of the largest and smallest integers that were entered and display them 
//after the user types 'Q' and the program loop exits.
int largest = int.MinValue;
int smallest = int.MaxValue;
string input = string.Empty;

do
{
    Console.Write("Enter a number (Q to quit): ");
    input = Console.ReadLine()!;

    if (int.TryParse(input, out int _number))
    {
        if (_number > largest)
        {
            largest = _number;
        }
        if (_number < smallest)
        {
            smallest = _number;
        }
    }
    else
    {
        //if (input.ToLower() != "q")
        if (input != "q" && input != "Q")
        {
            Console.WriteLine("Invalid input.");
        }
    }
} while (input.ToLower() != "q");
// while (input != "q" || input != "Q");

// int? largest;  
// largest ?? "not entered";
Console.WriteLine($"Largest number is: {(largest == int.MinValue ? "not entered" : largest)}");
Console.WriteLine($"Smallest number is: {(smallest == int.MaxValue ? "not entered" : smallest)}");





//try
//{
//    int _number = int.Parse(input);

//    if (_number > largest)
//    {
//        largest = _number;
//    }
//    if (_number < smallest)
//    {
//        smallest = _number;
//    }

//}
//catch (FormatException ex)
//{
//    if (input.ToLower() != "q")
//    {
//        Console.WriteLine("Please enter a number instead.");
//    }
//} catch (OverflowException ex)
//{
//    if (input.ToLower() != "q")
//    {
//        Console.WriteLine($"min = {int.MinValue}, max = {int.MaxValue}");
//    }
//} finally
//{

//}