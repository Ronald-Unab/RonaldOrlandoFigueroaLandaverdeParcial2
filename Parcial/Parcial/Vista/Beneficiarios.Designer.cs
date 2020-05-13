namespace Parcial.Vista
{
    partial class Beneficiarios
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
            this.dgvBeneficiadosB = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnActualizarB = new System.Windows.Forms.Button();
            this.ingresarBeneficiadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEliminarB = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDuiB = new System.Windows.Forms.TextBox();
            this.txtIdB = new System.Windows.Forms.TextBox();
            this.txtNombreB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficiadosB)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBeneficiadosB
            // 
            this.dgvBeneficiadosB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBeneficiadosB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBeneficiadosB.Location = new System.Drawing.Point(226, 104);
            this.dgvBeneficiadosB.Name = "dgvBeneficiadosB";
            this.dgvBeneficiadosB.Size = new System.Drawing.Size(341, 220);
            this.dgvBeneficiadosB.TabIndex = 0;
            this.dgvBeneficiadosB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarBeneficiadoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(579, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnActualizarB
            // 
            this.btnActualizarB.Location = new System.Drawing.Point(354, 75);
            this.btnActualizarB.Name = "btnActualizarB";
            this.btnActualizarB.Size = new System.Drawing.Size(107, 23);
            this.btnActualizarB.TabIndex = 3;
            this.btnActualizarB.Text = "Actualizar Lista";
            this.btnActualizarB.UseVisualStyleBackColor = true;
            this.btnActualizarB.Click += new System.EventHandler(this.btnActualizarB_Click);
            // 
            // ingresarBeneficiadoToolStripMenuItem
            // 
            this.ingresarBeneficiadoToolStripMenuItem.Name = "ingresarBeneficiadoToolStripMenuItem";
            this.ingresarBeneficiadoToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.ingresarBeneficiadoToolStripMenuItem.Text = "Ingresar Nuevo";
            this.ingresarBeneficiadoToolStripMenuItem.Click += new System.EventHandler(this.ingresarBeneficiadoToolStripMenuItem_Click_1);
            // 
            // btnEliminarB
            // 
            this.btnEliminarB.Location = new System.Drawing.Point(226, 75);
            this.btnEliminarB.Name = "btnEliminarB";
            this.btnEliminarB.Size = new System.Drawing.Size(122, 23);
            this.btnEliminarB.TabIndex = 4;
            this.btnEliminarB.Text = "Eliminar Seleccionado";
            this.btnEliminarB.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Actualizar Datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDuiB
            // 
            this.txtDuiB.Location = new System.Drawing.Point(11, 153);
            this.txtDuiB.Name = "txtDuiB";
            this.txtDuiB.Size = new System.Drawing.Size(100, 20);
            this.txtDuiB.TabIndex = 6;
            // 
            // txtIdB
            // 
            this.txtIdB.Location = new System.Drawing.Point(144, 153);
            this.txtIdB.Name = "txtIdB";
            this.txtIdB.Size = new System.Drawing.Size(64, 20);
            this.txtIdB.TabIndex = 7;
            // 
            // txtNombreB
            // 
            this.txtNombreB.Location = new System.Drawing.Point(11, 212);
            this.txtNombreB.Name = "txtNombreB";
            this.txtNombreB.Size = new System.Drawing.Size(197, 20);
            this.txtNombreB.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Numero de Dui";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Datos del usuario seleccionado";
            // 
            // Beneficiarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 336);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreB);
            this.Controls.Add(this.txtIdB);
            this.Controls.Add(this.txtDuiB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEliminarB);
            this.Controls.Add(this.btnActualizarB);
            this.Controls.Add(this.dgvBeneficiadosB);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Beneficiarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beneficiarios";
            this.Load += new System.EventHandler(this.Beneficiarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficiadosB)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.DataGridView dgvBeneficiadosB;
        private System.Windows.Forms.Button btnActualizarB;
        private System.Windows.Forms.ToolStripMenuItem ingresarBeneficiadoToolStripMenuItem;
        private System.Windows.Forms.Button btnEliminarB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDuiB;
        private System.Windows.Forms.TextBox txtIdB;
        private System.Windows.Forms.TextBox txtNombreB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}