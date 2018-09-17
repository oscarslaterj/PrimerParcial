namespace PrimerParcial.UI.Registros
{
    partial class RegistroPrimerParcial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroPrimerParcial));
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Buscarbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.BackgroundImage")));
            this.Buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.Image")));
            this.Buscarbutton.Location = new System.Drawing.Point(311, 54);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(103, 44);
            this.Buscarbutton.TabIndex = 0;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Buscarbutton.UseVisualStyleBackColor = false;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Nuevobutton.Image = ((System.Drawing.Image)(resources.GetObject("Nuevobutton.Image")));
            this.Nuevobutton.Location = new System.Drawing.Point(33, 248);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(103, 50);
            this.Nuevobutton.TabIndex = 1;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Nuevobutton.UseVisualStyleBackColor = false;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Guardarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Guardarbutton.Image")));
            this.Guardarbutton.Location = new System.Drawing.Point(170, 248);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(103, 50);
            this.Guardarbutton.TabIndex = 2;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Guardarbutton.UseVisualStyleBackColor = false;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Eliminarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Eliminarbutton.Image")));
            this.Eliminarbutton.Location = new System.Drawing.Point(301, 248);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(103, 50);
            this.Eliminarbutton.TabIndex = 3;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Eliminarbutton.UseVisualStyleBackColor = false;
            // 
            // RegistroPrimerParcial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(532, 330);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "RegistroPrimerParcial";
            this.Text = "RegistroPrimerParcial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
    }
}