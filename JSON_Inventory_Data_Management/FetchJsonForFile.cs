using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InventaryMangement
{
    public class FetchJsonForFile
    {
        public Rice ReadTheJsonFile(string Path)

        {
            using (StreamReader File = new StreamReader(Path))
        {
                try
                {
                    string json = File.ReadToEnd();
                    return JsonConvert.DeserializeObject<Rice>(json);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
            }
        }
    }
}
