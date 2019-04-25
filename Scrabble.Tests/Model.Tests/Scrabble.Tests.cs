using System.Collections.Generic;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;

namespace Scrabble.TestTools
{
  [TestClass]
  public class ScrabbleTest// : IDisposible
  {
    // public void Dispose()
    // {
    //   Gram.ClearAll();
    // }

    [TestMethod]
    public void WordConstructor_CreateInstanceOfWord_Word()
    {
      Word newWord = new Word("hoser");
      Assert.AreEqual(typeof(Word), newWord.GetType());
    }

    [TestMethod]
    public void WordConstructor_ConvertInputWordToCharArray_CharArray()
    {
      string userInput = "ANT";
      char[] testCharArray = userInput.ToCharArray();
      Assert.AreEqual('N', testCharArray[1]);
    }


    [TestMethod]
    public void WordConstructor_ReturnsValueOfChar_True()
    {
      Word newWord = new Word("butts");
      Assert.AreEqual(1, newWord.AssignCharValue("A"));
    }

    [TestMethod]
    public void AssignCharValue_ReturnNonAlphaInput_False()
    {
      string userInput = "ANT";
      Word testWord = new Word(userInput);
      Assert.AreEqual(3, testWord.AssignCharValue(userInput));
    }

  }
}
