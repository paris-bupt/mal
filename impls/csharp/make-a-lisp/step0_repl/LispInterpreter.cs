namespace step0_repl;

public class LispInterpreter
{
	public static string Read(string str)
	{
		return str;
	}
	
	public static string Eval(string str)
	{
		return str;
	}

	public static string Print(string str)
	{
		return str;
	}

	public static string Repl(string str)
	{
		return Print(Eval(Read(str)));
	}
}