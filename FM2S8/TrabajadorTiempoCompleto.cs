using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM2S8
{
    class TrabajadorTiempoCompleto : Trabajador
    {
        private float descuentoAfp;
        private float descuentoIsss;

        public float DescuentoAfp { get => descuentoAfp; }
        public float DecuentoIsss { get => descuentoIsss; }

        public TrabajadorTiempoCompleto() : base()
        {
            this.descuentoIsss = 0;
            this.descuentoAfp = 0;
        }

        public TrabajadorTiempoCompleto(int id, string nom, string ape, float sueldo) : base(id, nom, ape)
        {
            base.sueldo = sueldo;
            //CALCULOS
            if (sueldo <= 1000)
                this.descuentoIsss = sueldo * 0.03f;
            else
                this.descuentoIsss = 30;
            if (sueldo <= 6500)
                this.descuentoAfp = sueldo * 0.0725f;
            float ri = sueldo - (this.descuentoIsss + this.descuentoAfp);

            //CALCULO ISR
            if (ri > 0 && ri <= 487.6f)
                base.descuentoISR = 0;
            else if (ri > 487.6f && ri <= 642.85f)
                base.descuentoISR = (ri - 487.6f) * 0.1f + 17.48f;
            else if (ri > 642.85f && ri <= 915.81f)
                base.descuentoISR = (ri - 642.85f) * 0.1f + 35.7f;
            else if (ri > 915.81f && ri <= 2058.67f)
                base.descuentoISR = (ri - 915.81f) * 0.2f + 60;
            else
                base.descuentoISR = (ri - 2058.67f) * 0.3f + 288.57f;

            base.totalDescuento = this.descuentoAfp + this.descuentoIsss + base.descuentoISR;
            base.totalPagar = base.sueldo - base.totalDescuento;

        }


        public override tipoTrabajador getTipoTrabajador()
        {
            return tipoTrabajador.TRABAJADOR_TIEMPO_COMPLETO;
        }
        public override string ToString()
        {
            return this.IdPersona + " " + this.Nombre + " " + this.Apellido + " " +this.Sueldo+" "+this.totalDescuento+" "+
                this.totalPagar + "Trabajador Tiempo Completo";
        }
    }   
}
