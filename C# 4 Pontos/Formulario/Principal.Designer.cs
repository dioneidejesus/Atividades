namespace Formulario
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tela1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tela2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tela3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tela4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.alunosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(620, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tela1ToolStripMenuItem,
            this.tela2ToolStripMenuItem,
            this.tela3ToolStripMenuItem,
            this.tela4ToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // tela1ToolStripMenuItem
            // 
            this.tela1ToolStripMenuItem.Name = "tela1ToolStripMenuItem";
            this.tela1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tela1ToolStripMenuItem.Text = "Tela1";
            this.tela1ToolStripMenuItem.Click += new System.EventHandler(this.tela1ToolStripMenuItem_Click);
            // 
            // tela2ToolStripMenuItem
            // 
            this.tela2ToolStripMenuItem.Name = "tela2ToolStripMenuItem";
            this.tela2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tela2ToolStripMenuItem.Text = "Tela2";
            this.tela2ToolStripMenuItem.Click += new System.EventHandler(this.tela2ToolStripMenuItem_Click);
            // 
            // tela3ToolStripMenuItem
            // 
            this.tela3ToolStripMenuItem.Name = "tela3ToolStripMenuItem";
            this.tela3ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tela3ToolStripMenuItem.Text = "Tela3";
            this.tela3ToolStripMenuItem.Click += new System.EventHandler(this.tela3ToolStripMenuItem_Click);
            // 
            // tela4ToolStripMenuItem
            // 
            this.tela4ToolStripMenuItem.Name = "tela4ToolStripMenuItem";
            this.tela4ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tela4ToolStripMenuItem.Text = "Tela4";
            this.tela4ToolStripMenuItem.Click += new System.EventHandler(this.tela4ToolStripMenuItem_Click);
            // 
            // alunosToolStripMenuItem
            // 
            this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            this.alunosToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.alunosToolStripMenuItem.Text = "Alunos";
            this.alunosToolStripMenuItem.Click += new System.EventHandler(this.alunosToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(620, 461);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tela1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tela2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tela3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tela4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem;
    }
}