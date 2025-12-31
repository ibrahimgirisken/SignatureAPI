using SignatureAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureAPI.Domain.Entities.SignatureLink
{
    public class SignatureLink: BaseEntity
    {
        public string WebSite { get; set; }
        public string Academy { get; set; }
        public string DownloadCenter { get; set; }
        public string Instagram { get; set; }
        public string Facebook { get; set; }
        public string Youtube { get; set; }
        public string YoutubeVideo1 { get; set; }
        public string YoutubeVideo2 { get; set; }
        public string YoutubeVideo3 { get; set; }
        public string Twitter { get; set; }
        public string Linkedin { get; set; }
        public string Mail { get; set; }
        public string Google { get; set; }
        public string News{ get; set; }
        public string Fair { get; set; }
        public string NewsLink { get; set; }
        public string Education { get; set; }
        public string ContactForm { get; set; }
        public string CorparateVideo { get; set; }
        public string PromotionVideo { get; set; }
    }
}
