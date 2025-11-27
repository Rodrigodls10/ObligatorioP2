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
            return RedirectToAction("NoPermitido", "Error");
        ViewBag.Tipos = sistema.TiposGasto;
        return View();
    }
    
    //POST
    [HttpPost]
    public IActionResult CrearTipoGasto(string nombre, string descripcion ){

        try
        {
            if (HttpContext.Session.GetString("rol") != "Gerente")
                return RedirectToAction("NoPermitido", "Error");
            TipoGasto tg = new TipoGasto(nombre, descripcion);


            sistema.AltaTipoGasto(tg);
            TempData["Mensaje"] = "Tipo de gasto creado correctamente.";


        }
        catch (Exception ex)
        {
            TempData["Error"] = ex.Message;
        }
       return RedirectToAction("CrearTipoGasto");

    }
    //Eliminar tipo de Gasto

    [HttpPost]
    public IActionResult EliminarTipoGasto(string nombreTipoGasto)
    {
        try
        {
            sistema.EliminarTipoDeGasto(nombreTipoGasto);
            TempData["Mensaje"] = "El tipo de gasto fue eliminado correctamente"; 

        }
        catch (Exception e)
        {
            TempData["Error"] = e.Message;
        } 
        
        return RedirectToAction("CrearTipoGasto");
    }
}
