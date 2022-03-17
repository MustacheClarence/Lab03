namespace Laboratorio03.Models
{
    public class AVL
    {
        NodoAVL raiz;
        public AVL()
        {
            this.raiz = null;
        }

        //Busqueda
        public NodoAVL BuscarID(string id, NodoAVL r)
        {
            if (raiz == null)
            {
                return null;
            }
            else if (r.vehiculo.Id == id)
            {
                return r;
            }
            else if (string.Compare(r.vehiculo.Id, id) < 0)
            {
                return BuscarID(id, r.subAVLDer);
            }
            else if (string.Compare(r.vehiculo.Id, id) > 0)
            {
                return BuscarID(id, r.subAVLIzq);
            }else
            {
                return null;
            }

        }
        //Obtener factor de equilibrio
        int FE(NodoAVL arbol)
        {
            if (arbol == null)
            {
                return -1;
            }
            else
            {
                return arbol.FactorEquilibrio;
            }
        }
        //Rotaciones simples
        NodoAVL rotIzq(NodoAVL arbol)
        {
            NodoAVL aux = arbol.subAVLIzq;
            arbol.subAVLIzq = aux.subAVLDer;
            aux.subAVLDer = arbol;
            arbol.FactorEquilibrio = Math.Max(FE(arbol.subAVLIzq), FE(arbol.subAVLDer)) + 1;
            aux.FactorEquilibrio = Math.Max(FE(aux.subAVLIzq), FE(aux.subAVLDer)) + 1;
            return aux;
        }
        NodoAVL rotDer(NodoAVL arbol)
        {
            NodoAVL aux = arbol.subAVLDer;
            arbol.subAVLDer = aux.subAVLIzq;
            aux.subAVLIzq = arbol;
            arbol.FactorEquilibrio = Math.Max(FE(arbol.subAVLIzq), FE(arbol.subAVLDer)) + 1;
            aux.FactorEquilibrio = Math.Max(FE(aux.subAVLIzq), FE(aux.subAVLDer)) + 1;
            return aux;
        }
        // Rotaciones dobles
        NodoAVL DrotIzq(NodoAVL arbol)
        {
            NodoAVL aux;
            arbol.subAVLIzq = rotDer(arbol.subAVLIzq);
            aux = rotIzq(arbol);
            return aux;
        }
        NodoAVL DrotDer(NodoAVL arbol)
        {
            NodoAVL aux;
            arbol.subAVLDer = rotIzq(arbol.subAVLDer);
            aux = rotDer(arbol);
            return aux;
        }

        //insertar segun el orden
        public void Insertar(Vehiculo nuevo)
        {
            NodoAVL nuevoArbol = new NodoAVL(nuevo);
            if(raiz == null)
            {
                raiz = nuevoArbol;
            }
            else
            {
                raiz = InsertarID(nuevoArbol, raiz);
            }
        }
        NodoAVL InsertarID(NodoAVL nuevo, NodoAVL subArbol)
        {
            //nuevo = nuevo dato a ingresar
            //subArbol = raiz actual del AVL
            //nuevoPadre = raiz del AVL despues de las rotaciones

            NodoAVL nuevoPadre = subArbol;
            // si es menor
            if (string.Compare(nuevo.vehiculo.Id, subArbol.vehiculo.Id) < 0)
            {
                // si la raiz no tiene hijo izquiedo, se asigna en esa posicion
                if (subArbol.subAVLIzq == null)
                {
                    subArbol.subAVLIzq = nuevo;
                }
                // si se tiene un hijo izquierdo se utiliza la recursion para revisar los hijos del subArbol izquierdo
                else
                {
                    subArbol.subAVLIzq = InsertarID(nuevo, subArbol.subAVLIzq);
                    //Si el arbol entra en un desbalance, se utilizan rotaciones
                    if ((FE(subArbol.subAVLIzq) - FE(subArbol.subAVLDer) == 2))
                    {
                        if (string.Compare(nuevo.vehiculo.Id, subArbol.subAVLIzq.vehiculo.Id) < 0)
                        {
                            nuevoPadre = rotIzq(subArbol);
                        }
                        else
                        {
                            nuevoPadre = DrotIzq(subArbol);
                        }
                    }
                }
            }
            //si es mayor
            else if (string.Compare(nuevo.vehiculo.Id, subArbol.vehiculo.Id) >= 0)
            {
                // si la raiz no tiene hijo derecho, se asigna en esa posicion
                if (subArbol.subAVLDer == null)
                {
                    subArbol.subAVLDer = nuevo;
                }
                else
                {
                    // si se tiene un hijo derecho se utiliza la recursion para revisar los hijos del subArbol derecho
                    subArbol.subAVLDer = InsertarID(nuevo, subArbol.subAVLDer);
                    //Si el arbol entra en un desbalance, se utilizan rotaciones
                    if ((FE(subArbol.subAVLDer) - FE(subArbol.subAVLIzq) == 2))
                    {
                        if (string.Compare(nuevo.vehiculo.Id, subArbol.subAVLDer.vehiculo.Id) >= 0)
                        {
                            nuevoPadre = rotDer(subArbol);
                        }
                        else
                        {
                            nuevoPadre = DrotDer(subArbol);
                        }
                    }
                }
            }
            if((subArbol.subAVLIzq == null) && (subArbol.subAVLDer != null))
            {
                subArbol.FactorEquilibrio = subArbol.subAVLDer.FactorEquilibrio + 1;
            }
            else if((subArbol.subAVLDer == null) && (subArbol.subAVLIzq != null))
            {
                subArbol.FactorEquilibrio = subArbol.subAVLIzq.FactorEquilibrio + 1;
            }
            else
            {
                subArbol.FactorEquilibrio = Math.Max(FE(subArbol.subAVLIzq), FE(subArbol.subAVLDer)) + 1;
            }
            return nuevoPadre;

        }
        
    }

    
}
