namespace BankApp;
/// <summary>
/// A class that represents the Account and represents the info of an Account"
/// </summary>
public class Account
{
    #region Field Variables 
    protected string _acctHolderName;
    protected int _acctNo;
    protected decimal _balance;
    protected double _annualInterestRate;
    
    #endregion


    #region Constructor

    public Account(string acctHolderName, int acctNo)
    {
        _acctHolderName = acctHolderName;
        _acctNo = acctNo;   
        _balance = 300m;
        _annualInterestRate = 3.0d;
    }
    
    #endregion


    #region Field Properties

    public string AcctHolderName
    {
        get { return _acctHolderName; }
    }

    public int AccountNumber
    {
        get { return _acctNo; }
    }

    public double AnnualInterestRate
    { 
        get { return _annualInterestRate; }
        set { _annualInterestRate = value / 100; }
    }

    public decimal Balance
    {
        get { return _balance; }
    }
    #endregion


    #region Methods

    public virtual decimal Deposit(decimal amount)
    {
        // TODO: Implement the Deposit method
        return 0;
    }

    public virtual decimal Withdraw(decimal amount)
    {
        // TODO: Implement the Withdraw method
        return 0;
    }

    public void Load(Account file)
    {
        // TODO: Implement the Load method
    }

    public void Save(Account file)
    {
        // TODO: Implement the Save method
    }
    #endregion




}