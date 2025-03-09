namespace BankApp;
/// <summary>
/// A class that represents the Bank that holds a list of info about Accounts"
/// </summary>
public class Bank
{
    #region Field & Constant Variables
    /// <summary>
    /// A list field variable to hold all the accounts
    /// </summary>
    private List<Account> _accountList;

    private static int s_defaultAccountStarter;
    #endregion
    
    
    #region Constructor
    public Bank()
    {
        _accountList = new List<Account>();
        s_defaultAccountStarter = 100;
        
        CreateDefaultAccounts();
    }
    #endregion
    
    #region Properties

    public static int DefaultAccountStarter
    {
        get { return s_defaultAccountStarter; }
        set { s_defaultAccountStarter = value; }
    }

    public List<Account> AccountList
    {
        get { return _accountList; }
        set { _accountList = value; }
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
        // Have a loop that creates 5 accounts with all the same balance
        int numberName = 0;
        for (int i = 0; i < 5; i++)
        {
            Account defaultAccount = new Account($"name{numberName.ToString()}", DefaultAccountStarter);
            AccountList.Add(defaultAccount);
            
            numberName++;
            DefaultAccountStarter++;
        }
    }

    private int DetermineAccountNumber()
    {
        // TODO: Implement the DetermineAccountNumber method
        return 0;
    }

    private int DistributingRandomBalance()
    {
        return 0;
    }
    #endregion
}