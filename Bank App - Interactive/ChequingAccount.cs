namespace BankApp;
/// <summary>
/// A class that represents the SavingsAccount and Withdraw Money"
/// </summary>
public class ChequingAccount : Account
{
    #region Constructor
    public ChequingAccount(string acctHolderName, int acctNo) : base(acctHolderName, acctNo)
    {
        // Guess since there's no specific field variables for the derived class, we leave this empty
    }
    #endregion


    #region Properties

    

    
    public double AnnualInterestRate
    {
        get { return base.AnnualInterestRate; }
        set { base.AnnualInterestRate = value; }
    }
    #endregion
    
    
    #region Methods
    public override decimal Withdraw(decimal amount)
    {
        // TODO: Implement the Derived Withdraw method
        return 0;
    }
    #endregion
}