using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
namespace T2010A_UWP.Services
{
    class FileHandleService
    {
        // Write file
        public static async void WriteFile(string fileName,string content)
        {
            var storage = ApplicationData.Current.LocalFolder;
            var file = await storage.CreateFileAsync(fileName, CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(file, content);
        }

       // Read file
       public static async Task<string> ReadFile(string fileName)
        {
            var storage = ApplicationData.Current.LocalFolder;
            var file = await storage.CreateFileAsync(fileName, CreationCollisionOption.OpenIfExists);
            return await FileIO.ReadTextAsync(file);
        }
    }
}
