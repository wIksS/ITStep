using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONWebDownload
{
    class Album
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string AlbumTitle { get; set; }

        public override string ToString()
        {
            return String.Format("ID --> {0}, Title --> {1}", this.Id, this.AlbumTitle);
        }
    }
}
