using Laboratorio03.Models;
namespace Laboratorio03.Models
{
    public class ABB
    {
        // raiz 
        Vehiculo vehiculo;
        bool vacio;
        ABB subABBIzq;
        ABB subABBDer;

        internal ABB()
        {
            this.vehiculo = null;
            this.vacio = false;
            this.subABBIzq = null;
            this.subABBDer = null;
        }
        internal ABB(Vehiculo v)
        {
            this.vehiculo = v;
            this.vacio = true;
            this.subABBIzq = null;
            this.subABBDer = null;
        }
    }
}
