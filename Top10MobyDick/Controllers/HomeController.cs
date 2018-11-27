using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using Top10MobyDick.Classes;

namespace Top10MobyDick.Controllers
{
    public class HomeController : Controller
    {
        // Global decleration
        public static List<WordItem> WordList;

        public ActionResult Index()
        {
            GetXML();
            Top10MobyDick.FunctionClasses.GetTop getTop = new FunctionClasses.GetTop();
            return View(getTop.GetTop10(WordList));
        }

        public void GetXML()
        {
            string directory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\ege.xml";
            XDocument doc = XDocument.Load(directory);
            var authors = doc.Descendants("word");
            foreach (var author in authors)
            {
                WordList.Add(new WordItem
                {
                    counter = Convert.ToInt32(author.FirstAttribute.Value),
                    word = author.Attribute("text").Value
                });
            }
        }
    }
}