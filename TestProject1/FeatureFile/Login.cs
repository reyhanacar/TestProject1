using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace TestProject1
{
    [Binding]

      public class Login
    {
       private IWebDriver driver;
    
    
        
        
        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {

            Console.WriteLine("I'm on the login page");


        }

        [When(@"I enter username")]
        public void WhenIEnterUsername()
        {
            Console.WriteLine("Hello Username");
        }

        [When(@"I enter password")]
        public void WhenIEnterPassword()
        {
            Console.WriteLine("Hello Password");
        }

        [When(@"I select login")]
        public void WhenISelectLogin()
        {
            Console.WriteLine("Hello Login");
        }

        [Then(@"I verify successfull login")]
        public void ThenIVerifySuccessfullLogin()
        {
            Console.WriteLine("Hello Successfull Login");
        }


    }
}
