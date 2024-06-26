// Controllers/DigimonController.cs
using Microsoft.AspNetCore.Mvc;
using System;


[ApiController]
public class DigimonController : Controller
{
    private readonly DigimonService _digimonService;

    public DigimonController(DigimonService digimonService)
    {
        _digimonService = digimonService;
    }

    [HttpGet("sortear")]
    public ActionResult<DigimonService> SortearDigimon()
    {
        try
        {
            var digimonSorteado = _digimonService.SortearDigimon();
            return Ok(digimonSorteado);
        }
        catch (Exception ex)
        {
            // Aqui você pode lidar com exceções se necessário
            return StatusCode(500, $"Erro interno: {ex.Message}");
        }
    }
}