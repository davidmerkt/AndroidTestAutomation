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
        private AndroidElement OkButton => _driver.FindElementById("android:id/button1");
        private AndroidElement CancelButton => _driver.FindElementById("android:id/button2");
        private AndroidElement SomethingButton => _driver.FindElementById("android:id/button3");

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

        public void Click_Ok_Button()
        {
            OkButton?.Click();
        }

        public void Click_Cancel_Button()
        {
            CancelButton?.Click();
        }
    }
}
