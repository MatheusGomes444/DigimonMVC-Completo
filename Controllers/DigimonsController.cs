using Microsoft.AspNetCore.Mvc;
using DigimonMvc.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digimon.Controllers
{
   public class DigimonsController : Controller
{
    public string uriBase = "";
    public ActionResult Index()
    {
        // Simulação de dados estáticos
        var digimons = new List<ClasseDigimon>
        {
            new ClasseDigimon { Nome = "Agumon", Tipo = "Reptile", Nivel = 3, ImagemUrl = "agumon.jpg" },
            new ClasseDigimon { Nome = "Gabumon", Tipo = "Reptile", Nivel = 4, ImagemUrl = "gabumon.jpg" },
            new ClasseDigimon { Nome = "Patamon", Tipo = "Mammal", Nivel = 2, ImagemUrl = "patamon.jpg" }
            // Adicione mais Digimons conforme necessário
        };

        return View(digimons);
    }
}
}