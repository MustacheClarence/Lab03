using Laboratorio03.Models;
namespace Laboratorio03.Models
{
    public class NodoAVL
    {
        public Vehiculo vehiculo;
        public NodoAVL subAVLIzq;
        public NodoAVL subAVLDer;
        public int FactorEquilibrio;

        public NodoAVL(Vehiculo v)
        {
            this.vehiculo = v;
            this.subAVLIzq = null;
            this.subAVLDer = null;
            this.FactorEquilibrio = 0;
        }
    }
}
