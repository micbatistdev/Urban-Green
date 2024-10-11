namespace tela_de_logins
{
    partial class TelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            min_win = new Guna.UI2.WinForms.Guna2Button();
            max_win = new Guna.UI2.WinForms.Guna2Button();
            win_close = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // min_win
            // 
            resources.ApplyResources(min_win, "min_win");
            min_win.BackColor = Color.Transparent;
            min_win.CustomizableEdges = customizableEdges1;
            min_win.DisabledState.BorderColor = Color.DarkGray;
            min_win.DisabledState.CustomBorderColor = Color.DarkGray;
            min_win.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            min_win.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            min_win.FillColor = Color.Transparent;
            min_win.ForeColor = Color.White;
            min_win.Name = "min_win";
            min_win.ShadowDecoration.CustomizableEdges = customizableEdges2;
            // 
            // max_win
            // 
            resources.ApplyResources(max_win, "max_win");
            max_win.BackColor = Color.Transparent;
            max_win.CustomizableEdges = customizableEdges3;
            max_win.DisabledState.BorderColor = Color.DarkGray;
            max_win.DisabledState.CustomBorderColor = Color.DarkGray;
            max_win.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            max_win.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            max_win.FillColor = Color.Transparent;
            max_win.ForeColor = Color.White;
            max_win.Name = "max_win";
            max_win.ShadowDecoration.CustomizableEdges = customizableEdges4;
            // 
            // win_close
            // 
            resources.ApplyResources(win_close, "win_close");
            win_close.BackColor = Color.Transparent;
            win_close.CustomizableEdges = customizableEdges5;
            win_close.DisabledState.BorderColor = Color.DarkGray;
            win_close.DisabledState.CustomBorderColor = Color.DarkGray;
            win_close.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            win_close.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            win_close.FillColor = Color.Transparent;
            win_close.ForeColor = Color.White;
            win_close.Name = "win_close";
            win_close.ShadowDecoration.CustomizableEdges = customizableEdges6;
            win_close.Click += win_close_Click;
            // 
            // TelaInicial
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.None;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.SeaGreen;
            Controls.Add(min_win);
            Controls.Add(max_win);
            Controls.Add(win_close);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TelaInicial";
            Load += TelaInicial_Load;
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button min_win;
        private Guna.UI2.WinForms.Guna2Button max_win;
        private Guna.UI2.WinForms.Guna2Button win_close;
    }
}