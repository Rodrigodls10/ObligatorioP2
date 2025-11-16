using Dominio;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

public class LoginController : Controller
{
    private Sistema sistema = Sistema.ObtenerInstancia();
    // GET
    public IActionResult Autenticar()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Autenticar(string email, string password)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                ViewBag.Error = "Debe ingresar email y contraseña.";
                return View();
            }

            Usuario elU = Sistema.ObtenerInstancia().AutenticarUsuario(email, password);

            HttpContext.Session.SetString("email", elU.Email ?? "");
            HttpContext.Session.SetString("nombre", elU.Nombre ?? "");
            HttpContext.Session.SetString("rol", elU.Rol());

            // después deciden adónde redirigir (según rol, por ejemplo)
            // if (elU.Rol() == "Gerente") ...
            // else ...
            return RedirectToAction("Index", "Home");
        }
        catch (Exception ex)
        {
            ViewBag.Error = ex.Message;
            return View();
        }
    }


    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index", "Home");
    }
}