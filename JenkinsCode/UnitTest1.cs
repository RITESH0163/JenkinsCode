using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace JenkinsCode
{
    public class Tests
    {
        public static IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.amazon.com");
        }

        [Test]
        public void SuccessfulLogin()
        {
            driver.FindElement(By.XPath("//a//span[contains(text(),'sign in')]")).Click();
            driver.FindElement(By.XPath("//input[@type='email']")).SendKeys("9111440985");
            driver.FindElement(By.XPath("//input[@id='continue']")).Click();
            driver.FindElement(By.XPath("//input[@type='password']")).SendKeys("Ritesh&1996");
            driver.FindElement(By.XPath("//input[@id='signInSubmit']")).Click();
        }
        [Test]        
        public void IncoorectLogin()
        {

            driver.FindElement(By.XPath("//a//span[contains(text(),'sign in')]")).Click();
            driver.FindElement(By.XPath("//input[@type='email']")).SendKeys("9111440985");
            driver.FindElement(By.XPath("//input[@id='continue']")).Click();
            driver.FindElement(By.XPath("//input[@type='password']")).SendKeys("Ritesh1996");


        }
        
        [TearDown]
        public void Close()
        {
            driver.Close();
            driver.Quit();
        }
        

    }
}