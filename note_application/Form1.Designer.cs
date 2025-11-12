namespace note_application
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
            richTextBoxNot = new RichTextBox();
            menuStrip1 = new MenuStrip();
            dosyaToolStripMenuItem = new ToolStripMenuItem();
            yeniToolStripMenuItem = new ToolStripMenuItem();
            acToolStripMenuItem = new ToolStripMenuItem();
            kaydetToolStripMenuItem = new ToolStripMenuItem();
            farkliKaydetToolStripMenuItem = new ToolStripMenuItem();
            bicimToolStripMenuItem = new ToolStripMenuItem();
            kalinToolStripMenuItem = new ToolStripMenuItem();
            italikToolStripMenuItem = new ToolStripMenuItem();
            altiCiziliToolStripMenuItem = new ToolStripMenuItem();
            cikisToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBoxNot
            // 
            richTextBoxNot.Location = new Point(0, 27);
            richTextBoxNot.Name = "richTextBoxNot";
            richTextBoxNot.Size = new Size(800, 427);
            richTextBoxNot.TabIndex = 0;
            richTextBoxNot.Text = "";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { dosyaToolStripMenuItem, bicimToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            dosyaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { yeniToolStripMenuItem, acToolStripMenuItem, kaydetToolStripMenuItem, farkliKaydetToolStripMenuItem });
            dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            dosyaToolStripMenuItem.Size = new Size(51, 20);
            dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // yeniToolStripMenuItem
            // 
            yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            yeniToolStripMenuItem.Size = new Size(180, 22);
            yeniToolStripMenuItem.Text = "Yeni";
            yeniToolStripMenuItem.Click += yeniToolStripMenuItem_Click;
            // 
            // acToolStripMenuItem
            // 
            acToolStripMenuItem.Name = "acToolStripMenuItem";
            acToolStripMenuItem.Size = new Size(180, 22);
            acToolStripMenuItem.Text = "Aç";
            acToolStripMenuItem.Click += acToolStripMenuItem_Click;
            // 
            // kaydetToolStripMenuItem
            // 
            kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            kaydetToolStripMenuItem.Size = new Size(180, 22);
            kaydetToolStripMenuItem.Text = "Kaydet";
            kaydetToolStripMenuItem.Click += kaydetToolStripMenuItem_Click;
            // 
            // farkliKaydetToolStripMenuItem
            // 
            farkliKaydetToolStripMenuItem.Name = "farkliKaydetToolStripMenuItem";
            farkliKaydetToolStripMenuItem.Size = new Size(180, 22);
            farkliKaydetToolStripMenuItem.Text = "Farklı Kaydet";
            farkliKaydetToolStripMenuItem.Click += farkliKaydetToolStripMenuItem_Click;
            // 
            // bicimToolStripMenuItem
            // 
            bicimToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kalinToolStripMenuItem, italikToolStripMenuItem, altiCiziliToolStripMenuItem, cikisToolStripMenuItem });
            bicimToolStripMenuItem.Name = "bicimToolStripMenuItem";
            bicimToolStripMenuItem.Size = new Size(49, 20);
            bicimToolStripMenuItem.Text = "Biçim";
            // 
            // kalinToolStripMenuItem
            // 
            kalinToolStripMenuItem.Name = "kalinToolStripMenuItem";
            kalinToolStripMenuItem.Size = new Size(120, 22);
            kalinToolStripMenuItem.Text = "Kalın";
            kalinToolStripMenuItem.Click += kalinToolStripMenuItem_Click;
            // 
            // italikToolStripMenuItem
            // 
            italikToolStripMenuItem.Name = "italikToolStripMenuItem";
            italikToolStripMenuItem.Size = new Size(120, 22);
            italikToolStripMenuItem.Text = "İtalik";
            italikToolStripMenuItem.Click += italikToolStripMenuItem_Click;
            // 
            // altiCiziliToolStripMenuItem
            // 
            altiCiziliToolStripMenuItem.Name = "altiCiziliToolStripMenuItem";
            altiCiziliToolStripMenuItem.Size = new Size(120, 22);
            altiCiziliToolStripMenuItem.Text = "Altı Çizili";
            altiCiziliToolStripMenuItem.Click += altiCiziliToolStripMenuItem_Click;
            // 
            // cikisToolStripMenuItem
            // 
            cikisToolStripMenuItem.Name = "cikisToolStripMenuItem";
            cikisToolStripMenuItem.Size = new Size(120, 22);
            cikisToolStripMenuItem.Text = "Çıkış";
            cikisToolStripMenuItem.Click += cikisToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Controls.Add(richTextBoxNot);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBoxNot;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dosyaToolStripMenuItem;
        private ToolStripMenuItem yeniToolStripMenuItem;
        private ToolStripMenuItem acToolStripMenuItem;
        private ToolStripMenuItem kaydetToolStripMenuItem;
        private ToolStripMenuItem farkliKaydetToolStripMenuItem;
        private ToolStripMenuItem bicimToolStripMenuItem;
        private ToolStripMenuItem kalinToolStripMenuItem;
        private ToolStripMenuItem italikToolStripMenuItem;
        private ToolStripMenuItem altiCiziliToolStripMenuItem;
        private ToolStripMenuItem cikisToolStripMenuItem;
    }
}
