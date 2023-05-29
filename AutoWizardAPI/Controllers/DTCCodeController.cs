using AutoWizard.Model;
using AutoWizard.Services;
using AutoWizardAPI.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoWizardAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DTCCodeController : ControllerBase
    {
        private readonly DTCService _dTCService;

        public DTCCodeController(DTCService dTCService)
        {
            _dTCService = dTCService;
        }

        [HttpGet]
        public IActionResult GetCode()
        {
            try
            {
                List<DTCCode> code = _dTCService.GetAll();

                if (code == null || code.Count == 0)
                {
                    return NotFound();
                }

                return Ok(code);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{code}")]
        public IActionResult GetByCode(string code)
        {
            try
            {
                var result = _dTCService.GetByCode(code);

                if (result == null)
                {
                    return NotFound("DTC code not found.");
                }

                return Ok(result);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
    }
}
