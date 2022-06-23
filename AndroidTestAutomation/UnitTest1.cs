using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Remote;
using System;

namespace AndroidTestAutomation
{

    [TestClass]
    public class UnitTest1
    {
        private static AndroidDriver<AndroidElement> driver;

        [ClassInitialize]
        public static void StartUp(TestContext testContext)
        {
            Console.WriteLine("Start driver");

            // Create DriverOptions object, which will contain information on the APK to load for testing
            DriverOptions capabilities = new AppiumOptions();
            capabilities.AddAdditionalCapability(MobileCapabilityType.AutomationName, "UiAutomator2");
            capabilities.AddAdditionalCapability(MobileCapabilityType.App, $"{System.AppDomain.CurrentDomain.BaseDirectory.ToString()}/assets/ApiDemos-debug.apk"); 

            // Create new driver object. It will use the Appium Desktop server that we're currently running.
            driver = new AndroidDriver<AndroidElement>(new Uri("http://localhost:4723/wd/hub"), capabilities, TimeSpan.FromSeconds(180));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [ClassCleanup]
        public static void Cleanup()
        {
            driver.Quit();
        }


        [TestMethod]
        public void TestShouldClickAButtonThatOpensAnAlertAndThenDismissesIt()
        {
            Console.WriteLine("Start test");

            // Open the App/Alert Dialogs page
            var AppAlertDialogs = new AppAlertDialogs(driver);
            AppAlertDialogs.Goto();

            // Cause a dialog to be opened, and assert that the text in the dialog is correct

            AppAlertDialogs.Tap_OkCancelDialogWithAMessage_Button();
            Assert.AreEqual("Lorem ipsum dolor sit aie consectetur adipiscing\r\nPlloaso mako nuto siwuf cakso dodtos anr koop.", 
                AppAlertDialogs.AlertText());

            // Close the dialog
            AppAlertDialogs.Click_Ok_Button();
        }

        [TestMethod]
        public void TextCanBeAdded()
        {
            string Row2Text = "ThisIsATest";
            Console.WriteLine("Start test");

            // Open the Views/TextFields page
            var ViewsTextFields = new ViewsTextFields(driver);
            ViewsTextFields.Goto();

            // Enter text into the 'Password' field (row 2) and verify label is updated
            ViewsTextFields.FillTextRow2(Row2Text);
            Assert.AreEqual(Row2Text, 
                ViewsTextFields.GetRow2LabelText());
        }

        [TestMethod]
        public void Buttons_ClickToggleButton_Toggles()
        {
            var ViewsButtons = new ViewsButtons(driver);
            ViewsButtons.Goto();

            Assert.AreEqual("OFF", ViewsButtons.GetToggleButtonText());
            ViewsButtons.ClickToggleButton();
            Assert.AreEqual("ON", ViewsButtons.GetToggleButtonText());
        }
    }
}