using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace Exemplos1.Validations
{
    public class Email
    {
        private string _email;

        public Email(string email)
        {
            validate(email);

            _email = email;
        }

        private void validate(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                if (addr.Address != email)
                    throw new ArgumentException("Email inválido.");
            }
            catch
            {
                throw new ArgumentException("Email inválido.");
            }
        }

        public string getValue()
        {
            return _email;
        }

    }
}
