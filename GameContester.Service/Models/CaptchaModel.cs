using Newtonsoft.Json;
using System.Collections.Generic;


namespace GameContester.Service.Models
{
    public class CaptchaModel
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error-codes")]
        public List<string> ErrorCodes { get; set; }
    }
}