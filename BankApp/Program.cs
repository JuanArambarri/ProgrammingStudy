namespace BankApp;

class Program
{
    static void Main(string[] args)
    {
        CheckingAcct BauAccount = new CheckingAcct("Juan Bautista", "Arambarri Torre",100m);
        BauAccount.AcctBalance();
        BauAccount.Withdraw(115m);
        Console.WriteLine("The owner of this Checkings account is " + BauAccount.AccountOwner);
        BauAccount.AcctBalance();

        SavingsAcct LuAccount = new SavingsAcct("Lucia", "Jaurretche Vargas", 0.3m, 500m);
        LuAccount.AcctBalance();
        LuAccount.ApplyInterest();
        Console.WriteLine("The owner of this Checkings account is " + LuAccount.AccountOwner);
        LuAccount.AcctBalance();
        LuAccount.Withdraw(20m);
        LuAccount.Withdraw(20m);
        LuAccount.Withdraw(8m);
        LuAccount.AcctBalance();
        

    }
public class BankAccount {
    public string AccountOwner {get;}

    public decimal Balance {get;set;}
    public BankAccount(string firstName, string lastName, decimal balance){
        AccountOwner = firstName + " " + lastName;
        Balance = balance;
    }
    public virtual void AcctBalance(){
            Console.WriteLine("The current balance in your account is: ARS$" + Balance);
        }
    public virtual void Deposit(decimal amountToDeposit){
        Balance += amountToDeposit;
    }
    public virtual void Withdraw(decimal amountToWithdraw){
        Balance -= amountToWithdraw;
    }
}

public class CheckingAcct : BankAccount {
    public CheckingAcct(string firstName, string lastName,decimal balance) : base(firstName, lastName, balance){
    }
    public override void Withdraw(decimal amountToWithdraw){
        if(Balance<amountToWithdraw){
            Balance -= (amountToWithdraw + 35);
        }else{
            Balance -= amountToWithdraw;
        }
    }
}

public class SavingsAcct : BankAccount {
    public decimal Interest{get;set;}
    public int WithdrawCount{get;set;}
    public SavingsAcct(string firstName, string lastName,decimal interest,decimal balance) : base(firstName, lastName, balance){
        Interest = interest;
        WithdrawCount = 0;
    }
    public void ApplyInterest(){
        Balance += (Interest * Balance);
    }
    public override void Withdraw(decimal amountToWithdraw)
    {
            if(amountToWithdraw > this.Balance){
                Balance -= (amountToWithdraw - 35);
                WithdrawCount++;
            }else{
                Balance -= amountToWithdraw;
                WithdrawCount++;
            }
            if(WithdrawCount == 3){
                Balance -= 2;
            }
    }
}
}