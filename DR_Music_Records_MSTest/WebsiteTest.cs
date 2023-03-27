using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace DR_Music_Records_MSTest
{
    [TestClass]
    public class WebsiteTest
    {
        private static readonly string DriverDirectory = "C:\\WebDrivers";
        private readonly string _url = "https://drmusicrecordswebsite.azurewebsites.net/";
        private static IWebDriver? _driver;

        [ClassInitialize]
        public static void init(TestContext context)
        {
            _driver = new FirefoxDriver(DriverDirectory);
            //_driver = new ChromeDriver(DriverDirectory);
        }

        [ClassCleanup]
        public static void cleanup()
        {
            _driver!.Dispose();
        }

        [TestMethod]
        public void GetAllTest()
        {
            _driver!.Navigate().GoToUrl(_url);

            IWebElement buttonElement = _driver.FindElement(By.Id("getAllButton"));
            buttonElement.Click();

            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            IWebElement records = wait.Until(record => record.FindElement(By.Id("getAllRecordsList")));
            Assert.IsTrue(records.Text.Contains("Thriller"));
        }

        [TestMethod]
        public void GetAllWithFiltersTest()
        {
            _driver!.Navigate().GoToUrl(_url);

            IWebElement inputElement = _driver.FindElement(By.Id("inputTitle"));
            inputElement.SendKeys("21");

            IWebElement buttonElement = _driver.FindElement(By.Id("getAllButton"));
            buttonElement.Click();

            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            IWebElement records = wait.Until(record => record.FindElement(By.Id("getAllRecordsList")));
            Assert.IsTrue(records.Text.Contains("21"));
        }
    }
}