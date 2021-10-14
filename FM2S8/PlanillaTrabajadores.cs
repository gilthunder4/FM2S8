using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FM2S8
{
    public partial class PlanillaTrabajadores : Form
    {
        public PlanillaTrabajadores()
        {
            InitializeComponent();
            this.gbTipoTrab.Visible = true;
            this.gbTrabajadorCompleto.Visible = false;
            this.gbDatosTC.Visible = false;
            this.gbTrabHora.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnTrabCompleto_Click(object sender, EventArgs e)
        {
            this.gbTipoTrab.Visible = true;
            this.gbTrabajadorCompleto.Visible = true;
            this.gbDatosTC.Visible = false;
            this.gbTrabHora.Visible = false;
        }
        private void btnTrabHora_Click(object sender, EventArgs e)
        {
            this.gbTipoTrab.Visible = true;
            this.gbTrabajadorCompleto.Visible = false;
            this.gbDatosTC.Visible = false;
            this.gbTrabHora.Visible = true;
        }

        private void btnTCAceptar_Click(object sender, EventArgs e)
        {
            int id;
            string nom, ape;
            float sueldo;

            id = Convert.ToInt32(this.textBox1.Text);
            nom = this.textBox2.Text;
            ape = this.textBox3.Text;
            sueldo = Convert.ToSingle(this.textBox4.Text);

            TrabajadorTiempoCompleto ttc = new TrabajadorTiempoCompleto(id, nom, ape, sueldo);
            this.listView1.Items.Add(ttc.ToString());

            this.gbTipoTrab.Visible = false;
            this.gbTrabajadorCompleto.Visible = true;
            this.gbDatosTC.Visible = true;
            this.gbTrabHora.Visible = false;
        }

        private void btnTCancelar_Click(object sender, EventArgs e)
        {
            this.gbTipoTrab.Visible = true;
            this.gbTrabajadorCompleto.Visible = false;
            this.gbDatosTC.Visible = false;
            this.gbTrabHora.Visible = false;
        }

        private void btnTCBorrar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAgregarTC_Click(object sender, EventArgs e)
        {
            this.gbTipoTrab.Visible = true;
            this.gbTrabajadorCompleto.Visible = false;
            this.gbDatosTC.Visible = false;
            this.gbTrabHora.Visible = false;
        }

        private void btnAceptarTXH_Click(object sender, EventArgs e)
        {
            int id, nht;
            float sh;
            string nom, ape;
            

            id = Convert.ToInt32(this.textBox5.Text);
            nom = this.textBox6.Text;
            ape = this.textBox7.Text;
            nht = Convert.ToInt32(this.textBox8.Text);
            sh = Convert.ToSingle(this.textBox9.Text);
            TrabajadorPorHora txh = new TrabajadorPorHora(id, nom, ape, nht, sh);
            this.listView1.Items.Add(txh.ToString());

            this.gbTipoTrab.Visible = false;
            this.gbTrabajadorCompleto.Visible = false;
            this.gbDatosTC.Visible = true;
            this.gbTrabHora.Visible = true;
        }


        private void btnCancelarTXH_Click(object sender, EventArgs e)
        {
            this.gbTipoTrab.Visible = true;
            this.gbTrabajadorCompleto.Visible = false;
            this.gbDatosTC.Visible = false;
            this.gbTrabHora.Visible = false;
        }


        private void label9_Click(object sender, EventArgs e)
        {

        }


    }
}
