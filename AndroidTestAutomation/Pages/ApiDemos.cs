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

        public void ClickAppButton()
        {
            AppButton.Click();
        }

        public void ClickButtonByAccessibilityId(string accessibilityId) => 
            _driver.FindElementByAccessibilityId(accessibilityId).Click();
    }
}
