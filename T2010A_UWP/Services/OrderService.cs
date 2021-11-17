using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T2010A_UWP.Models.Entity;
using T2010A_UWP.Adapters;
using Windows.Web.Http;
using Newtonsoft.Json;
using Windows.Storage.Streams;
namespace T2010A_UWP.Services
{
    class OrderService
    {
        public async Task<CreateOrder> CreateOrder()
        {
            CartService cs = new CartService();
            var items = cs.GetCart(); // list cart item
            if (items.Count > 0)
            {
                ApiURL apiURL = ApiURL.GetInstance();
                HttpClient httpClient = new HttpClient();
                Uri uri = new Uri(apiURL.GetApiCreateOrder());
                HttpStringContent content = new HttpStringContent( // nạp parameters
                    "items:"+JsonConvert.SerializeObject(items),
                    UnicodeEncoding.Utf8,
                    "application/json"
                    );
                HttpResponseMessage msg = await httpClient.PostAsync(uri, content); // post api
                var rsBody = await msg.Content.ReadAsStringAsync(); // đã post và nhận response -> biến content thành 1 string
                CreateOrder createOrder = JsonConvert.DeserializeObject<CreateOrder>(rsBody);
                return createOrder;
            }
            return null;
        }
    }
}
