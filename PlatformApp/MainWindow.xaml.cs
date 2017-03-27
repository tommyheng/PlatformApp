using CefSharp;
using MahApps.Metro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace PlatformApp
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            ChangeTheme();
            var setting = new CefSharp.CefSettings();
            CefSharp.Cef.Initialize(setting, true, false);
            var webView = new CefSharp.Wpf.ChromiumWebBrowser();
            webView.FrameLoadEnd += WebViewLoaded;
            MainGrid.Children.Insert(0, webView);
            webView.Address = "http://www.zi-han.net/theme/hplus/";
        }
        private void ChangeTheme()
        {
            ThemeManager.AddAccent("CustomAccent", new Uri("pack://application:,,,/Styles/CustomAccent.xaml"));
            var theme = ThemeManager.DetectAppStyle(Application.Current);
            ThemeManager.ChangeAppStyle(Application.Current, ThemeManager.GetAccent("CustomAccent"), theme.Item1);
        }

        private void WebViewLoaded(object sender, FrameLoadEndEventArgs e)
        {
            Dispatcher.BeginInvoke(new Action(() =>
            {
                maskLoading.Visibility = Visibility.Collapsed;
            }));
        }

    }
}
