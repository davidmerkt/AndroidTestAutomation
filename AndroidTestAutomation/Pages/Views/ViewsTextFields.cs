using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndroidTestAutomation
{
    public class ViewsTextFields
    {
        private readonly AndroidDriver<AndroidElement> _driver;

        public ViewsTextFields(AndroidDriver<AndroidElement> driver)
        {
            _driver = driver;
        }

        private AndroidElement Row1TextBox => _driver.FindElementById("io.appium.android.apis:id/edit");
        private AndroidElement Row2TextBox => _driver.FindElementById("io.appium.android.apis:id/edit1");
        private AndroidElement Row3TextBox => _driver.FindElementById("io.appium.android.apis:id/edit2");
        private AndroidElement Row2Label => _driver.FindElementById("io.appium.android.apis:id/edit1Text");

        public void Goto()
        {
            _driver.StartActivity("io.appium.android.apis", ".view.TextFields");
        }

        public void FillTextRow1(string text)
        {
            Row1TextBox.SendKeys(text);
        }

        public void FillTextRow2(string text)
        {
            Row2TextBox.SendKeys(text);
        }
        public void FillTextRow3(string text)
        {
            Row3TextBox.SendKeys(text);
        }

        public string GetRow2LabelText()
        {
            return Row2Label.Text;
        }
    }
}
