using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Scrabble.Models;
using System;

namespace Scrabble.TestTool
{
  [TestClass]
  public class ScrabbleTests
  {
    [TestMethod]
    public void ScrabbleScore_GetLetterScore()
    {
      ScrabbleScore testScrabbleScore = new ScrabbleScore();
      Assert.AreEqual(1, testScrabbleScore.GetScrabbleScore("a"));
    }
  }
}