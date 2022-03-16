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

        void OrdenarDpi(Vehiculo v)
        {
            ABB hijo = new ABB(v);
            if (v != null)
            {
                if (string.Compare(v.Id, vehiculo.Id) < 0)
                {
                    subABBIzq = hijo;
                }
                if (string.Compare(v.Id, vehiculo.Id) >= 0)
                {
                    subABBDer = hijo;
                }
            }
        }
        void OrdenarSerie(Vehiculo v)
        {
            ABB hijo = new ABB(v);
            if (v != null)
            {
                if (string.Compare(v.Serie, vehiculo.Serie) < 0)
                {
                    subABBIzq = hijo;
                }
                if (string.Compare(v.Serie, vehiculo.Serie) >= 0)
                {
                    subABBDer = hijo;
                }
            }
        }
        void OrdenarEmail(Vehiculo v)
        {
            ABB hijo = new ABB(v);
            if (v != null)
            {
                if (string.Compare(v.Email, vehiculo.Email) < 0)
                {
                    subABBIzq = hijo;
                }
                if (string.Compare(v.Email, vehiculo.Email) >= 0)
                {
                    subABBDer = hijo;
                }
            }
        }
    }
}
