using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndroidTestAutomation
{
    public class ApiDemos
    {
        private readonly AndroidDriver<AndroidElement> _driver;

        public ApiDemos(AndroidDriver<AndroidElement> driver)
        {
            _driver = driver;
        }

        public void Goto()
        {
            _driver.StartActivity("io.appium.android.apis", "ApiDemos");
        }

        private AndroidElement Access_ibilityButton => _driver.FindElementByAccessibilityId("Access'ibility");
        private AndroidElement AccessibilityButton => _driver.FindElementByAccessibilityId("Accessibility");
        private AndroidElement AnimationButton => _driver.FindElementByAccessibilityId("Animation");
        private AndroidElement AppButton => _driver.FindElementByAccessibilityId("App");

        public void ClickAccess_ibilityButton()
        {
            Access_ibilityButton.Click();
        }

        public void ClickAccessibilityButton()
        {
            AccessibilityButton.Click();
        }

        public void ClickAnimationButton()
        {
            AnimationButton.Click();
        }

        public App ClickAppButton()
        {
            AppButton.Click();
            return new App(_driver);
        }

        public void ClickButtonByAccessibilityId(string accessibilityId) => 
            _driver.FindElementByAccessibilityId(accessibilityId).Click();
    }
}
