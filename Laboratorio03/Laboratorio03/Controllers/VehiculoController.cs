using Laboratorio03.Models;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorio03.Controllers
{
    [Route("[controller]")]
    public class VehiculoController : Controller
    {
        List<Vehiculo> vList = new List<Vehiculo>();
        [Route("SubirArchivo")]
        public IActionResult SubirArchivo()
        {
            return View();
        }

        [HttpPost("SubirArchivo")]
        public IActionResult SubirArchivo(IFormFile file)
        {
            if (file != null)
            {
                try
                {
                    bool firstLine = true;
                    string ruta = Path.Combine(Path.GetTempPath(), file.Name);
                    using (var stream = new FileStream(ruta, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                    string allFileData = System.IO.File.ReadAllText(ruta);
                    foreach (string lineaActual in allFileData.Split('\n'))
                    {
                        if (firstLine == true)
                        {
                            firstLine = false;
                            continue;
                        }
                        else if (!string.IsNullOrEmpty(lineaActual))
                        {
                            string[] informacion = lineaActual.Split(',');
                            vList.Add(new Vehiculo()
                            {
                                Id = informacion[0],
                                Email = informacion[1],
                                Propietario = informacion[2],
                                Color = informacion[3],
                                Marca = informacion[4],
                                Serie = informacion[5]
                            });
                        }
                    }
                }
                catch (Exception e)
                {
                    ViewBag.Error = e.Message;
                }
            }
            return View(vList);
        }
    }
}
