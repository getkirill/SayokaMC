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

namespace SayokaMC
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //MinecraftManager.LaunchMinecraft("1.12.2", "kraskaska");
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
            var installedMC = MessageBox.Show("Извеняемся за лишние вопросы, лаунчер находится в бете\nБыл ли установлен Minecraft с помощью этого лаунчера раньше?", "SayokaLuncher", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (installedMC == MessageBoxResult.No) MinecraftManager.DownloadMinecraft();
            if (nickname.Text.Length != 0) MinecraftManager.LaunchMinecraft("1.12.2", nickname.Text); else MessageBox.Show("Введите ник!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }
}
