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
using T2010A_UWP.Models.Entity;
using T2010A_UWP.Services;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T2010A_UWP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Categories : Page
    {
        public static Food food;
        public Categories()
        {
            this.InitializeComponent();
            
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            Category category = e.Parameter as Category;
            CategoryName.Text = category.name;
            // Da co category -> lay api du lieu ve
            RenderFoods(category);
            // neu o page FoodDetail thi api da co tu day
        }

        private async void RenderFoods(Category category)
        {
            ApiService service = new ApiService();
            CategoryDetail categoryDetail = await service.CategoryDetail(category);
            if(categoryDetail != null)
            {
                foreach(var f in categoryDetail.data.foods)
                {
                    Products.Items.Add(f);
                }
            }
        }

        private void Add_To_Cart(object sender, RoutedEventArgs e)
        {
            var id = ((Button)sender).Tag;
            // tu id lay ra food tu API
            Food f = new Food() { id = 1, name = "Demo food", image = "...", price = 12000 };
            //Food f = Products.SelectedItem as Food;
            CartItem item = new CartItem() { Id = f.id, Name = f.name, Image = f.image, Price = f.price, Qty = 1 };
            CartService service = new CartService();
            service.AddToCart(item);

            var list = service.GetCart();
            // vi du update item
            service.UpdateItem(item, 5);
        }

   
    }
}
