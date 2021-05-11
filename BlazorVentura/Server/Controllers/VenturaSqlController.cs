using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using VenturaSQL;
using VenturaSQL.AspNetCore.Server.RequestHandling;

namespace BlazorVentura.Server.Controllers
{
    [ApiController]
    [AllowAnonymous]
    public class VenturaSqlController : ControllerBase
    {
        [Route("api/venturasql")]
        [HttpPost]
        public async Task<IActionResult> Index(byte[] requestData)
        {

            var processor = new VenturaSqlServerEngine();

            processor.CallBacks.LookupAdoConnector = LookupAdoConnector;

            await processor.ExecAsync(requestData);

            Response.ContentType = "application/octet-stream";

            await Response.Body.WriteAsync(processor.ResponseBuffer, 0, processor.ResponseLength);

            return Ok();
        }

        private AdoConnector LookupAdoConnector(string requestedName)
        {
            if (requestedName == "DefaultConnector")
                return (AdoConnector)VenturaSqlConfig.DefaultConnector;

            throw new Exception($"Requested connector name {requestedName} is unknown on server.");
        }
    }
}
