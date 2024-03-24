using Microsoft.AspNetCore.Mvc;
using ThomasGreg_Domain.Entities;
using ThomasGreg_Domain.Services;

namespace ThomasGreg_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LogradouroController(ILogger<LogradouroController> logger, ILogradouroService logradouroService) : ControllerBase
    {
        private readonly ILogger<LogradouroController> _logger = logger;
        private readonly ILogradouroService _logradouroService = logradouroService;

        [HttpGet()]
        [Route("{id}")]
        public IActionResult Obter([FromRoute]int id)
        {
            try
            {
                return Ok(_logradouroService.Obter(id));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro no método Obter");
                return StatusCode(500);
            }
        }

        [HttpGet()]
        [Route("")]
        public IActionResult ObterTodos()
        {
            try
            {
                var clientes = _logradouroService.ObterTodos();

                return Ok(clientes);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro no método Obter");
                return StatusCode(500);
            }
        }

        [HttpPost()]
        public IActionResult Adicionar([FromBody] Logradouro logradouro)
        {
            try
            {
                _logradouroService.Adicionar(logradouro);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro no método Adicionar");
                return StatusCode(500);
            }
        }

        [HttpPut()]
        public IActionResult Atualizar([FromBody] Logradouro logradouro)
        {
            try
            {
                _logradouroService.Atualizar(logradouro);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro no método Atualizar");
                return StatusCode(500);
            }
        }

        [HttpDelete()]
        [Route("{id}")]
        public IActionResult Remover([FromRoute] int id)
        {
            try
            {
                _logradouroService.Remover(id);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro no método Remover");
                return StatusCode(500);
            }
        }
    }
}
