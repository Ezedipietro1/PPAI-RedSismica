namespace PPAI_RedSismica.Formularios
{
    partial class PantallaCerrarOrdenInspeccion
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
            BotonCerrarOrden = new Button();
            BotonSalir = new Button();
            SuspendLayout();
            // 
            // BotonCerrarOrden
            // 
            BotonCerrarOrden.Location = new Point(428, 252);
            BotonCerrarOrden.Name = "BotonCerrarOrden";
            BotonCerrarOrden.Size = new Size(161, 23);
            BotonCerrarOrden.TabIndex = 0;
            BotonCerrarOrden.Text = "Cerrar Orden de Inspeccion";
            BotonCerrarOrden.UseVisualStyleBackColor = true;
            BotonCerrarOrden.Click += tomarOpCerrarOrdenInspeccion;
            // 
            // BotonSalir
            // 
            BotonSalir.Location = new Point(206, 252);
            BotonSalir.Name = "BotonSalir";
            BotonSalir.Size = new Size(75, 23);
            BotonSalir.TabIndex = 1;
            BotonSalir.Text = "Salir";
            BotonSalir.UseVisualStyleBackColor = true;
            BotonSalir.Click += botonSalir;
            // 
            // PantallaCerrarOrdenInspeccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(BotonSalir);
            Controls.Add(BotonCerrarOrden);
            Name = "PantallaCerrarOrdenInspeccion";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BotonCerrarOrden;
        private Button BotonSalir;
    }
}