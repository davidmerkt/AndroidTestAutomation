using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndroidTestAutomation
{
    public abstract class Element
    {
        public abstract By By { get; }
        public abstract string Text { get; }
        public abstract void Click();
    }
}
