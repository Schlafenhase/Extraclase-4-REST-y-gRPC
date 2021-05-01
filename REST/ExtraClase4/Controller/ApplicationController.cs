using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExtraClase4.Controller
{
    [Route("Api/Application")]//Ruta principal de la aplicacion, controller se lee como el nombre del documento, en este caso Application.
    public class ApplicationController : ControllerBase
    {
        [Route("file")]
        [HttpGet]
        public string GetText()
        {
            return System.IO.File.ReadAllText("C:/Users/Jesus/Documents/Semestre 1-2021/SOAD/Extraclase-4-REST-y-gRPC/REST/texto.txt");
        }
    }
}
