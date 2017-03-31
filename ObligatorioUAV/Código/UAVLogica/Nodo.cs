using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

namespace UAVLogica
{
    public abstract class Nodo:ObjPersistente
    {
        //private static Nodo instance;
        public string marca { get; set; }
        public string modelo { get; set; }

        public Nodo()
        {
            marca = "";
            modelo = "";
        }
        public Nodo(string marcaP, string modeloP)
        {
            marca = marcaP;
            modelo = modeloP;
        }
        public virtual void AgregarHijo(Nodo n) { 
        }
        public virtual void EliminarHijo(Nodo n) { 
        }

        public virtual bool VerificarAlarma(Nodo n)
        {
            return false;
        }
        public virtual bool VerificarAlarmaUrgente(Nodo n)
        {
            return false;
        }
        
    }
}
