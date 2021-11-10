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
using T2010A_UWP.Models;
using Windows.UI.Xaml.Media.Imaging;
using T2010A_UWP.Adapters;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T2010A_UWP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Home : Page
    {
        public Home()
        {
            this.InitializeComponent();
            var p1 = new Product() {Name="Quần áo thời trang thu đông",Price=200000,Img = new BitmapImage(new Uri("https://dscnnwjxnwl3f.cloudfront.net/media/catalog/product/cache/584039753b87a8d227764e04fc461e3e/h/a/hawaii_burger_1_2.jpg")) };
            var p2 = new Product() {Name="Đồ ăn nhanh fastfood",Price=120000, Img = new BitmapImage(new Uri("https://dscnnwjxnwl3f.cloudfront.net/media/catalog/product/cache/584039753b87a8d227764e04fc461e3e/h/a/hawaii_burger_1_2.jpg")) };
            // local app image
            var p3 = new Product() {Name="Đồng hồ quả lắc",Price=250000, Img = new BitmapImage(new Uri("ms-appx:///Assets/images.png")) };
            Products.Items.Add(p1);
            Products.Items.Add(p2);
            Products.Items.Add(p3);
            SQLiteHelpler sQ = SQLiteHelpler.GetInstance();
        }
    }
}
