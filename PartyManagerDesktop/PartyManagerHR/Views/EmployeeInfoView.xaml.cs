using PartyManagerLib.Models;
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

namespace PartyManagerHR.Views
{
    /// <summary>
    /// Логика взаимодействия для EmployeeInfoView.xaml
    /// </summary>
    public partial class EmployeeInfoView : Page
    {
        Employee contextEmployee;
        public EmployeeInfoView(Employee employee)
        {
            InitializeComponent();
            contextEmployee = employee;
            DataContext = contextEmployee;
        }

        private void BEdit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EmployeeProfileView(contextEmployee));
        }
    }
}
