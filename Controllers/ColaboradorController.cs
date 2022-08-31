using Microsoft.AspNetCore.Mvc;
using API.Models;
using System.Collections.Generic; 

namespace FolhaPagamento.Controllers
{
    [ApiController]
    [Route("api/colaborador")]

    public class ColaboradorController : ControllerBase 
    {
        //private static List<Usuario> usuario = new Lis<Usuario>(); 
        
        [HttpPost]
        [Route("cadastrar")]

        public IActionResult Cadastrar(
            [FromBody]Colaboradores colaborador)
            {
                Colaboradores.Add(colaborador); 
                return Created("", colaborador); 
            }

        //cpf
        [HttpPost]
        [Route("cpf")]

        public IActionResult CPF(
            [FromBody] CPF cpf)
            {
                cpf.Add(CPF); 
                return Created("", cpf); 
            }


      
    }
}