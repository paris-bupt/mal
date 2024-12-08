// See https://aka.ms/new-console-template for more information

using step0;

while (true)
{
	string? line;
	try
	{
		Console.WriteLine("user> ");
		line = Console.ReadLine();
		if (line == null)
			break;
		if (line == "")
			continue;
	}
	catch (IOException e)
	{
		Console.WriteLine($"{nameof(IOException)}: {e}");
		break;
	}
	
	Console.WriteLine(LispInterpreter.Repl(line));
}
