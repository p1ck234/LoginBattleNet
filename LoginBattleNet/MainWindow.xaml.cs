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

namespace LoginBattleNet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnExit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void btnMin_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void ToolBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void LogoConteiner_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            if (gridRegion.Visibility == Visibility.Hidden)
            {
                gridRegion.Visibility = Visibility.Visible;
            }
            else
            {
                gridRegion.Visibility = Visibility.Hidden;
            }
        }

        private void btnSet_Click(object sender, RoutedEventArgs e)
        {
            if(gridSetting.Visibility == Visibility.Hidden)
            {
                gridSetting.Visibility = Visibility.Visible;
            }
            else
            {
                gridSetting.Visibility= Visibility.Hidden;
            }
        }
    }
}
