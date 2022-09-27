using Assably3.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Assably3.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("/kelvin")] 
        public IEnumerable<WeatherForecast>Kelvin()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55) + 273,
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }


        [HttpGet("/kelvin/{numero}")] //entre llaves es un argumento
        public string Kelvin(long numero)
        {

            return "Tu numero de la suerte es: " + numero;

        }

        [HttpGet("/kelvin/{numero}/{coco}")] //entre llaves es un argumento
        public string Kelvin(long numero, string coco)
        {

            return "Tu numero de la suerte es: " + numero + " Cocoritter: " + coco;

        }

        [HttpGet("/op/{numeroA}/{numeroB}/{ope}")]
        public Operacion Operaciones(int numeroA, int numeroB, string ope)
        {

            float resultado = 0;
            switch (ope)
            {

                case "suma":
                    resultado = numeroA + numeroB;
                    break;
                case "resta":
                    resultado = numeroA - numeroB;
                    break;
                case "div":
                    resultado = numeroA / numeroB;
                    break;
                case "mult":
                    resultado = numeroA * numeroB;
                    break;

            }         

            return new Operacion(numeroA, numeroB, resultado);
        }

        [HttpPost("/op")]
        public Operacion OperacionesPost(Operacion operacion2)
        {

            switch (operacion2.OperacionAritmetica)
            {

                case "suma":
                   operacion2.Resultado = operacion2.NumeroA + operacion2.NumeroB;
                    break;
                case "resta":
                    operacion2.Resultado = operacion2.NumeroA - operacion2.NumeroB;
                    break;
                case "div":
                    operacion2.Resultado = operacion2.NumeroA / operacion2.NumeroB;
                    break;
                case "mult":
                    operacion2.Resultado = operacion2.NumeroA * operacion2.NumeroB;
                    break;

            }

            return operacion2;
        }




    }
}
