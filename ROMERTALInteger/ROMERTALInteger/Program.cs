using System;

public class Program
{
	public static void Main()
	{
        Console.WriteLine("Skriv et romertal");
		string [] romanNumbers = new[] {Console.ReadLine()};

		// Hvis man ikke vil bruge Console.Readline - Romertal skrives herunder i stedet:
		//string[] romanNumbers = new[] { "mmxx", "mlcxx" };
		foreach (string number in romanNumbers)
		{
			int decimalNumber = FromRoman(number);
			Console.WriteLine("{0}: {1}", number, decimalNumber);
		}
	}

	// returnerer talværdien af et romertalbogstav
	private static int romanValue(int index)
	{
		int basefactor = ((index % 2) * 4 + 1); // enten 1 eller 5...
												// ...ganget med en exponent af 10, hvis den er x eller højere
		return index > 1 ? (int)(basefactor * System.Math.Pow(10.0, index / 2)) : basefactor;
	}

	public static int FromRoman(string roman)
	{     
		roman = roman.ToLower();
		string literals = "mdclxvi";
		int value = 0, index = 0;
		foreach (char literal in literals)
		{
			value = romanValue(literals.Length - literals.IndexOf(literal) - 1);
			index = roman.IndexOf(literal);
			if (index > -1)
				return FromRoman(roman.Substring(index + 1)) + (index > 0 ? value - FromRoman(roman.Substring(0, index)) : value);
		}

		return 0;
	}
}
