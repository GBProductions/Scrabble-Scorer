using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Scrabble.Models
{
  public class ScrabbleScore
  {
    public int GetScrabbleScore(string inputWord)
    {
      int pointTotal = 0;
      Regex getNonLetters = new Regex("^a-z");
      //Regex onePointRegex = new Regex("aeioulnrst");
      inputWord.ToLower();
      getNonLetters.Replace(inputWord, string.Empty);

      //string[] inputWordArray = inputWord.Split(' ');
      foreach(Match match in Regex.Matches(inputWord, @"[aeiourstln]"))
      {
        pointTotal++;
      }

      return pointTotal;
    }
  }
}

// Input word from console

// use regex to be case insensitive and reject nonletters

// split word into array

// Match or a loop through array looking for letters, and matching them with their respective value

// each match or loop, add values together

// return total score in console