int number;
int result;


Console.WriteLine("Please enter a number: ");
var enteredNumber = Console.ReadLine();

Int32.TryParse(enteredNumber, out number);

result = number % 2;

if(result != 0)
{
    Console.WriteLine("The number is not even");
}
else
{
    Console.WriteLine("The number is even");
}
