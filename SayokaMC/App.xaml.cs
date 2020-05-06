using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SayokaMC
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public void OnCloseClick(object sender, EventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
