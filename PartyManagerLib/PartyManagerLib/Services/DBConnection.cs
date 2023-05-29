using PartyManagerLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyManagerLib.Services
{
    public static class DBConnection
    {
        public static List<Employee> Employees { get; set; }
        public static List<Event> Events { get; set; }
        public static List<EventEmployee> EventEmployees { get; set; }
        public static List<EventTask> EventTasks { get; set; }
        public static List<EventTaskReport> EventTaskReports { get; set; }
        public static List<Role> Roles { get; set; }
        public static List<Models.TaskStatus> TaskStatuses { get; set; }

        //static DBConnection()
        //{
        //    GetData();
        //}

        //for static data (like roles, statuses) and first get all data
        public static async Task  InitializeDBConnection()
        {

            Roles = await NetManager.GetRoles();

            RefreshData();
        }

        public static async void RefreshData()
        {
            Employees = await NetManager.GetEmployees();
            //Events = await NetManager.GetEmployees();
            //TaskStatuses = await NetManager.GetEmployees();
            //Employees = await NetManager.GetEmployees();
        }
    }
}
