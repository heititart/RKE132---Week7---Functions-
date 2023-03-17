Console.WriteLine("Enter any word:");
string userInput = Console.ReadLine();
char firstLetter = userInput[0];


PrintAnyWord(userInput);// userInput - argument


static void PrintAnyWord(string anyString ) // anyString - parameter
{	
	anyString = anyString.Replace(anyString[0], char.ToUpper(anyString[0]));	

	for (int i = 0; i < 5; i++)
	{
		Console.WriteLine(anyString);
	}
}

