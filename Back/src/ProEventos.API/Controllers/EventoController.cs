using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;
namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public IEnumerable<Evento> _evento = new Evento[]
            {
                new Evento()  {
                Id = 1,
                Tema = "Angular 11 e .NET 5",
                Local = "SP",
                DataEvento = DateTime.Now.ToString("dd/MM/yyyy"),
                QtdPessoas = 250,
                Lote = "Lote 1",
                ImagemURL = "https://example.com/image.jpg"
                },
                new Evento()  {
                Id = 2,
                Tema = "2",
                Local = "SP a",
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                QtdPessoas = 350,
                Lote = "Lote 1",
                ImagemURL = "https://example.com/image.jpg"
                }
            };

        public EventoController()
        {
        }
// rota que retorna todos os eventos
        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

// rota que filtra por ID
        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.Id == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Hello, World!";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return "Exemplo com id = " + id;
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return "Exemplo com id = " + id;
        }
    }
}
