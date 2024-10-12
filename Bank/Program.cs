Person person = new Person();

Person.FirstName = "N";
Person.LastName = "O";
Person.BirthDate = "";

class Person {
    public string FirstName;
    public string LastName;
    public DateTime BirthDate;
    }

CurrentAccount currentaccount = new CurrentAccount();

CurrentAccount.Number = "35";
CurrentAccount.Balance = "26";
CurrentAccount.CreditLine = "62";
CurrentAccount.Owner;

class CurrentAccount {
    public string Number;
    public double Balance;
    public double CreditLine;
    public Person Owner;

    public void Withdraw(){

    }

    public void Deposit(){

    }
    
