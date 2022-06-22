using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndroidTestAutomation
{
    public class AppAlertDialogs
    {
        private readonly AndroidDriver<AndroidElement> _driver;

        public AppAlertDialogs(AndroidDriver<AndroidElement> driver)
        {
            _driver = driver;
        }

        private AndroidElement openDialogButton => _driver.FindElementById("io.appium.android.apis:id/two_buttons");
        private AndroidElement alertElement => _driver.FindElementById("android:id/alertTitle");
        private AndroidElement button1 => _driver.FindElementById("android:id/button1");
        private AndroidElement button2 => _driver.FindElementById("android:id/button2");

        public void Goto()
        {
            _driver.StartActivity("io.appium.android.apis", ".app.AlertDialogSamples");
        }

        public void Tap_OkCancelDialogWithAMessage_Button()
        {
            openDialogButton?.Click();
        }

        public string AlertText()
        {
            return alertElement?.Text;
        }

        public void Click_Button1()
        {
            button1?.Click();
        }

        public void Click_Button2()
        {
            button2?.Click();
        }
    }
}
