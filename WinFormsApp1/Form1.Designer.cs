namespace WinFormsApp1
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
            menuStrip1 = new MenuStrip();
            uygulamaToolStripMenuItem = new ToolStripMenuItem();
            çıkışToolStripMenuItem = new ToolStripMenuItem();
            formlarToolStripMenuItem = new ToolStripMenuItem();
            markalarToolStripMenuItem = new ToolStripMenuItem();
            modellerToolStripMenuItem = new ToolStripMenuItem();
            arabalarToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { uygulamaToolStripMenuItem, formlarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1272, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // uygulamaToolStripMenuItem
            // 
            uygulamaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { çıkışToolStripMenuItem });
            uygulamaToolStripMenuItem.Name = "uygulamaToolStripMenuItem";
            uygulamaToolStripMenuItem.Size = new Size(108, 29);
            uygulamaToolStripMenuItem.Text = "Uygulama";
            // 
            // çıkışToolStripMenuItem
            // 
            çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            çıkışToolStripMenuItem.Size = new Size(150, 34);
            çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // formlarToolStripMenuItem
            // 
            formlarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { markalarToolStripMenuItem, modellerToolStripMenuItem, arabalarToolStripMenuItem });
            formlarToolStripMenuItem.Name = "formlarToolStripMenuItem";
            formlarToolStripMenuItem.Size = new Size(89, 29);
            formlarToolStripMenuItem.Text = "Formlar";
            // 
            // markalarToolStripMenuItem
            // 
            markalarToolStripMenuItem.Name = "markalarToolStripMenuItem";
            markalarToolStripMenuItem.Size = new Size(270, 34);
            markalarToolStripMenuItem.Text = "Markalar";
            markalarToolStripMenuItem.Click += markalarToolStripMenuItem_Click;
            // 
            // modellerToolStripMenuItem
            // 
            modellerToolStripMenuItem.Name = "modellerToolStripMenuItem";
            modellerToolStripMenuItem.Size = new Size(270, 34);
            modellerToolStripMenuItem.Text = "Modeller";
            // 
            // arabalarToolStripMenuItem
            // 
            arabalarToolStripMenuItem.Name = "arabalarToolStripMenuItem";
            arabalarToolStripMenuItem.Size = new Size(270, 34);
            arabalarToolStripMenuItem.Text = "Arabalar";
            arabalarToolStripMenuItem.Click += arabalarToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1272, 761);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem uygulamaToolStripMenuItem;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private ToolStripMenuItem formlarToolStripMenuItem;
        private ToolStripMenuItem markalarToolStripMenuItem;
        private ToolStripMenuItem modellerToolStripMenuItem;
        private ToolStripMenuItem arabalarToolStripMenuItem;
    }
}