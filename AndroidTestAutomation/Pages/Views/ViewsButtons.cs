using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndroidTestAutomation
{
    public class ViewsButtons
    {
        private readonly AndroidDriver<AndroidElement> _driver;

        public ViewsButtons(AndroidDriver<AndroidElement> driver)
        {
            _driver = driver;
        }

        private AndroidElement NormalButton => _driver.FindElementById("io.appium.android.apis:id / button_normal");
        private AndroidElement SmallButton => _driver.FindElementById("io.appium.android.apis:id/button_small");
        private AndroidElement ToggleButton => _driver.FindElementById("io.appium.android.apis:id/button_toggle");

        public void Goto()
        {
            _driver.StartActivity("io.appium.android.apis", ".view.Buttons1");
        }

        public void ClickNormalButton()
        {
            NormalButton.Click();
        }

        public void ClickSmallButton()
        {
            SmallButton.Click();
        }
        public void ClickToggleButton()
        {
            ToggleButton.Click();
        }

        public string GetToggleButtonText()
        {
            return ToggleButton.Text;
        }
    }
}
