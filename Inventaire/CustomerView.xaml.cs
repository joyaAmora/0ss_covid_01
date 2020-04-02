using BillingManagement.Models;
using BillingManagement.UI.ViewModels;
using System;
using System.Windows;

namespace Inventaire
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class CustomerView : Window
    {

        CustomersViewModel viewModel;
        public CustomerView(CustomersViewModel vm)
        {
            InitializeComponent();
            DataContext = new CustomersViewModel();
            viewModel = vm;
        }

        private void NouveauClient_Click(object sender, RoutedEventArgs e)
        {
            Customer temp = new Customer() { Name = "Undefined", LastName = "Undefined" };
            viewModel.Customers.Add(temp);
            viewModel.SelectedCustomer = temp;
            lvCustomers.ItemsSource = viewModel.Customers;
            lvCustomers.SelectedItem = temp;
        }

        //private void CustomerDelete_Click(object sender, RoutedEventArgs e)
        //{
        //    int currentIndex = Customers.IndexOf(SelectedCustomer);

        //    if (currentIndex > 0)
        //        currentIndex--;

        //    Customers.Remove(SelectedCustomer);

        //    lvCustomers.SelectedIndex = currentIndex;

        //}
    }
}
