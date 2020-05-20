using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace SayokaMC
{
    /// <summary>
    /// Логика взаимодействия для fetchingAssetsModal.xaml
    /// </summary>
    public partial class fetchingAssetsModal : Window
    {
        public fetchingAssetsModal()
        {
            InitializeComponent();
        }
        public static void fetch()
        {
            fetchingAssetsModal modal = new fetchingAssetsModal();
            modal.Show();
            if (Directory.Exists(@"C:\.sayokamc\"))
            {
                modal.Close();
                return;
            } else
            {
                var configure = MessageBox.Show("SayokaLauncher был установлен впервые.\nСистема может настроит лаунчер для комфортной работы.\nЗапустить менеджер конфигурации ПК?", "SayokaLauncher", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.Yes);
                if(configure == MessageBoxResult.Yes)
                {
                    configurePC();
                }
                modal.Close();
                return;
            }
        }

        private static void configurePC()
        {
            return;
        }
    }
}
