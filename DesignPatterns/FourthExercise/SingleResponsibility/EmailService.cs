using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthExercise.SingleResponsibility
{
    public class EmailService
    {
        public void SendEmails(IEnumerable<string> emails)
        {
            foreach (var email in emails)
            {
                var result = SendEmail(email);
                if (!result)
                {
                    throw new Exception("Email is not sent!");
                }
            }
        }

        private bool SendEmail(string to)
        {
            return true;
        }
    }
}
