using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace selenium_tests
{
    public class SeleniumTests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            // Setup ChromeDriver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void Teardown()
        {
            // Cleanup after each test
            driver.Quit();
        }

        [Test]
        [Category("Selenium")]
        public void LoginTest()
        {
            // Test 1: Login Test
            // Navigate to the login page
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            Assert.That(driver.Title, Is.EqualTo("Selenium"));

            // Find username and password fields and login button
            IWebElement usernameField = driver.FindElement(By.CssSelector("#user-name"));
            IWebElement passwordField = driver.FindElement(By.CssSelector("#password"));
            IWebElement loginButton = driver.FindElement(By.CssSelector("#login-button"));

            // Enter credentials and click login
            usernameField.SendKeys("standard_user");
            passwordField.SendKeys("secret_sauce");
            loginButton.Click();

            // Verify if login was successful by checking for a specific element on the next page
            IWebElement productsHeader = driver.FindElement(By.CssSelector(".product_label"));
            Assert.That(productsHeader.Text, Is.EqualTo("Products"));
        }

        [Test]
        [Category("Selenium")]
        public void ShoppingCartTest()
        {
            // Test 2: Shopping Cart Test
            // Navigate to the website
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");

            // Perform actions to add items to the cart, navigate to cart, and verify items
            // Example actions:
            // - Add items to the cart
            // - Navigate to the cart page
            // - Verify items in the cart
            // - Assert conditions based on cart contents
        }

        [Test]
        [Category("Selenium")]
        public void LogoutTest()
        {
            // Test 3: Logout Test
            // Navigate to the website
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");

            // Perform actions to login, navigate to logout, and verify logout process
            // Example actions:
            // - Login with valid credentials
            // - Navigate to logout
            // - Verify logout message or re-login page
            // - Assert conditions based on logout process
        }
    }
}
