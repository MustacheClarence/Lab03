using Laboratorio03.Models;
namespace Laboratorio03.Models
{
    public class Busqueda
    {
        static Vehiculo ID(string id, ABB arbol)
        {
            
            if(id != null)
            {
                if(string.Compare(id,arbol.vehiculo.Id) == 0)
                {
                    return arbol.vehiculo;
                }
                if (string.Compare(id, arbol.vehiculo.Id) < 0)
                {
                    return ID(id, arbol.subABBIzq);
                }
                if (string.Compare(id, arbol.vehiculo.Id) > 0)
                {
                    return ID(id, arbol.subABBDer);
                }
            }
            return null;
        }
        static Vehiculo Serie(string serie, ABB arbol)
        {

            if (serie != null)
            {
                if (string.Compare(serie, arbol.vehiculo.Serie) == 0)
                {
                    return arbol.vehiculo;
                }
                if (string.Compare(serie, arbol.vehiculo.Serie) < 0)
                {
                    return Serie(serie, arbol.subABBIzq);
                }          
                if (string.Compare(serie, arbol.vehiculo.Serie) > 0)
                {          
                    return Serie(serie, arbol.subABBDer);
                }
            }
            return null;
        }
        static Vehiculo Email(string id, ABB arbol)
        {

            if (id != null)
            {
                if (string.Compare(id, arbol.vehiculo.Email) == 0)
                {
                    return arbol.vehiculo;
                }
                if (string.Compare(id, arbol.vehiculo.Email) < 0)
                {
                    return Email(id, arbol.subABBIzq);
                }
                if (string.Compare(id, arbol.vehiculo.Email) > 0)
                {
                    return Email(id, arbol.subABBDer);
                }
            }
            return null;
        }
    }
}
