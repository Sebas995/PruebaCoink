using Newtonsoft.Json;
using System.Collections.Generic;

namespace Coink.DTO
{
    [JsonObject]
    public class ResponseModel
    {
        public ResponseModel()
        {
            Data = new Dictionary<string, object>();
        }

        /// <summary>
        /// Message of response
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// Response (true or false)
        /// </summary>
        public bool Response { get; set; }
        /// <summary>
        /// Data Response
        /// </summary>
        public Dictionary<string, object> Data { get; set; }
    }
}
