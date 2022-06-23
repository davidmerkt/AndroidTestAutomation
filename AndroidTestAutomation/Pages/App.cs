using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndroidTestAutomation
{
    public class App
    {
        private readonly AndroidDriver<AndroidElement> _driver;

        public App(AndroidDriver<AndroidElement> driver)
        {
            _driver = driver;
        }

        public void Goto()
        {
            _driver.StartActivity("io.appium.android.apis", "ApiDemos");
            _driver.FindElementByAccessibilityId("App").Click();
        }

        private AndroidElement AlertDialogsButton => _driver.FindElementByAccessibilityId("Alert Dialogs");

        public AppAlertDialogs ClickAlertDialogsButton()
        {
            AlertDialogsButton.Click();
            return new AppAlertDialogs(_driver);
        }

        public void ClickButtonByAccessibilityId(string accessibilityId) => 
            _driver.FindElementByAccessibilityId(accessibilityId).Click();
    }
}
