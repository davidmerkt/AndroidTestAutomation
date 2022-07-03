using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndroidTestAutomation
{
    public class Views
    {
        private readonly AndroidDriver<AndroidElement> _driver;

        public Views(AndroidDriver<AndroidElement> driver)
        {
            _driver = driver;
        }

        public void Goto()
        {
            _driver.StartActivity("io.appium.android.apis", "ApiDemos");
            _driver.FindElementByAccessibilityId("Views").Click();
        }

        private AndroidElement ButtonsButton => _driver.FindElementByAccessibilityId("Buttons");
        private AndroidElement TextFieldsButton => _driver.FindElementByAccessibilityId("TextFields");

        public ViewsButtons ClickButtonsButton()
        {
            ButtonsButton.Click();
            return new ViewsButtons(_driver);
        }

        public ViewsTextFields ClickViewsTextFields()
        {
            TextFieldsButton.Click();
            return new ViewsTextFields(_driver);
        }

        public void ClickButtonByAccessibilityId(string accessibilityId) => 
            _driver.FindElementByAccessibilityId(accessibilityId).Click();
    }
}
