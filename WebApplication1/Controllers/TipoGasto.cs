using Dominio;
using Microsoft.AspNetCore.Mvc;


public class TipoGastoController : Controller
{
    
    private Sistema sistema = Sistema.ObtenerInstancia();
    // GET
    public IActionResult CrearTipoGasto()
    {
        ViewBag.Tipos = sistema.TiposGasto;
        return View();
    }
    
    //POST
    [HttpPost]
    public IActionResult CrearTipoGasto(string nombre, string descripcion ){
        
        TipoGasto tg = new TipoGasto(nombre, descripcion);
       

        sistema.AltaTipoGasto(tg);
        ViewBag.Tipos = sistema.TiposGasto;
        ViewBag.Mensaje = "Tipo de gasto creado correctamente.";

        return View();

    }
}