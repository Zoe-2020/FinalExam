using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FinalExam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        List<Account> Accounts = new List<Account>();
        List<SavingsAccount> SavingsAccounts = new List<SavingsAccount>();
        List<CurrentAccount> currentAccounts= new List<CurrentAccount>();

        private void accountLB_Loaded(object sender, RoutedEventArgs e)
        {
            SavingsAccount a1 = new SavingsAccount("Savings Account", "903923", "Buffy", "Summers", 4400);
            CurrentAccount a2 = new CurrentAccount ("Current Account","7347878", "Willow", "Rosenberg", 100000);
            CurrentAccount a3 = new CurrentAccount("Current Account","68549034", "Xander", "Harris", 50000);
            SavingsAccount a4 = new SavingsAccount("Savings Account","59589589", "Spike", "Rupert", 833200);

            Accounts.Add(a1);
            Accounts.Add(a2);
            Accounts.Add(a3);
            Accounts.Add(a4);
            SavingsAccounts.Add(a1);
            SavingsAccounts.Add(a4);
            currentAccounts.Add(a2);
            currentAccounts.Add(a3);

            if ((CurrentAccCB.IsChecked == false) && (SavingAccCB.IsChecked == false))
            {
                accountLB.ItemsSource = "";
            }
            if ((CurrentAccCB.IsChecked != false) && (SavingAccCB.IsChecked != false))
            {
                accountLB.ItemsSource = Accounts;
            }

        }

       

        private void CurrentAccCB_Checked(object sender, RoutedEventArgs e)
        {
         

            accountLB.ItemsSource = currentAccounts;


            if ((CurrentAccCB.IsChecked == false) && (SavingAccCB.IsChecked == false))
            {
                accountLB.ItemsSource = "";
            }
            if ((CurrentAccCB.IsChecked != false) && (SavingAccCB.IsChecked != false))
            {
                accountLB.ItemsSource = Accounts;
            }
           
        } 

        private void SavingAccCB_Checked(object sender, RoutedEventArgs e)
        {
         

         accountLB.ItemsSource = SavingsAccounts;


            if ((CurrentAccCB.IsChecked == false) && (SavingAccCB.IsChecked == false))
            {
                accountLB.ItemsSource = "";
            }
            if ((CurrentAccCB.IsChecked != false) && (SavingAccCB.IsChecked != false))
            {
                accountLB.ItemsSource = Accounts;
            }

        }

        private void CurrentAccCB_Unchecked(object sender, RoutedEventArgs e)
        {
            accountLB.ItemsSource = SavingsAccounts;
            if ((CurrentAccCB.IsChecked == false) && (SavingAccCB.IsChecked == false))
            {
                accountLB.ItemsSource = "";
            }
        }

        private void SavingAccCB_Unchecked(object sender, RoutedEventArgs e)
        {
            accountLB.ItemsSource = currentAccounts;
            if ((CurrentAccCB.IsChecked == false) && (SavingAccCB.IsChecked == false))
            {
                accountLB.ItemsSource = "";
            }
        }
    }
}
