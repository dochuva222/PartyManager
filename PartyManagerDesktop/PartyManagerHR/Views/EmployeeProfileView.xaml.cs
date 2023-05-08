using PartyManagerLib.Models;
using PartyManagerLib.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    /// Логика взаимодействия для EmployeeProfileView.xaml
    /// </summary>
    public partial class EmployeeProfileView : Page
    {
        Employee contextEmployee;
        public EmployeeProfileView(Employee employee)
        {
            InitializeComponent();
            CBRoles.ItemsSource = DBConnection.Roles;
            contextEmployee = employee;
            DataContext = contextEmployee;
        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {
            string errorMessage = "";
            var context = new ValidationContext(contextEmployee);
            var results = new List<System.ComponentModel.DataAnnotations.ValidationResult>();
            if(!Validator.TryValidateObject(contextEmployee, context, results, true))
            {
                foreach (var result in results)
                {
                    errorMessage += $"{result.ErrorMessage}\n";
                }
            }
            if (!string.IsNullOrWhiteSpace(errorMessage))
            {
                MessageBox.Show(errorMessage);
                return;
            }
            if(contextEmployee.Id == 0)
            {
                throw new NotImplementedException();
            }
            else
            {
                throw new NotImplementedException();
            }
            DBConnection.RefreshData();
            NavigationService.GoBack();
        }

        private void BCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void BChangePhoto_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
