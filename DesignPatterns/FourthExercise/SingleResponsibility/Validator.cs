using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthExercise.SingleResponsibility
{
    public class Validator
    {
        public bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }
    }
}
