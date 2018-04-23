using System.Windows;
using System.Windows.Controls;
using DevExpress.Xpf.RichEdit;
using System.Windows.Threading;
using System;

namespace RichEditTwoControlsOneToolbarSL {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
        }

        void MainPage_Loaded(object sender, RoutedEventArgs e) {
            System.Windows.Browser.HtmlPage.Plugin.Focus();
            richEditControl1.ApplyTemplate();
            Dispatcher.BeginInvoke(() => { richEditControl1.KeyCodeConverter.Focus(); });
        }

        private void richEditControl_GotFocus(object sender, RoutedEventArgs e) {
            RichEditControl richEditControl = (RichEditControl)sender;

            richEditControl1.BarManager = null;
            richEditControl2.BarManager = null;
            richEditControl.BarManager = barManager1;
            richEditControlProvider1.RichEditControl = richEditControl;
        }
    }
}
