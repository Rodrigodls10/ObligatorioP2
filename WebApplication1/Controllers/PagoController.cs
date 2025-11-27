using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Dominio;

namespace WebApplication1.Controllers
{
    public class PagoController : Controller
    {
        private Sistema sistema = Sistema.ObtenerInstancia();


        public IActionResult MisPagos()
        {

            string? email = HttpContext.Session.GetString("email");
            if (email == null || email == "")
            {

                return RedirectToAction("Autenticar", "Login");
            }


            DateTime hoy = DateTime.Today;
            int mes = hoy.Month;
            int anio = hoy.Year;


            List<Pago> pagos = sistema.ListarPagosUsuarioMes(email, mes, anio);


            return View(pagos);
        }

        public IActionResult Cargar()
        {
            string email = HttpContext.Session.GetString("email");
            if (string.IsNullOrEmpty(email))
            {
                return RedirectToAction("Autenticar", "Login");
            }

            return View();
        }

        public IActionResult CrearUnico()
        {
            string email = HttpContext.Session.GetString("email");
            if (string.IsNullOrEmpty(email))
            {
                return RedirectToAction("Autenticar", "Login");
            }

            ViewBag.TiposGasto = sistema.TiposGasto;
            ViewBag.MetodosPago = Enum.GetValues(typeof(MetodoPago));

            return View();
        }

        [HttpPost]
        public IActionResult CrearUnico(string nombreTipoGasto, MetodoPago metodoPago, string descripcion, DateTime? fechaPago, string nroRecibo, double monto)
        {
            string email = HttpContext.Session.GetString("email");
            if (string.IsNullOrEmpty(email))
            {
                return RedirectToAction("Autenticar", "Login");
            }

            Usuario usuarioActual = sistema.BuscarUsuarioPorEmail(email);

            // Recargamos combos si hay error
            ViewBag.TiposGasto = sistema.TiposGasto;
            ViewBag.MetodosPago = Enum.GetValues(typeof(MetodoPago));

            try
            {

                if (!fechaPago.HasValue)
                    throw new Exception("Debe ingresar una fecha de pago.");

                if (string.IsNullOrWhiteSpace(nroRecibo))
                    throw new Exception("Debe ingresar un número de recibo.");

                TipoGasto tg = sistema.BuscarTipoGastoPorNombre(nombreTipoGasto);
                if (tg == null)
                    throw new Exception("Debe seleccionar un tipo de gasto válido.");

                if (monto <= 0)
                    throw new Exception("El monto debe ser mayor a cero.");

                // Creamos el objeto 
                PagoUnico nuevo = new PagoUnico(metodoPago, tg, usuarioActual, descripcion, fechaPago.Value, nroRecibo, monto);

                sistema.CrearPago(nuevo);

                TempData["Mensaje"] = "Pago único registrado correctamente.";
                return RedirectToAction("Cargar");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }

        public IActionResult CrearRecurrente()
        {
            string email = HttpContext.Session.GetString("email");
            if (string.IsNullOrEmpty(email))
            {
                return RedirectToAction("Autenticar", "Login");
            }

            ViewBag.TiposGasto = sistema.TiposGasto;
            ViewBag.MetodosPago = Enum.GetValues(typeof(MetodoPago));

            return View();
        }

        [HttpPost]
        public IActionResult CrearRecurrente(string nombreTipoGasto, MetodoPago metodoPago, string descripcion, DateTime? fechaDesde, DateTime? fechaHasta, bool tieneLimite, double monto)
        {
            string email = HttpContext.Session.GetString("email");
            if (string.IsNullOrEmpty(email))
            {
                return RedirectToAction("Autenticar", "Login");
            }

            Usuario usuarioActual = sistema.BuscarUsuarioPorEmail(email);

            ViewBag.TiposGasto = sistema.TiposGasto;
            ViewBag.MetodosPago = Enum.GetValues(typeof(MetodoPago));

            try
            {
                if (!fechaDesde.HasValue)
                    throw new Exception("Debe ingresar la fecha de inicio.");

                if (tieneLimite && !fechaHasta.HasValue)
                    throw new Exception("Debe ingresar la fecha de fin si tiene límite.");

                TipoGasto tg = sistema.BuscarTipoGastoPorNombre(nombreTipoGasto);
                if (tg == null)
                    throw new Exception("Debe seleccionar un tipo de gasto válido.");

                if (monto <= 0)
                    throw new Exception("El monto debe ser mayor a cero.");

                // Definir fechaHasta si no tiene limite
                DateTime fin = fechaHasta ?? fechaDesde.Value.AddYears(5);

                // Creamos el objeto 
                PagoRecurrente nuevo = new PagoRecurrente(metodoPago, tg, usuarioActual, descripcion, fechaDesde.Value, fin, tieneLimite, monto);

                sistema.CrearPago(nuevo);

                TempData["Mensaje"] = "Pago recurrente registrado correctamente.";
                return RedirectToAction("Cargar");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }


        }

        public IActionResult PagosEquipo()
        {
            string email = HttpContext.Session.GetString("email");
            if (string.IsNullOrEmpty(email))
            {
                return RedirectToAction("Autenticar", "Login");
            }

            DateTime hoy = DateTime.Today;
            int mes = hoy.Month;
            int anio = hoy.Year;

            List<Pago> pagos = new List<Pago>();

            try
            {
                pagos = sistema.FiltrarPagosEquipo(email, mes, anio);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
            }

            ViewBag.Mes = mes;
            ViewBag.Anio = anio;

            return View(pagos);
        }

        [HttpPost]
        public IActionResult PagosEquipo(int mes, int anio)
        {
            string email = HttpContext.Session.GetString("email");
            if (string.IsNullOrEmpty(email))
            {
                return RedirectToAction("Autenticar", "Login");
            }

            List<Pago> pagos = new List<Pago>();

            try
            {
                pagos = sistema.FiltrarPagosEquipo(email, mes, anio);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
            }

            ViewBag.Mes = mes;
            ViewBag.Anio = anio;

            return View(pagos);
        }
    }
}
    


