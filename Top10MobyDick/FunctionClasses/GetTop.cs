using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Top10MobyDick.Classes;

namespace Top10MobyDick.FunctionClasses
{
    public class GetTop
    {
        public List<WordItem> GetTop10(List<WordItem> list)
        {
            list.Sort((a, b) => a.counter.CompareTo(b.counter));
            list.Reverse();
            return list.Take(10).ToList();
        }
    }
}