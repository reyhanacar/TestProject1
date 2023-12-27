using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;


namespace TestProject1
{
    [Binding]
    internal class Outline
    {
        [Given(@"I am on the registration page")]
        public void GivenIAmOnTheRegistrationPage()
        {
            Console.WriteLine("I am on the page ");


        }

        [When(@"I provide username (.*)")]
        public void WhenIProvideUsernameJack(string username)
        {
            Console.WriteLine(" Username: " + username);

        }

        [When(@"I provide email (.*)")]
        public void WhenIProvideEmailJackTest_Com(string email) {

            Console.WriteLine("Email Adress: " + email);
            {


                [When(@"I provide age (.*)")]
                 void WhenIProvideAge(int age)
                {
                    Console.WriteLine(" Age : " + age);



                }

                [When(@"I register for event")]
                 void WhenIRegisterForEvent()
                {
                  


                }
            }
        }
    } }
