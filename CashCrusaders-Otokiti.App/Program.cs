// See https://aka.ms/new-console-template for more information
using CashCrusaders_Otokiti.App;
using CashCrusaders_Otokiti.DataAccess.Data;

Console.WriteLine("Hello, Cash Crusaders!");

var items = new DataProvider();

while (true)
{
    Console.WriteLine("Please enter one or more words to search for an item, 'help' to list all items or 'quit' to exit the application. ");
    Console.WriteLine();
    var line = Console.ReadLine();
	if (string.Equals("quit", line, StringComparison.OrdinalIgnoreCase))
	{
		break;
	}

	var allItems = items.LoadItems();

	ICommandHandler commandHandler = string.Equals("help", line, StringComparison.OrdinalIgnoreCase) 
		? new HelpCommandHandler(allItems) 
		: new CommandHandler(allItems, line);

	commandHandler.HandleCommand();
}
