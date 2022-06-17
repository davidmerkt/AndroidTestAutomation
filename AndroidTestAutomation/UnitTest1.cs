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

            DriverOptions capabilities = new AppiumOptions();
            capabilities.AddAdditionalCapability(MobileCapabilityType.App, $"C:/ApiDemos-debug.apk"); 

            driver = new AndroidDriver<AndroidElement>(new Uri("http://localhost:4723/wd/hub"), capabilities, TimeSpan.FromSeconds(180));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            driver.Quit();
        }


        [TestMethod]
        public void TestShouldClickAButtonThatOpensAnAlertAndThenDismissesIt()
        {
            driver.StartActivity("io.appium.android.apis", ".app.AlertDialogSamples");

            AndroidElement openDialogButton = driver.FindElementById("io.appium.android.apis:id/two_buttons");
            openDialogButton.Click();

            AndroidElement alertElement = driver.FindElementById("android:id/alertTitle");
            String alertText = alertElement.Text;
            Assert.AreEqual("Lorem ipsum dolor sit aie consectetur adipiscing\r\nPlloaso mako nuto siwuf cakso dodtos anr koop.", alertText);

            driver.FindElementById("android:id/button1").Click();
        }
    }
}