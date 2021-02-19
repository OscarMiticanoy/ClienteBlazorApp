using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ClienteBlazorApp.Pages.AgreementView;
using Newtonsoft.Json;

namespace ClienteBlazorApp.Data
{
    public class Response
    {
        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("data")]
        public List<Agreement> agreementsList { get; set; }
    }
}
