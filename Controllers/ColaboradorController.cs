using Microsoft.AspNetCore.Mvc;
using Usuario.Models;
using System.Collections.Generic; 

namespace FolhaPagamento.Controllers
{
    [Route("api/colaborador")]
    [ApiController]

    public class ColaboradorController : ControllerBase 
    {
        private static List<Colaborador> colaboradores = new Lis<Colaborador>(); 
        //GET: api/colaborador/listar

        [HttpGet]
        [Route("listar")]
        public IActionResult Listar()
        {
            return Ok(colaboradores);
        }
        
        //POST: /api/usuario/cadastrar
        [HttpPost]
        [Route("cadastrar")]

        public IActionResult Cadastrar(
            [FromBody]Colaborador colaborador)
            {
                colaboradores.Add(colaborador); 
                return Created("", colaborador); 
            }
    // buscar
        [HttpGet]
        [Route("buscar/{cpf}")]
        public IActionResult Buscar([FromRoute] string cpf)
        {
            for (int i = 0; i < colaborador.Count; i++)
            {
                if(colaborador[i].cpf.Equals(cpf))
                {
                    return Ok(colaborador[i]);
                }
            }
            return NotFound();
        }

      
    }
}
