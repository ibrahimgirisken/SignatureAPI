using SignatureAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureAPI.Domain.Entities.SignatureAsset
{
    public class SignatureAsset:BaseEntity
    {
        public string CompanyLogo { get; set; }
        public string GoogleImage { get; set; }
        public string YoutubeImage { get; set; }
        public string TimotechLogo { get; set; }
        public string AcademyLogo { get; set; }
        public string DownloadCenterLogo { get; set; }
        public string FairImage { get; set; }
        public string YoutubeVideoImage { get; set; }
        public string YoutubeVideo2Image { get; set; }
        public string YoutubeVideo3Image { get; set; }
        public string EnvironmentLogo { get; set; }
        public Guid? SignatureId { get; set; }
    }
}
