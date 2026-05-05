using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CadastroClientes.Models;

namespace CadastroClientes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        [HttpPost("Salvar")]
        public object Salvar([FromBody] Clientes cadastro)
        {
            try
            {
              
            }
            catch (Exception ex)
            {
              
            }
            return null;
        }
    }
}