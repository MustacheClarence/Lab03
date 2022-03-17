using Laboratorio03.Models;
namespace Laboratorio03.Models
{
    public class ABB
    {
        // raiz 
        public Vehiculo vehiculo;
        public bool vacio;
        public ABB subABBIzq;
        public ABB subABBDer;
       
        internal ABB(Vehiculo v)
        {
            this.vehiculo = v;
            this.vacio = true;
            this.subABBIzq = null;
            this.subABBDer = null;
        }

        // a la hora de insertar se escoge al ordenamiento que se desee
        // ordenamiento = insertar
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
        //Busqueda
        Vehiculo ID(string id, ABB arbol)
        {

            if (arbol != null)
            {
                if (id != null)
                {
                    if (string.Compare(id, arbol.vehiculo.Id) == 0)
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
            return null;
        }
        Vehiculo Serie(string serie, ABB arbol)
        {

            if (arbol != null)
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
            return null;
        }
        Vehiculo Email(string id, ABB arbol)
        {
            if (arbol != null)
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
            return null;
        }
    }
}
