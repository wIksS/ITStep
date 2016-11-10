using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace JSONWebDownload
{
    class Program
    {
        static void Main(string[] args)
        {
            List<KeyValuePair<string,int>> arr = new List<KeyValuePair<string,int>>()
            {
                new KeyValuePair<string,int>("Pesho",3 ),
                new KeyValuePair<string,int>("Tosho",13 ),
                new KeyValuePair<string,int>("Gosho",23 ),
                new KeyValuePair<string,int>("Pesho",43 ),
                new KeyValuePair<string,int>("Stamat",3)
            };

            var peshos = arr.Where(x => x.Value == 3).ToList();

            Console.WriteLine(peshos[1]);

            using (WebClient client = new WebClient())
            {
                string jsonAlbums = client.DownloadString("https://jsonplaceholder.typicode.com/albums");

                List<Album> albums = JsonConvert.DeserializeObject<List<Album>>(jsonAlbums);

                for (int i = 0; i < albums.Count; i++)
                {
                    //Console.WriteLine(albums[i]);
                }
            }
        }
    }
}
