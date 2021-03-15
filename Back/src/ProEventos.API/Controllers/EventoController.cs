﻿using System;
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
       public IEnumerable<Evento> _evento => new Evento[] {
                new Evento() {
                    EventoID = 1,
                Tema = "Angular 11 e dotnet 5",
                Local = " Sorocaba ",
                Lote = "1º lote",
                QtdePess = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemURL = "foto.png"
                },

                new Evento() {
                    EventoID = 2,
                Tema = "Angular e suas novidades",
                Local = " Campinas ",
                Lote = "2º lote",
                QtdePess = 230,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemURL = "foto.png"
                }
            };
        public EventoController()
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }
         [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoID == id );
        }


    }
}
