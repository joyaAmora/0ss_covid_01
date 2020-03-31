using BillingManagement.Business;
using BillingManagement.Models;
using BillingManagement.UI.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Inventaire
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class CustomerView : Window
    {
        

        public CustomerView(CustomersViewModel vm)
        {
            InitializeComponent();
        }

        //private void CustomerNew_Click(object sender, RoutedEventArgs e)
        //{
        //    Customer temp = new Customer() { Name = "Undefined", LastName = "Undefined" };
        //    Customers.Add(temp);
        //    SelectedCustomer = temp;            
        //}

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
