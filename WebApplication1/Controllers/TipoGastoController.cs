using Dominio;
using Microsoft.AspNetCore.Mvc;


public class TipoGastoController : Controller
{
    
    private Sistema sistema = Sistema.ObtenerInstancia();
    // GET
    public IActionResult CrearTipoGasto()
    {
        string? rol = HttpContext.Session.GetString("rol");
        if (rol != "Gerente")
            return RedirectToAction("Error", "NoPermitido");
        ViewBag.Tipos = sistema.TiposGasto;
        return View();
    }
    
    //POST
    [HttpPost]
    public IActionResult CrearTipoGasto(string nombre, string descripcion ){

        try
        {
            if (HttpContext.Session.GetString("rol") != "Gerente")
                return RedirectToAction("Index", "Home");
            TipoGasto tg = new TipoGasto(nombre, descripcion);


            sistema.AltaTipoGasto(tg);
            ViewBag.Tipos = sistema.TiposGasto;
            ViewBag.Mensaje = "Tipo de gasto creado correctamente.";

            return View();
        }
        catch (Exception ex)
        {
            TempData["Mensaje"] = ex.Message;
            return RedirectToAction("Index", "Home");
        }
       

    }
}