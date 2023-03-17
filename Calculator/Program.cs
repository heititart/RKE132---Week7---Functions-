

Console.WriteLine("Enter the opration (+/-)");
char userOperator = char.Parse(Console.ReadLine());

Console.WriteLine("Enter first value:");
int firstNum = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter second value");
int secondNum = Int32.Parse(Console.ReadLine());


switch (userOperator) 
{
    case '+':
        Addition(firstNum, secondNum);
        break;

        case '-':
        Subtraction(firstNum, secondNum);
        break;
        default: Console.WriteLine("invalid operator");
        break;

}

static void Addition(int a, int b) 
{
        Console.WriteLine($"{a} + {b} = {a + b}");

}

static void Subtraction(int a, int b) 
{
    Console.WriteLine($"{a} - {b} = {a - b}");
}