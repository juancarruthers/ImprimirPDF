namespace ImprmirPdf
{
    partial class ImprimirPDF
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
            btImprimir = new Button();
            SuspendLayout();
            // 
            // btImprimir
            // 
            btImprimir.BackColor = Color.DarkSeaGreen;
            btImprimir.FlatAppearance.BorderSize = 0;
            btImprimir.FlatStyle = FlatStyle.Flat;
            btImprimir.Font = new Font("Sylfaen", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btImprimir.Location = new Point(328, 167);
            btImprimir.Name = "btImprimir";
            btImprimir.Size = new Size(94, 44);
            btImprimir.TabIndex = 1;
            btImprimir.Text = "Generar Factura";
            btImprimir.UseVisualStyleBackColor = false;
            btImprimir.Click += btImprimir_Click;
            // 
            // ImprimirPDF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btImprimir);
            Name = "ImprimirPDF";
            Text = "ImprimirPDF";
            Load += ImprimirPDF_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btImprimir;
    }
}