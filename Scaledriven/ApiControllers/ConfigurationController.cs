using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Scaledriven.Areas.Shared.Options;

namespace Scaledriven.ApiControllers
{
    [Route("api/[controller]")]
    public class ConfigurationController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        /// <summary>
        ///  Api Config values
        /// </summary>
        private readonly ApiSettings _apiSettings;

        /// <summary>
        ///  Auth Config values
        /// </summary>
        private readonly AuthSettings _authSettings;

        public ConfigurationController(
            IConfiguration configuration,
            IOptions<AuthSettings> authSettings,
            IOptions<ApiSettings> apiSettings)
        {
            _configuration = configuration;
            _apiSettings = apiSettings.Value;
            _authSettings = authSettings.Value;
        }

        // todo AuthSettings class unable to map configuration section
        /// <summary>
        /// Get Authentication Config
        /// </summary>
        [HttpGet("AuthSettings")]
        [ProducesResponseType(typeof(AuthSettings), 200)]
        public IActionResult GetAuthSettings()
        {
            return Ok(_authSettings);
        }

        /// <summary>
        /// Get Api Documentation Config
        /// </summary>
        [HttpGet("ApiSettings")]
        [ProducesResponseType(typeof(ApiSettings), 200)]
        public IActionResult GetApiSettings()
        {
            return Ok(_apiSettings);
        }


    }
}
