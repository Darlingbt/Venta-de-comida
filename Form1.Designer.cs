
namespace Venta_de_comida
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.prepaqtrio = new System.Windows.Forms.Label();
            this.prepaqfam = new System.Windows.Forms.Label();
            this.prepaqduo = new System.Windows.Forms.Label();
            this.prepaqinf = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnnuevacom = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txttotalapag = new System.Windows.Forms.TextBox();
            this.txtiva = new System.Windows.Forms.TextBox();
            this.txtsubt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.paqtrio = new System.Windows.Forms.CheckBox();
            this.paqfam = new System.Windows.Forms.CheckBox();
            this.paqduo = new System.Windows.Forms.CheckBox();
            this.paqinf = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtcantpaqtrio = new System.Windows.Forms.TextBox();
            this.txtcantpaqfam = new System.Windows.Forms.TextBox();
            this.txtcantpaqduo = new System.Windows.Forms.TextBox();
            this.txtcantpaqinf = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.btnsalir);
            this.groupBox1.Controls.Add(this.btnnuevacom);
            this.groupBox1.Controls.Add(this.btnaceptar);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 409);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecciona los Combos";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.prepaqtrio);
            this.groupBox4.Controls.Add(this.prepaqfam);
            this.groupBox4.Controls.Add(this.prepaqduo);
            this.groupBox4.Controls.Add(this.prepaqinf);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(293, 36);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(106, 169);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Precio";
            // 
            // prepaqtrio
            // 
            this.prepaqtrio.AutoSize = true;
            this.prepaqtrio.Location = new System.Drawing.Point(22, 126);
            this.prepaqtrio.Name = "prepaqtrio";
            this.prepaqtrio.Size = new System.Drawing.Size(53, 19);
            this.prepaqtrio.TabIndex = 3;
            this.prepaqtrio.Text = "$95.50";
            // 
            // prepaqfam
            // 
            this.prepaqfam.AutoSize = true;
            this.prepaqfam.Location = new System.Drawing.Point(22, 94);
            this.prepaqfam.Name = "prepaqfam";
            this.prepaqfam.Size = new System.Drawing.Size(41, 19);
            this.prepaqfam.TabIndex = 2;
            this.prepaqfam.Text = "$105";
            // 
            // prepaqduo
            // 
            this.prepaqduo.AutoSize = true;
            this.prepaqduo.Location = new System.Drawing.Point(22, 62);
            this.prepaqduo.Name = "prepaqduo";
            this.prepaqduo.Size = new System.Drawing.Size(53, 19);
            this.prepaqduo.TabIndex = 1;
            this.prepaqduo.Text = "$90.00";
            // 
            // prepaqinf
            // 
            this.prepaqinf.AutoSize = true;
            this.prepaqinf.Location = new System.Drawing.Point(22, 30);
            this.prepaqinf.Name = "prepaqinf";
            this.prepaqinf.Size = new System.Drawing.Size(53, 19);
            this.prepaqinf.TabIndex = 0;
            this.prepaqinf.Text = "$85.50";
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(290, 350);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(105, 41);
            this.btnsalir.TabIndex = 5;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnnuevacom
            // 
            this.btnnuevacom.Location = new System.Drawing.Point(20, 293);
            this.btnnuevacom.Name = "btnnuevacom";
            this.btnnuevacom.Size = new System.Drawing.Size(105, 51);
            this.btnnuevacom.TabIndex = 4;
            this.btnnuevacom.Text = "Nueva Compra";
            this.btnnuevacom.UseVisualStyleBackColor = true;
            this.btnnuevacom.Click += new System.EventHandler(this.btnnuevacom_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(20, 231);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(105, 51);
            this.btnaceptar.TabIndex = 3;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.txttotalapag);
            this.groupBox5.Controls.Add(this.txtiva);
            this.groupBox5.Controls.Add(this.txtsubt);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(144, 222);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(256, 122);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Total a pagar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "IVA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Subtotal:";
            // 
            // txttotalapag
            // 
            this.txttotalapag.Enabled = false;
            this.txttotalapag.Location = new System.Drawing.Point(157, 80);
            this.txttotalapag.Name = "txttotalapag";
            this.txttotalapag.Size = new System.Drawing.Size(94, 26);
            this.txttotalapag.TabIndex = 6;
            // 
            // txtiva
            // 
            this.txtiva.Enabled = false;
            this.txtiva.Location = new System.Drawing.Point(157, 48);
            this.txtiva.Name = "txtiva";
            this.txtiva.Size = new System.Drawing.Size(94, 26);
            this.txtiva.TabIndex = 5;
            // 
            // txtsubt
            // 
            this.txtsubt.Enabled = false;
            this.txtsubt.Location = new System.Drawing.Point(157, 16);
            this.txtsubt.Name = "txtsubt";
            this.txtsubt.Size = new System.Drawing.Size(94, 26);
            this.txtsubt.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.paqtrio);
            this.groupBox3.Controls.Add(this.paqfam);
            this.groupBox3.Controls.Add(this.paqduo);
            this.groupBox3.Controls.Add(this.paqinf);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(118, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(169, 169);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // paqtrio
            // 
            this.paqtrio.AutoSize = true;
            this.paqtrio.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paqtrio.Location = new System.Drawing.Point(6, 126);
            this.paqtrio.Name = "paqtrio";
            this.paqtrio.Size = new System.Drawing.Size(129, 21);
            this.paqtrio.TabIndex = 3;
            this.paqtrio.Text = "Paquete El Trio";
            this.paqtrio.UseVisualStyleBackColor = true;
            this.paqtrio.CheckedChanged += new System.EventHandler(this.paqtrio_CheckedChanged);
            // 
            // paqfam
            // 
            this.paqfam.AutoSize = true;
            this.paqfam.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paqfam.Location = new System.Drawing.Point(6, 94);
            this.paqfam.Name = "paqfam";
            this.paqfam.Size = new System.Drawing.Size(137, 21);
            this.paqfam.TabIndex = 2;
            this.paqfam.Text = "Paquete Familiar";
            this.paqfam.UseVisualStyleBackColor = true;
            this.paqfam.CheckedChanged += new System.EventHandler(this.paqfam_CheckedChanged);
            // 
            // paqduo
            // 
            this.paqduo.AutoSize = true;
            this.paqduo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paqduo.Location = new System.Drawing.Point(6, 62);
            this.paqduo.Name = "paqduo";
            this.paqduo.Size = new System.Drawing.Size(111, 21);
            this.paqduo.TabIndex = 1;
            this.paqduo.Text = "Paquete Duo";
            this.paqduo.UseVisualStyleBackColor = true;
            this.paqduo.CheckedChanged += new System.EventHandler(this.paqduo_CheckedChanged);
            // 
            // paqinf
            // 
            this.paqinf.AutoSize = true;
            this.paqinf.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paqinf.Location = new System.Drawing.Point(6, 30);
            this.paqinf.Name = "paqinf";
            this.paqinf.Size = new System.Drawing.Size(130, 21);
            this.paqinf.TabIndex = 0;
            this.paqinf.Text = "Paquete Infantil";
            this.paqinf.UseVisualStyleBackColor = true;
            this.paqinf.CheckedChanged += new System.EventHandler(this.paqinf_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtcantpaqtrio);
            this.groupBox2.Controls.Add(this.txtcantpaqfam);
            this.groupBox2.Controls.Add(this.txtcantpaqduo);
            this.groupBox2.Controls.Add(this.txtcantpaqinf);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(106, 169);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cantidad";
            // 
            // txtcantpaqtrio
            // 
            this.txtcantpaqtrio.Enabled = false;
            this.txtcantpaqtrio.Location = new System.Drawing.Point(6, 123);
            this.txtcantpaqtrio.Name = "txtcantpaqtrio";
            this.txtcantpaqtrio.Size = new System.Drawing.Size(79, 26);
            this.txtcantpaqtrio.TabIndex = 3;
            this.txtcantpaqtrio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantpaqtrio_KeyPress_1);
            // 
            // txtcantpaqfam
            // 
            this.txtcantpaqfam.Enabled = false;
            this.txtcantpaqfam.Location = new System.Drawing.Point(6, 91);
            this.txtcantpaqfam.Name = "txtcantpaqfam";
            this.txtcantpaqfam.Size = new System.Drawing.Size(79, 26);
            this.txtcantpaqfam.TabIndex = 2;
            this.txtcantpaqfam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantpaqfam_KeyPress_1);
            // 
            // txtcantpaqduo
            // 
            this.txtcantpaqduo.Enabled = false;
            this.txtcantpaqduo.Location = new System.Drawing.Point(6, 59);
            this.txtcantpaqduo.Name = "txtcantpaqduo";
            this.txtcantpaqduo.Size = new System.Drawing.Size(79, 26);
            this.txtcantpaqduo.TabIndex = 1;
            this.txtcantpaqduo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantpaqduo_KeyPress_1);
            // 
            // txtcantpaqinf
            // 
            this.txtcantpaqinf.Enabled = false;
            this.txtcantpaqinf.Location = new System.Drawing.Point(6, 27);
            this.txtcantpaqinf.Name = "txtcantpaqinf";
            this.txtcantpaqinf.Size = new System.Drawing.Size(79, 26);
            this.txtcantpaqinf.TabIndex = 0;
            this.txtcantpaqinf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantpaqinf_KeyPress_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 434);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Comida";
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label prepaqduo;
        private System.Windows.Forms.Label prepaqinf;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnnuevacom;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txttotalapag;
        private System.Windows.Forms.TextBox txtiva;
        private System.Windows.Forms.TextBox txtsubt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox paqtrio;
        private System.Windows.Forms.CheckBox paqfam;
        private System.Windows.Forms.CheckBox paqduo;
        private System.Windows.Forms.CheckBox paqinf;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtcantpaqtrio;
        private System.Windows.Forms.TextBox txtcantpaqfam;
        private System.Windows.Forms.TextBox txtcantpaqduo;
        private System.Windows.Forms.TextBox txtcantpaqinf;
        private System.Windows.Forms.Label prepaqtrio;
        private System.Windows.Forms.Label prepaqfam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

