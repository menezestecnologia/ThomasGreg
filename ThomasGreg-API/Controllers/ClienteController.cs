using Microsoft.AspNetCore.Mvc;
using ThomasGreg_Domain.Entities;
using ThomasGreg_Domain.Services;

namespace ThomasGreg_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController(ILogger<ClienteController> logger, IClienteService clienteService) : ControllerBase
    {
        private readonly ILogger<ClienteController> _logger = logger;
        private readonly IClienteService _clienteService = clienteService;

        [HttpGet()]
        [Route("{id}")]
        public IActionResult Obter([FromRoute]int id)
        {
            try
            {
                return Ok(_clienteService.Obter(id));
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
                var clientes = _clienteService.ObterTodos();

                return Ok(clientes);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro no método Obter");
                return StatusCode(500);
            }
        }

        [HttpPost()]
        public IActionResult Adicionar([FromBody] Cliente cliente)
        {
            try
            {
                if (_clienteService.Obter(cliente.Email) is not null)
                    return BadRequest();

                _clienteService.Adicionar(cliente);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro no método Adicionar");
                return StatusCode(500);
            }
        }

        [HttpPut()]
        public IActionResult Atualizar([FromBody] Cliente cliente)
        {
            try
            {
                _clienteService.Atualizar(cliente);

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
                _clienteService.Remover(id);

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
