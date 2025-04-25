using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos1.Validations
{
    public class Name
    {
        private string value;

        public Name(string personName)
        {
            validate(personName);
            value = personName;
        }

        private void validate(string name)
        {
            if (name == "William")
            {
                throw new InvalidOperationException("Nome inválido");
            }
        }

        public string GetValue()
        {
            return value;
        }
    }
}
