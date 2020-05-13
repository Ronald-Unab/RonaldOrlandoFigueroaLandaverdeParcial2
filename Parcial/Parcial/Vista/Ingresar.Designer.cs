namespace Parcial.Vista
{
    partial class Ingresar
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
            this.txtNombreI = new System.Windows.Forms.TextBox();
            this.txtDuiI = new System.Windows.Forms.TextBox();
            this.txtIdI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardarI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombreI
            // 
            this.txtNombreI.Location = new System.Drawing.Point(15, 119);
            this.txtNombreI.Name = "txtNombreI";
            this.txtNombreI.Size = new System.Drawing.Size(354, 20);
            this.txtNombreI.TabIndex = 0;
            // 
            // txtDuiI
            // 
            this.txtDuiI.Location = new System.Drawing.Point(12, 38);
            this.txtDuiI.Name = "txtDuiI";
            this.txtDuiI.Size = new System.Drawing.Size(184, 20);
            this.txtDuiI.TabIndex = 1;
            // 
            // txtIdI
            // 
            this.txtIdI.Location = new System.Drawing.Point(263, 38);
            this.txtIdI.Name = "txtIdI";
            this.txtIdI.Size = new System.Drawing.Size(103, 20);
            this.txtIdI.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numero de Dui";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID";
            // 
            // btnGuardarI
            // 
            this.btnGuardarI.Location = new System.Drawing.Point(150, 179);
            this.btnGuardarI.Name = "btnGuardarI";
            this.btnGuardarI.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarI.TabIndex = 6;
            this.btnGuardarI.Text = "Guardar";
            this.btnGuardarI.UseVisualStyleBackColor = true;
            this.btnGuardarI.Click += new System.EventHandler(this.btnGuardarI_Click);
            // 
            // Ingresar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 219);
            this.Controls.Add(this.btnGuardarI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdI);
            this.Controls.Add(this.txtDuiI);
            this.Controls.Add(this.txtNombreI);
            this.Name = "Ingresar";
            this.Text = "Ingresar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreI;
        private System.Windows.Forms.TextBox txtDuiI;
        private System.Windows.Forms.TextBox txtIdI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardarI;
    }
}