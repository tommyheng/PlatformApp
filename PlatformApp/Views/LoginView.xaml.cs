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
using System.Windows.Shapes;

namespace TomNet.Platform.App.Views
{
    /// <summary>
    /// LoginView.xaml 的交互逻辑
    /// </summary>
    public partial class LoginView :Window
    {
        public LoginView()
        {
            InitializeComponent();
        }
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void closeBtne_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void minBtn_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void LoginView_OnLoaded(object sender, RoutedEventArgs e)
        {
            this.LoginName.Focus();
            LoginName.SelectionStart = LoginName.Text.Length;
            double workHeight = SystemParameters.WorkArea.Height;
            double workWidth = SystemParameters.WorkArea.Width;
            this.Top = (workHeight - this.Height) / 2 - this.Height / 4;
            this.Left = (workWidth - this.Width) / 2;
        }
        private void ForgetClick(object sender, RoutedEventArgs e)
        {

        }

        private void RegisterClick(object sender, RoutedEventArgs e)
        {

        }

        private void LoginClick(object sender, RoutedEventArgs e)
        {
            Hide();
            MenuView menu = new MenuView();
            menu.ShowDialog();
            
        }
    }
}
