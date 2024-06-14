namespace Ej1
{
    partial class FormPrincipal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btAgregarValor = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LbMostrarProm = new System.Windows.Forms.Label();
            this.BtnCalProm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btAgregarValor);
            this.groupBox1.Location = new System.Drawing.Point(29, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar alumno";
            // 
            // btAgregarValor
            // 
            this.btAgregarValor.Location = new System.Drawing.Point(61, 35);
            this.btAgregarValor.Name = "btAgregarValor";
            this.btAgregarValor.Size = new System.Drawing.Size(103, 23);
            this.btAgregarValor.TabIndex = 0;
            this.btAgregarValor.Text = "Agregar";
            this.btAgregarValor.UseVisualStyleBackColor = true;
            this.btAgregarValor.Click += new System.EventHandler(this.btAgregarValor_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LbMostrarProm);
            this.groupBox2.Controls.Add(this.BtnCalProm);
            this.groupBox2.Location = new System.Drawing.Point(272, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 90);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ver promedio general";
            // 
            // LbMostrarProm
            // 
            this.LbMostrarProm.AutoSize = true;
            this.LbMostrarProm.Location = new System.Drawing.Point(95, 35);
            this.LbMostrarProm.Name = "LbMostrarProm";
            this.LbMostrarProm.Size = new System.Drawing.Size(54, 13);
            this.LbMostrarProm.TabIndex = 1;
            this.LbMostrarProm.Text = "Promedio:";
            // 
            // BtnCalProm
            // 
            this.BtnCalProm.Location = new System.Drawing.Point(65, 58);
            this.BtnCalProm.Name = "BtnCalProm";
            this.BtnCalProm.Size = new System.Drawing.Size(105, 25);
            this.BtnCalProm.TabIndex = 0;
            this.BtnCalProm.Text = "Calcular Promedio";
            this.BtnCalProm.UseVisualStyleBackColor = true;
            this.BtnCalProm.Click += new System.EventHandler(this.BtnCalProm_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ver listado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(29, 119);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 78);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alumnos que superaron el promedio";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 203);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPrincipal";
            this.Text = "Ventana principal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btAgregarValor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnCalProm;
        private System.Windows.Forms.Label LbMostrarProm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

