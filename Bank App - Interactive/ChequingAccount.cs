namespace BankApp;
/// <summary>
/// A class that represents the SavingsAccount and Withdraw Money"
/// </summary>
public class ChequingAccount : Account
{
    #region Constant Variables
    private const int OVERDRAFT_LIMIT = 500;
    private const double MAX_INTEREST_RATE = 1.0;
    #endregion
    
    
    #region Constructor
    public ChequingAccount(string acctHolderName, int acctNo) : base(acctHolderName, acctNo)
    {
        // Guess since there's no specific field variables for the derived class, we leave this empty
    }
    #endregion


    #region Properties
    
    public double AnnualInterestRate
    {
        get { return _annualInterestRate; }
        set { _annualInterestRate = value; }
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