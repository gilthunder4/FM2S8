using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM2S8
{
    class TrabajadorPorHora : Trabajador
    {
        private int numeroHorasTrabajadas;
        private float sueldoPorHora;

        public int NumeroHorasTrabajadas { get => numeroHorasTrabajadas; }
        public float SueldoPorHora { get => sueldoPorHora; }

        public TrabajadorPorHora() : base()
        {
            this.numeroHorasTrabajadas = 0;
            this.sueldoPorHora = 0;

        }
        public TrabajadorPorHora(int id, string nom, string ape, int nht, float sh) : base(id, nom, ape)
        {
            this.numeroHorasTrabajadas = nht;
            this.sueldoPorHora = sh;
            base.sueldo = nht * sh;
            base.descuentoISR = sueldo * 0.1f;
            base.totalDescuento = base.descuentoISR;
            base.totalPagar = base.sueldo - base.totalDescuento;
        }
        public override tipoTrabajador getTipoTrabajador()
        {
            return tipoTrabajador.TRABAJADOR_POR_HORA;
        }
        public override string ToString()
        {
            return this.IdPersona + " " + this.Nombre + " " + this.Apellido + " " + this.NumeroHorasTrabajadas + " " 
                + this.SueldoPorHora + " " + this.sueldo + " " +this.totalDescuento+ " "+this.totalPagar+ "Trabajador por Hora";
        }
    }
}
