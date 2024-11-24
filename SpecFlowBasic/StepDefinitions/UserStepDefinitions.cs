using AutoFixture;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowBasic.StepDefinitions
{
    [Binding]
    public class UserStepDefinitions
    {
        [Given(@"I enter random user data")]
        public void GivenIEnterRandomUserData()
        {
            //var person = new Fixture().Create<User>();
            var person = new Fixture().Build<User>().With(x => x.Email, "dhee@example.co.in").Create();
            Console.WriteLine($"Name : {person.Name} | Email : {person.Email} | Address : {person.Address} | Phone : {person.Phone}");
        }

        

        [Given(@"I input dynamic domain at (.* email)")]
        public void GivenIInputDynamicDomainDheerajExample_Co_InEmail(string email)
        {
            Console.WriteLine($"Email: {email}");
        }



    }


    public record User
    {
        public string Name { get; init; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
