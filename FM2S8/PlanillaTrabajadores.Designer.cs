
namespace FM2S8
{
    partial class PlanillaTrabajadores
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbTipoTrab = new System.Windows.Forms.GroupBox();
            this.btnTrabHora = new System.Windows.Forms.Button();
            this.btnTrabCompleto = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbTrabajadorCompleto = new System.Windows.Forms.GroupBox();
            this.gbTrabHora = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBorrarTXH = new System.Windows.Forms.Button();
            this.btnCancelarTXH = new System.Windows.Forms.Button();
            this.btnAceptarTXH = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTCBorrar = new System.Windows.Forms.Button();
            this.btnTCancelar = new System.Windows.Forms.Button();
            this.btnTCAceptar = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbDatosTC = new System.Windows.Forms.GroupBox();
            this.btnAgregarTC = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.gbTipoTrab.SuspendLayout();
            this.gbTrabajadorCompleto.SuspendLayout();
            this.gbTrabHora.SuspendLayout();
            this.gbDatosTC.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTipoTrab
            // 
            this.gbTipoTrab.Controls.Add(this.btnTrabHora);
            this.gbTipoTrab.Controls.Add(this.btnTrabCompleto);
            this.gbTipoTrab.Location = new System.Drawing.Point(11, 12);
            this.gbTipoTrab.Name = "gbTipoTrab";
            this.gbTipoTrab.Size = new System.Drawing.Size(777, 155);
            this.gbTipoTrab.TabIndex = 0;
            this.gbTipoTrab.TabStop = false;
            this.gbTipoTrab.Text = "Tipo de Trabajador";
            // 
            // btnTrabHora
            // 
            this.btnTrabHora.Location = new System.Drawing.Point(438, 52);
            this.btnTrabHora.Name = "btnTrabHora";
            this.btnTrabHora.Size = new System.Drawing.Size(215, 58);
            this.btnTrabHora.TabIndex = 1;
            this.btnTrabHora.Text = "Trabajador por Hora";
            this.btnTrabHora.UseVisualStyleBackColor = true;
            this.btnTrabHora.Click += new System.EventHandler(this.btnTrabHora_Click);
            // 
            // btnTrabCompleto
            // 
            this.btnTrabCompleto.Location = new System.Drawing.Point(143, 52);
            this.btnTrabCompleto.Name = "btnTrabCompleto";
            this.btnTrabCompleto.Size = new System.Drawing.Size(215, 58);
            this.btnTrabCompleto.TabIndex = 0;
            this.btnTrabCompleto.Text = "Trabajador Tiempo Completo";
            this.btnTrabCompleto.UseVisualStyleBackColor = true;
            this.btnTrabCompleto.Click += new System.EventHandler(this.btnTrabCompleto_Click);
            // 
            // gbTrabajadorCompleto
            // 
            this.gbTrabajadorCompleto.Controls.Add(this.label9);
            this.gbTrabajadorCompleto.Controls.Add(this.label8);
            this.gbTrabajadorCompleto.Controls.Add(this.label7);
            this.gbTrabajadorCompleto.Controls.Add(this.label6);
            this.gbTrabajadorCompleto.Controls.Add(this.btnTCBorrar);
            this.gbTrabajadorCompleto.Controls.Add(this.btnTCancelar);
            this.gbTrabajadorCompleto.Controls.Add(this.btnTCAceptar);
            this.gbTrabajadorCompleto.Controls.Add(this.textBox4);
            this.gbTrabajadorCompleto.Controls.Add(this.textBox3);
            this.gbTrabajadorCompleto.Controls.Add(this.textBox2);
            this.gbTrabajadorCompleto.Controls.Add(this.textBox1);
            this.gbTrabajadorCompleto.Location = new System.Drawing.Point(11, 205);
            this.gbTrabajadorCompleto.Name = "gbTrabajadorCompleto";
            this.gbTrabajadorCompleto.Size = new System.Drawing.Size(776, 177);
            this.gbTrabajadorCompleto.TabIndex = 1;
            this.gbTrabajadorCompleto.TabStop = false;
            this.gbTrabajadorCompleto.Text = "Trabajador Tiempo Completo";
            // 
            // gbTrabHora
            // 
            this.gbTrabHora.Controls.Add(this.label5);
            this.gbTrabHora.Controls.Add(this.label4);
            this.gbTrabHora.Controls.Add(this.label3);
            this.gbTrabHora.Controls.Add(this.label2);
            this.gbTrabHora.Controls.Add(this.label1);
            this.gbTrabHora.Controls.Add(this.btnBorrarTXH);
            this.gbTrabHora.Controls.Add(this.btnCancelarTXH);
            this.gbTrabHora.Controls.Add(this.btnAceptarTXH);
            this.gbTrabHora.Controls.Add(this.textBox9);
            this.gbTrabHora.Controls.Add(this.textBox8);
            this.gbTrabHora.Controls.Add(this.textBox7);
            this.gbTrabHora.Controls.Add(this.textBox6);
            this.gbTrabHora.Controls.Add(this.textBox5);
            this.gbTrabHora.Location = new System.Drawing.Point(1, 205);
            this.gbTrabHora.Name = "gbTrabHora";
            this.gbTrabHora.Size = new System.Drawing.Size(777, 208);
            this.gbTrabHora.TabIndex = 3;
            this.gbTrabHora.TabStop = false;
            this.gbTrabHora.Text = "Trabajador Por Hora";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Sueldo por Hora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Horas Trabajadas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID";
            // 
            // btnBorrarTXH
            // 
            this.btnBorrarTXH.Location = new System.Drawing.Point(360, 161);
            this.btnBorrarTXH.Name = "btnBorrarTXH";
            this.btnBorrarTXH.Size = new System.Drawing.Size(102, 20);
            this.btnBorrarTXH.TabIndex = 7;
            this.btnBorrarTXH.Text = "Borrar";
            this.btnBorrarTXH.UseVisualStyleBackColor = true;
            // 
            // btnCancelarTXH
            // 
            this.btnCancelarTXH.Location = new System.Drawing.Point(252, 161);
            this.btnCancelarTXH.Name = "btnCancelarTXH";
            this.btnCancelarTXH.Size = new System.Drawing.Size(102, 20);
            this.btnCancelarTXH.TabIndex = 6;
            this.btnCancelarTXH.Text = "Cancelar";
            this.btnCancelarTXH.UseVisualStyleBackColor = true;
            this.btnCancelarTXH.Click += new System.EventHandler(this.btnCancelarTXH_Click);
            // 
            // btnAceptarTXH
            // 
            this.btnAceptarTXH.Location = new System.Drawing.Point(149, 161);
            this.btnAceptarTXH.Name = "btnAceptarTXH";
            this.btnAceptarTXH.Size = new System.Drawing.Size(97, 20);
            this.btnAceptarTXH.TabIndex = 5;
            this.btnAceptarTXH.Text = "Agregar";
            this.btnAceptarTXH.UseVisualStyleBackColor = true;
            this.btnAceptarTXH.Click += new System.EventHandler(this.btnAceptarTXH_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(149, 134);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(230, 20);
            this.textBox9.TabIndex = 4;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(149, 108);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(230, 20);
            this.textBox8.TabIndex = 3;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(149, 82);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(230, 20);
            this.textBox7.TabIndex = 2;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(149, 56);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(230, 20);
            this.textBox6.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(149, 30);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(230, 20);
            this.textBox5.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Sueldo";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Apellido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "ID";
            // 
            // btnTCBorrar
            // 
            this.btnTCBorrar.Location = new System.Drawing.Point(320, 132);
            this.btnTCBorrar.Name = "btnTCBorrar";
            this.btnTCBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnTCBorrar.TabIndex = 6;
            this.btnTCBorrar.Text = "Borrar";
            this.btnTCBorrar.UseVisualStyleBackColor = true;
            this.btnTCBorrar.Click += new System.EventHandler(this.btnTCBorrar_Click);
            // 
            // btnTCancelar
            // 
            this.btnTCancelar.Location = new System.Drawing.Point(239, 132);
            this.btnTCancelar.Name = "btnTCancelar";
            this.btnTCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnTCancelar.TabIndex = 5;
            this.btnTCancelar.Text = "Cancelar";
            this.btnTCancelar.UseVisualStyleBackColor = true;
            this.btnTCancelar.Click += new System.EventHandler(this.btnTCancelar_Click);
            // 
            // btnTCAceptar
            // 
            this.btnTCAceptar.Location = new System.Drawing.Point(158, 132);
            this.btnTCAceptar.Name = "btnTCAceptar";
            this.btnTCAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnTCAceptar.TabIndex = 4;
            this.btnTCAceptar.Text = "Agregar";
            this.btnTCAceptar.UseVisualStyleBackColor = true;
            this.btnTCAceptar.Click += new System.EventHandler(this.btnTCAceptar_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(158, 106);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(200, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(158, 80);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(158, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 0;
            // 
            // gbDatosTC
            // 
            this.gbDatosTC.Controls.Add(this.btnAgregarTC);
            this.gbDatosTC.Controls.Add(this.listView1);
            this.gbDatosTC.Location = new System.Drawing.Point(1, 12);
            this.gbDatosTC.Name = "gbDatosTC";
            this.gbDatosTC.Size = new System.Drawing.Size(797, 187);
            this.gbDatosTC.TabIndex = 2;
            this.gbDatosTC.TabStop = false;
            this.gbDatosTC.Text = "Datos del Trabajador";
            // 
            // btnAgregarTC
            // 
            this.btnAgregarTC.Location = new System.Drawing.Point(249, 140);
            this.btnAgregarTC.Name = "btnAgregarTC";
            this.btnAgregarTC.Size = new System.Drawing.Size(232, 26);
            this.btnAgregarTC.TabIndex = 8;
            this.btnAgregarTC.Text = "Agregar Trabajador";
            this.btnAgregarTC.UseVisualStyleBackColor = true;
            this.btnAgregarTC.Click += new System.EventHandler(this.btnAgregarTC_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(19, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(741, 115);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 421);
            this.Controls.Add(this.gbTrabHora);
            this.Controls.Add(this.gbTrabajadorCompleto);
            this.Controls.Add(this.gbDatosTC);
            this.Controls.Add(this.gbTipoTrab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbTipoTrab.ResumeLayout(false);
            this.gbTrabajadorCompleto.ResumeLayout(false);
            this.gbTrabajadorCompleto.PerformLayout();
            this.gbTrabHora.ResumeLayout(false);
            this.gbTrabHora.PerformLayout();
            this.gbDatosTC.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTipoTrab;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnTrabHora;
        private System.Windows.Forms.Button btnTrabCompleto;
        private System.Windows.Forms.GroupBox gbTrabajadorCompleto;
        private System.Windows.Forms.Button btnTCBorrar;
        private System.Windows.Forms.Button btnTCancelar;
        private System.Windows.Forms.Button btnTCAceptar;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gbDatosTC;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnAgregarTC;
        private System.Windows.Forms.GroupBox gbTrabHora;
        private System.Windows.Forms.Button btnBorrarTXH;
        private System.Windows.Forms.Button btnCancelarTXH;
        private System.Windows.Forms.Button btnAceptarTXH;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

