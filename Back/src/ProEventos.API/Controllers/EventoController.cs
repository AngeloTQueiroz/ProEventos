using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;
namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

 

        public readonly DataContext _context;

        public EventoController(DataContext context)
        {
            _context = context;
        }
// rota que retorna todos os eventos
        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;
        }

// rota que filtra por ID
        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _context.Eventos.Where(evento => evento.Id == id);
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
