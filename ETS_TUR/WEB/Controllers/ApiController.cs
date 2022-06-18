using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace WEB.Controllers
{
    public class ApiController : ControllerBase
    {
        private readonly JsonSerializerSettings setting;

        public ApiController()
        {
            setting = new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };
        }

        public string GetProperResponse(object data)
        { 
            return JsonConvert.SerializeObject(data, setting);
        }
    }
}
