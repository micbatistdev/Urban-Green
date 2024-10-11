namespace tela_de_login.UserControls
{
    partial class PG_About
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            navbrand = new Label();
            SuspendLayout();
            // 
            // navbrand
            // 
            navbrand.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            navbrand.AutoSize = true;
            navbrand.BackColor = Color.Transparent;
            navbrand.Font = new Font("Sans Serif Collection", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            navbrand.ForeColor = Color.Black;
            navbrand.ImeMode = ImeMode.NoControl;
            navbrand.Location = new Point(403, 313);
            navbrand.Name = "navbrand";
            navbrand.Size = new Size(394, 74);
            navbrand.TabIndex = 1;
            navbrand.Text = "Em manutenção";
            // 
            // PG_About
            // 
            AutoScaleDimensions = new SizeF(10F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(navbrand);
            Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 6, 4, 6);
            Name = "PG_About";
            Size = new Size(1200, 700);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label navbrand;
    }
}
