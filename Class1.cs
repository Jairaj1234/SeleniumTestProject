using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace YourNamespace
{
    [TestFixture]
    public class SeleniumTestClass
    {
        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void TestGoogleSearch()
        {
            driver.Navigate().GoToUrl("https://www.google.com");
            var searchBox = driver.FindElement(By.Name("q"));
            searchBox.SendKeys("Jenkins");
            searchBox.Submit();
            Assert.IsTrue(driver.Title.Contains("Jenkins"));
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
