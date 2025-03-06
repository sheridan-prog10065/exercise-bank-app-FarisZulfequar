namespace BankApp;
/// <summary>
/// A class that represents the SavingsAccount and Deposit Money"
/// </summary>
public class SavingsAccount : Account
{
    #region Constructor
    public SavingsAccount(string acctHolderName, int acctNo) : base(acctHolderName, acctNo)
    {
        // Guess since there's no specific field variables for the derived class, we leave this empty
    }
    #endregion
    
    
    #region Field Properties
    public double AnnualInterestRate
    {
        get { return base.AnnualInterestRate; }
        set { base.AnnualInterestRate = value; }
    }
    #endregion
    
    
    #region Methods

    public override decimal Deposit(decimal amount)
    {
        // TODO: Implement the Derived Deposit method
        return 0;
    }
    #endregion
    
    
}