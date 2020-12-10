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
      Dictionary<string, int> letterValues = new Dictionary<string, int>()
      {
        {"aeiourstln", 1},
        {"dg", 2},
        {"bcmp", 3},
        {"fhvwy", 4},
        {"k", 5},
        {"jx", 8},
        {"qz", 10}
      };

      // For Each match to each Key in letterValues, add the corresponding value to pointTotal and return once finished 
      foreach(KeyValuePair<string, int> entry in letterValues)
      {
        foreach(Match match in Regex.Matches(inputWord, $@"(?i)[{entry.Key}]"))
        {
          pointTotal += entry.Value;
        }
      }
      return pointTotal;
    }
  }
}