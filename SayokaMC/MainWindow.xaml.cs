
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SayokaMC
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        static extern bool GetPhysicallyInstalledSystemMemory(out long TotalMemoryInKilobytes);
        public MainWindow()
        {
            InitializeComponent();
            this.IsEnabled = false;
            this.Hide();
            fetchingAssetsModal.fetch();
            this.IsEnabled = true;
            this.Show();
        }

        private void OnCloseClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void OnMinimizeClick(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        private void MoveWindow(object sender, MouseButtonEventArgs e)
        {
            Application.Current.MainWindow.DragMove();
        }

        private void launchmc(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(version.Text);
            if (nickname.Text.Length != 0) {
                if (Directory.Exists("C:\\.sayokamc\\versions\\" + version.Text))
                {
                    MinecraftManager.LaunchMinecraft(version.Text, forge.IsEnabled, nickname.Text);
                } else
                {
                    MessageBox.Show("Этой версии несуществует. Начинаем загрузку, предположительного времени окончания нету!", "SayokaLauncher", MessageBoxButton.OK, MessageBoxImage.Information);
                    MinecraftManager.DownloadMinecraft(version.Text, forge.IsEnabled);
                }
            }
            else MessageBox.Show("Введите ник!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void checkVersion(object sender, SelectionChangedEventArgs e)
        {
            if (!Directory.Exists("C:\\.sayokamc\\versions\\" + version.Text))
            {
                play.Content = "Загрузить";
            }
            else play.Content = "Играть";
        }
    }
}
