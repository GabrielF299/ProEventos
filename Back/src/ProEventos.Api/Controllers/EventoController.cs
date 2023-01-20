using Microsoft.AspNetCore.Mvc;
using ProEventos.Api.Models;


namespace ProEventos.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
        public IEnumerable<Evento> _evento = new Evento[]{
        new Evento(){
            EventoId = 1,
            Tema= "Angular 11 e .NET 6",
            Local = "Belo Horizonte",
            Lote = "1º Lote",
            QtdPessoas = 250,
            DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
            ImagemUrl = "foto.png"
        },
        new Evento(){
            EventoId = 2,
            Tema= "Angular e suas novidades",
            Local = "São paulo",
            Lote = "2º Lote",
            QtdPessoas = 350,
            DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
            ImagemUrl = "foto1.png"
        }
    };

    public EventoController()
    {
    }   

    [HttpGet(Name = "GetEvento")]
    public IEnumerable<Evento> Get()
    {
        return _evento;
    }

    [HttpGet("{id}")]
    public IEnumerable<Evento> GetById(int id)
    {
        return _evento.Where(evento => evento.EventoId == id);
    }

    [HttpPost(Name = "PostEvento")]
    public string Post()
    {
        return "Exemplo de post";
    }

    [HttpPut("{id}", Name="PutEvento")]
    public string Put(int id)
    {
        return $"Exemplo de Put = {id}";
    }

    [HttpDelete("{id}", Name = "DeleteEvento")]
    public string Delete(int id)
    {
        return $"Exemplo de Delete = {id}";
    }
}
