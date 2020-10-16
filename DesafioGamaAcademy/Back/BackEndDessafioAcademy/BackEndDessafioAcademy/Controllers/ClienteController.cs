using BackEndDessafioAcademy.Models;
using BackEndDessafioAcademy.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BackEndDessafioAcademy.Controllers
{
    [Route("/Cliente")]
    [ApiController]
    public class ClienteController : ControllerBase
    {

        [HttpGet]
        public string Get()
        {
            return "OK";
        }

        [HttpPost]
        //[Route("/")]
        public string Create([FromBody] Cliente cliente)
        {
            try
            {
                new Service().CadastrarCliente(cliente);

                return "Cadastro efetuado com sucesso.";
            }
            catch (Exception exception)
            {
                return $"Error: {exception.Message}";
            }
        }
    }
}
