namespace BankApp;
/// <summary>
/// A class that represents the Bank that holds a list of info about Accounts"
/// </summary>
public class Bank
{
    #region Field Variables
    /// <summary>
    /// A list field variable to hold all the accounts
    /// </summary>
    private List<Account> _accountList;
    #endregion
    
    
    #region Constructor
    public Bank()
    {
        _accountList = new List<Account>();
    }
    #endregion
    
    
    #region Methods
    public Account OpenAccount()
    {
        return null;
    }

    public void LoadAccountData()
    {
        
    }

    public void SaveAccountData()
    {
        
    }

    public Account FindAccount(int acctNum)
    {
        return null;
        
    }

    private void CreateDefaultAccounts()
    {
        
    }

    private int DetermineAccountNumber()
    {
        return 0;
    }
    #endregion
}