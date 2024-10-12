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
CurrentAccount.CreditLine = "-100";
CurrentAccount.Owner;

class CurrentAccount {
    public string Number;
    public double Balance;
    public double CreditLine;
    public Person Owner;

    public void Withdraw(){
        Balance -= Number;
        if (Balance < CreditLine){
            throw new ArgumentException("Withdrawing impossible !");
        }
        return Balance;
    }

    public void Deposit(){
        Balance += Number;
        return Balance;
    }
    
