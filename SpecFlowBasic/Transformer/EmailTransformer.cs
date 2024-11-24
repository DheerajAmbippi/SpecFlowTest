using AutoFixture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowBasic.Transformer
{
    [Binding]
    public class EmailTransformer
    {
        

        [StepArgumentTransformation(@"(.*) email")]
        public string GenerateDynamicEmailAt(string email)
        {
            return email.Split('@')[0] + "@" + GetRandomDomain();
        }

        private string GetRandomDomain()
        {
            return new Fixture().Create<MailAddress>().Host;
        }
    }
}
