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
        // TODO: Implement the OpenAccount method
        return null;
    }

    public void LoadAccountData()
    {
        // TODO: Implement the LoadAccountData method
    }

    public void SaveAccountData()
    {
        // TODO: Implement the SaveAccountData method
    }

    public Account FindAccount(int acctNum)
    {
        // TODO: Implement the FindAccount method
        return null;
        
    }

    private void CreateDefaultAccounts()
    {
        
    }

    private int DetermineAccountNumber()
    {
        // TODO: Implement the DetermineAccountNumber method
        return 0;
    }
    #endregion
}