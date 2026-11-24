using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frogger.Jugador_y_usuario
{
    internal class Usuario
    {
       
        public string Nombre { get; set; }
        public int HighScore { get; set; }        // Mejor puntaje conseguido
        public int Saltos { get; set; }           // Cantidad total de saltos dados
        public int CarrilesPasados { get; set; }  // Carriles de la carretera que cruzó
        public int Muertes { get; set; }          // Veces que lo atropellaron
        public int TiempoJugado { get; set; }     // Tiempo total jugado, en segundos

        // Constructor: crea un usuario nuevo con todo en cero
        public Usuario(string nombre)
        {
            Nombre = nombre;
            HighScore = 0;
            Saltos = 0;
            CarrilesPasados = 0;
            Muertes = 0;
            TiempoJugado = 0;
        }
    }
}
