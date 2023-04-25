using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer_parcial_solid_transporte
{
    public class Tren : ITransporte
    {
        private string nombre;
        private int velocidadActual;
        private int velocidadMaxima;


        public Tren (string nombre, int velocidadActual, int velocidadMaxima)
        {
            this.nombre = nombre;
            this.velocidadActual = velocidadActual;
            this.velocidadMaxima = velocidadMaxima;
        }
        public void Acelerar(int velocidad)
        {
            if ((this.velocidadActual + velocidad) <= this.velocidadMaxima)
            {
                this.velocidadActual += velocidad;
            }
        }

        public void Desacelerar(int velocidad)
        {
            if ((this.velocidadActual - velocidad) >= 0)
            {
                this.velocidadActual -= velocidad;
            }
            else
            {
                this.velocidadActual = 0;
            }
        }

        /*public void Volar(int altitud)
        {
            return;
        }*/

        public void guardarEnBD()
        {
            TransporteRepository.guardar(this);
        }
    }
}
