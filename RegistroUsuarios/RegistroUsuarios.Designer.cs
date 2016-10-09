namespace RegistroUsuarios
{
    partial class RegistroUsuarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Clave = new System.Windows.Forms.TextBox();
            this.Nuevo = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(257, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "Buscar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(159, 75);
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Size = new System.Drawing.Size(203, 20);
            this.Nombre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contraceña";
            // 
            // Clave
            // 
            this.Clave.Location = new System.Drawing.Point(159, 111);
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            this.Clave.Size = new System.Drawing.Size(203, 20);
            this.Clave.TabIndex = 8;
            // 
            // Nuevo
            // 
            this.Nuevo.Location = new System.Drawing.Point(32, 164);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(95, 47);
            this.Nuevo.TabIndex = 9;
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevo.UseVisualStyleBackColor = true;
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(133, 164);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(95, 47);
            this.Guardar.TabIndex = 0;
            this.Guardar.Text = "Guardar";
            this.Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Modificar
            // 
            this.Modificar.Location = new System.Drawing.Point(234, 164);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(95, 47);
            this.Modificar.TabIndex = 10;
            this.Modificar.Text = "Modificar";
            this.Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Modificar.UseVisualStyleBackColor = true;
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(335, 164);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(95, 47);
            this.Eliminar.TabIndex = 11;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminar.UseVisualStyleBackColor = true;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(159, 42);
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Size = new System.Drawing.Size(92, 20);
            this.ID.TabIndex = 12;
            // 
            // RegistroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 261);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.Nuevo);
            this.Controls.Add(this.Clave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Guardar);
            this.Name = "RegistroUsuarios";
            this.Text = "RegistroUsuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Clave;
        private System.Windows.Forms.Button Nuevo;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.TextBox ID;
    }
}