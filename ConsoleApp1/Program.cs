Console.Write("Write the number from 1 to 100: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1 || number > 100)
{
    Console.WriteLine("Please enter a number between 1 and 100");
}
else if (number % 3 == 0 && number % 5 == 0)
{
    Console.WriteLine("FizzBuzz");
}
else if (number % 5 == 0)
{
    Console.WriteLine("Buzz");
}
else if (number % 3 == 0)
{
    Console.WriteLine("Fizz");
}