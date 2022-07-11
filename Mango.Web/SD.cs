using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mango.Web
{
    public static class SD
    {
        public static string ProductAPIBase { get; set; } = "https://localhost:44354";
        public enum ApiType
        {
            GET,
            POST,
            PUT,
            DELETE
        }
    }
}
