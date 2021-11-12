using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using T2010A_UWP.Services;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T2010A_UWP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DemoFilePage : Page
    {
        public DemoFilePage()
        {
            this.InitializeComponent();
        }

        private void WriteFile(object sender, RoutedEventArgs e)
        {
            FileHandleService.WriteFile("t2010a.txt", "Đây là nội dung demo ngày 12/11/2021.");
        }

        private async void ReadFile(object sender, RoutedEventArgs e)
        {
            string content = await FileHandleService.ReadFile("t2010a.txt");
            txtBlock.Text = content;
        }
    }
}
