namespace BankApp;
/// <summary>
/// A class that represents the SavingsAccount and Deposit Money"
/// </summary>
public class SavingsAccount : Account
{
    #region Constant Variables
    private const double MATCHING_DEPOSIT_RATIO = 0.5;
    private const double MIN_INTEREST_RATE = 3.0;
    #endregion
    
    #region Constructor
    public SavingsAccount(string acctHolderName, int acctNo) : base(acctHolderName, acctNo)
    {
        // Guess since there's no specific field variables for the derived class, we leave this empty
    }
    #endregion
    
    
    #region Field Properties
    public double AnnualInterestRate
    {
        get { return _annualInterestRate; }
        set { _annualInterestRate = value / 100; }
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