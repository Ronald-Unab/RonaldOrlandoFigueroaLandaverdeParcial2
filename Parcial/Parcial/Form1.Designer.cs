namespace Parcial
{
    partial class principalForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarBeneficiariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDuiU = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(518, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarBeneficiariosToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // administrarBeneficiariosToolStripMenuItem
            // 
            this.administrarBeneficiariosToolStripMenuItem.Name = "administrarBeneficiariosToolStripMenuItem";
            this.administrarBeneficiariosToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.administrarBeneficiariosToolStripMenuItem.Text = "Administrar Beneficiarios";
            this.administrarBeneficiariosToolStripMenuItem.Click += new System.EventHandler(this.administrarBeneficiariosToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ante la emergencia del Covid-19, el Gobierno de El Salvador \r\ndara bonos para apo" +
    "yar su economia";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese su numero de Dui para comprobar\r\nsi es beneficiado";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDuiU
            // 
            this.txtDuiU.Location = new System.Drawing.Point(161, 152);
            this.txtDuiU.Name = "txtDuiU";
            this.txtDuiU.Size = new System.Drawing.Size(202, 20);
            this.txtDuiU.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // principalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 244);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDuiU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "principalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gobierno de El Salvador";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarBeneficiariosToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDuiU;
        private System.Windows.Forms.Button button1;
    }
}

