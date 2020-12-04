using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using IdentityModel.Client;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdentityServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        [HttpGet]
        [Route("generate")]
        public async Task<IActionResult> GenerateToken()
        {
            HttpClient httpClient = new HttpClient();
            var tokenResponse = await httpClient.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
            { 
                Address = "https://demo.identityserver.io/connect/token",
                ClientSecret = "ClientSecret",
                ClientId = "ClientId",
                Scope = "SampleService"
            });

            return Ok(tokenResponse.Json);

           
        }
    }
}
