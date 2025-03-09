namespace BankApp;

public partial class MainPage : ContentPage
{
	private Bank _bank;
	public MainPage()
	{
		_bank = new Bank();
		
		InitializeComponent();

		_pckSelectAccountByNumber.ItemsSource = _bank.CreateListOfAccountID();
	}


	private void OnSelectingAccountClicked(object sender, EventArgs e)
	{
		_lblBankTitle.Text = "Select Your Account";
		_btnCreateAccount.IsVisible = false;
		_btnSelectAccount.IsVisible = false;
		_pckSelectAccountByNumber.IsVisible = true;
		_btnBackToMainMenu.IsVisible = true;
	}

	private void BackToMainMenuOnClick(object sender, EventArgs e)
	{
		_lblBankTitle.Text = "Uncreative Bank Title";
		_btnCreateAccount.IsVisible = true;
		_btnSelectAccount.IsVisible = true;
		_pckSelectAccountByNumber.IsVisible = false;
		_btnBackToMainMenu.IsVisible = false;
	}
}
