using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2._2_Renny_
{
    public class Producto
    {
       private string _nombre = "Laptop";
       private decimal _precio;
       private int _cantidaddisponible;
       private decimal _costototal;
       

        public Producto()
        {
            _nombre = "Laptop";
            _precio = 0;
            _cantidaddisponible = 0;
            _costototal = 0;

        }
        
        public Producto(string nombre, decimal precio, int cantidadisponible, decimal costototal)
        {
            _nombre = nombre ;
            _precio = precio;
            _cantidaddisponible = cantidadisponible;
            _costototal = costototal;
        }


        public string Nombre {
            get => _nombre;
            set => _nombre = value;
        }
        public double Precio { 
            get => _precio; 
            set => _precio = value;
        }
        public int CantidadDisponible {
            get => _cantidaddisponible;
            set => _cantidaddisponible = value;
        }
        public int Costototal{
            get => _costototal;
            set => _costototal = value;
        }



        public override string ToString()
        {
            return $"{Nombre}/{Precio}/{CantidadDisponible, 2:00}/{Costototal, 2,00}";
        }
        public decimal _costo_total( decimal _precio, int _cantidaddisponible)
        {
            _costototal = _precio * _cantidaddisponible;
            return _costototal;
        }
    }
}
