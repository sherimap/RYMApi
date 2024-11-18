namespace RYMApi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            dgvCharacters = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Genero = new DataGridViewTextBoxColumn();
            Especie = new DataGridViewTextBoxColumn();
            Origen = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCharacters).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(202, 415);
            button1.Name = "button1";
            button1.Size = new Size(192, 23);
            button1.TabIndex = 0;
            button1.Text = "Obtener Personajes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvCharacters
            // 
            dgvCharacters.AllowUserToAddRows = false;
            dgvCharacters.AllowUserToDeleteRows = false;
            dgvCharacters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCharacters.Columns.AddRange(new DataGridViewColumn[] { Nombre, Genero, Especie, Origen });
            dgvCharacters.Location = new Point(12, 12);
            dgvCharacters.Name = "dgvCharacters";
            dgvCharacters.ReadOnly = true;
            dgvCharacters.Size = new Size(595, 397);
            dgvCharacters.TabIndex = 1;
            dgvCharacters.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 250;
            // 
            // Genero
            // 
            Genero.HeaderText = "Genero";
            Genero.Name = "Genero";
            Genero.ReadOnly = true;
            // 
            // Especie
            // 
            Especie.HeaderText = "Especie";
            Especie.Name = "Especie";
            Especie.ReadOnly = true;
            // 
            // Origen
            // 
            Origen.HeaderText = "Origen";
            Origen.Name = "Origen";
            Origen.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 450);
            Controls.Add(dgvCharacters);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCharacters).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dgvCharacters;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Genero;
        private DataGridViewTextBoxColumn Especie;
        private DataGridViewTextBoxColumn Origen;
    }
}
