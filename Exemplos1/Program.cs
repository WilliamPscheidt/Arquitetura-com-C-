using Exemplos1.Validations;

public class Person
{
    private Name _name;
    private Email _email;

    public Person(Name name, Email email)
    {
        _name = name;
        _email = email;
    }

    public string GetName()
    {
        return _name.GetValue();
    }

    public string GetEmail()
    {
        return _email.getValue();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Name name = new Name("William Pscheidt");
            Email email = new Email("contato@williampscheidt.com.br");
            Person person = new Person(name, email);
            Console.WriteLine($"{person.GetName()} <{person.GetEmail()}>");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
        }
    }
}
