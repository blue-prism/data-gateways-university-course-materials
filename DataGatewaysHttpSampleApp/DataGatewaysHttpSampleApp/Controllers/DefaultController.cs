using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DataGatewaysHttpSampleApp.Controllers
{
    public class DefaultController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage EchoRequest()
        {
            string receivedMessage = Request.Content.ReadAsStringAsync().Result;
            var returnedMessage = Request.CreateResponse(HttpStatusCode.OK, receivedMessage);
            return returnedMessage;
        }
    }
}
