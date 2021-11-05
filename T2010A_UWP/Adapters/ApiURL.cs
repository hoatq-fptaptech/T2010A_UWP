using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2010A_UWP.Adapters
{
    sealed class ApiURL // ko cho bố con nào kế thừa
    {
        private readonly string baseURL = "http://foodgroup.herokuapp.com";

        private static ApiURL instance;

        private ApiURL()
        {

        }
        // singleton pattern -- "design pattern"
        public static ApiURL GetInstance()
        {
            if (instance == null)
            {
                instance = new ApiURL();
            }
            return instance;
        }

        public string GetApiCategories()
        {
            return String.Format(baseURL + "/api/menu");
        }

        public string GetApiTodaySpecial()
        {
            return String.Format(baseURL + "...");
        }
    }
}
