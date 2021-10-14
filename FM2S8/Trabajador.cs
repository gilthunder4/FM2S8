using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM2S8
{
    public abstract class Trabajador : Persona
    {
        protected float sueldo;
        protected float descuentoISR;
        protected float totalDescuento;
        protected float totalPagar;

        public float Sueldo { get => sueldo; }
        public float DescuentoISR { get => descuentoISR; }
        public float TotalDescuento { get => totalDescuento; }
        public float TotalPagar { get => totalPagar; }

        public Trabajador() : base()
        {
            this.sueldo = 0;
            this.descuentoISR = 0;
            this.totalDescuento = 0;
            this.totalPagar = 0;
        }
        public Trabajador(int id, string nom, string ape) : base(id, nom, ape)
        {
            this.sueldo = 0;
            this.descuentoISR = 0;
            this.totalDescuento = 0;
            this.totalPagar = 0;
        }
        public abstract tipoTrabajador getTipoTrabajador();

    }
}
