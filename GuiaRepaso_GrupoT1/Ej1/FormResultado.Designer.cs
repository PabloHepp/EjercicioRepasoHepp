namespace Ej1
{
    partial class FormResultado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lBListar = new System.Windows.Forms.ListBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lBListar
            // 
            this.lBListar.FormattingEnabled = true;
            this.lBListar.Location = new System.Drawing.Point(12, 12);
            this.lBListar.Name = "lBListar";
            this.lBListar.Size = new System.Drawing.Size(147, 264);
            this.lBListar.TabIndex = 0;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(165, 44);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // FormResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 287);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lBListar);
            this.Name = "FormResultado";
            this.Text = "FormResultado";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox lBListar;
        public System.Windows.Forms.Button btnListar;
    }
}