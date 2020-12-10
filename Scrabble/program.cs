using System;
using Scrabble.Models;

public class Program
{
	public static void Main()
	{
    Console.WriteLine("Enter a word and I'll return how much it will score in Scrabble! Note that I will only check the first word");
    Console.WriteLine("Also, I will not check for word length, and I won't apply any bonuses like using all 7 tiles");
    
    ScrabbleScore scrabbleScore = new ScrabbleScore();
    string userInputString = Console.ReadLine();
    (@"^a-z").Replace(userInputString, string.Empty);
    userInputString = userInputString.Split()[0];
    int finalScore = scrabbleScore.GetScrabbleScore(userInputString);

    Console.WriteLine($"{userInputString} is worth {finalScore} points!");
	}
}