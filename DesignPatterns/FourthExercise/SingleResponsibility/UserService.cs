using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthExercise.SingleResponsibility
{
    public class UserService
    {
        private readonly Validator _validator;
        private readonly EmailService _emailService;

        private List<string> Users { get; set; }

        public UserService()
        {
            Users = new List<string>();
            _validator = new Validator();
            _emailService = new EmailService();
        }

        public void Register(string email)
        {
            if (_validator.ValidateEmail(email))
            {
                Users.Add(email);
            }
        }

        public void SendEmails()
        {
            _emailService.SendEmails(Users);
        } 
    }
}
