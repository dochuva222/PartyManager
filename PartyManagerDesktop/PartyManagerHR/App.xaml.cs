﻿using PartyManagerLib.Models;
using PartyManagerLib.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PartyManagerHR
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Employee LoggedEmployee;
        public App()
        {
            DBConnection.InitializeDBConnection().GetAwaiter().GetResult();
        }

    }
}
