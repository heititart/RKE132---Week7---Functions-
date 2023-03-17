Console.WriteLine("Are you goming or leaving? in/out");

string userChoise = Console.ReadLine();

if (userChoise == "in")
{
    PrintHello();

}

else if(userChoise== "out")
{
    PrintGoodbye();

}

else
{

    Console.WriteLine("Invalid choice");
        
}

static void PrintHello() 
{
    Console.WriteLine("Hello!");
}

static void PrintGoodbye() 
{
    Console.WriteLine("See you later");
}