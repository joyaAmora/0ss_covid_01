using BillingManagement.UI.ViewModels;
using System.Windows;

namespace Inventaire
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        CustomerView _wnd;
        public App()
        {
            CustomersViewModel vm = new CustomersViewModel();
            _wnd = new CustomerView(vm);
            _wnd.Show();
        }
    }
}
