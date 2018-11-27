using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestTop10
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetTop10()
        { 
            List<Top10MobyDick.Classes.WordItem> wordWordItemsResult = new List<Top10MobyDick.Classes.WordItem>();
            wordWordItemsResult.Add(new Top10MobyDick.Classes.WordItem
            {
                counter = 4,
                word = "ibiza"
            });
            wordWordItemsResult.Add(new Top10MobyDick.Classes.WordItem
            {
                counter = 1,
                word = "ege"
            });
            List<Top10MobyDick.Classes.WordItem> wordWordItems = new List<Top10MobyDick.Classes.WordItem>();
            wordWordItems.Add(new Top10MobyDick.Classes.WordItem
            {
                counter = 1,
                word = "ege"
            });
            wordWordItems.Add(new Top10MobyDick.Classes.WordItem
            {
                counter = 4,
                word = "ibiza"
            });

            Top10MobyDick.FunctionClasses.GetTop getTop = new Top10MobyDick.FunctionClasses.GetTop();
            List<Top10MobyDick.Classes.WordItem> FromFunction = getTop.GetTop10(wordWordItems);

            Assert.AreEqual(wordWordItemsResult[0].word, FromFunction[0].word);
        }
    }
}
