using Swashbuckle.Dummy.Types;
using Swashbuckle.Swagger.Annotations;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;

namespace Swashbuckle.Dummy.Controllers
{
    public class ResponseSamplesController : ApiController
    {
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK, description: "Something fishy", type: typeof(IEnumerable<AnotherEnum>), example: "[\"BlueFish\",\"RedFish\"]")]
        public IHttpActionResult ResponseSampleAction()
        {
            List<AnotherEnum> response = new List<AnotherEnum>();
            response.Add(AnotherEnum.OneFish);
            response.Add(AnotherEnum.TwoFish);
            return Ok(response);
        }

        [HttpGet]
        [Route("ResponseObjectSampleAction/")]
        [SwaggerResponse(HttpStatusCode.OK, description: "Some fishy object", type: typeof(IEnumerable<Fish>), example: "[{\"Name\":\"Trout\",\"Count\":10},{\"Name\":\"Shark\",\"Count\":5}]")]
        public IHttpActionResult ResponseObjectSampleAction()
        {
            List<Fish> response = new List<Fish>();
            response.Add(new Fish() { Name = "Trout", Count = 10 });
            response.Add(new Fish() { Name = "Shark", Count = 5 });

            return Ok(response);
        }
    }

    public class Fish
    {
        public string Name { get; set; }
        public int Count { get; set; }
    }
}
