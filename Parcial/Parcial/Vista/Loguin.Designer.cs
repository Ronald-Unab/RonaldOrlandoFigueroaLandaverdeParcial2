namespace Parcial.Vista
{
    partial class Loguin
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
            this.btnEntrarL = new System.Windows.Forms.Button();
            this.txtContraL = new System.Windows.Forms.TextBox();
            this.txtUsuarioL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEntrarL
            // 
            this.btnEntrarL.Location = new System.Drawing.Point(107, 228);
            this.btnEntrarL.Name = "btnEntrarL";
            this.btnEntrarL.Size = new System.Drawing.Size(75, 23);
            this.btnEntrarL.TabIndex = 0;
            this.btnEntrarL.Text = "Entrar";
            this.btnEntrarL.UseVisualStyleBackColor = true;
            this.btnEntrarL.Click += new System.EventHandler(this.btnEntrarL_Click);
            // 
            // txtContraL
            // 
            this.txtContraL.Location = new System.Drawing.Point(12, 169);
            this.txtContraL.Name = "txtContraL";
            this.txtContraL.PasswordChar = '*';
            this.txtContraL.Size = new System.Drawing.Size(267, 20);
            this.txtContraL.TabIndex = 1;
            // 
            // txtUsuarioL
            // 
            this.txtUsuarioL.Location = new System.Drawing.Point(12, 83);
            this.txtUsuarioL.Name = "txtUsuarioL";
            this.txtUsuarioL.Size = new System.Drawing.Size(267, 20);
            this.txtUsuarioL.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // Loguin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 287);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsuarioL);
            this.Controls.Add(this.txtContraL);
            this.Controls.Add(this.btnEntrarL);
            this.Name = "Loguin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loguin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrarL;
        private System.Windows.Forms.TextBox txtContraL;
        private System.Windows.Forms.TextBox txtUsuarioL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}