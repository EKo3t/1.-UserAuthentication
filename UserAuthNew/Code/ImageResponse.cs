using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;


namespace UserAuthNew
{
    [DataContract]
    public class ImageResponse
    {
        [DataMember(Name = "preview")]
        public String PreviewUrl { get; set; }
    }
}
