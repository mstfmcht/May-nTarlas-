namespace MayinTarlasiOrnek
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oyunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ortaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oyunToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // oyunToolStripMenuItem
            // 
            resources.ApplyResources(this.oyunToolStripMenuItem, "oyunToolStripMenuItem");
            this.oyunToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kolayToolStripMenuItem,
            this.ortaToolStripMenuItem,
            this.zorToolStripMenuItem});
            this.oyunToolStripMenuItem.Name = "oyunToolStripMenuItem";
            // 
            // kolayToolStripMenuItem
            // 
            resources.ApplyResources(this.kolayToolStripMenuItem, "kolayToolStripMenuItem");
            this.kolayToolStripMenuItem.Name = "kolayToolStripMenuItem";
            this.kolayToolStripMenuItem.Click += new System.EventHandler(this.kolayToolStripMenuItem_Click);
            // 
            // ortaToolStripMenuItem
            // 
            resources.ApplyResources(this.ortaToolStripMenuItem, "ortaToolStripMenuItem");
            this.ortaToolStripMenuItem.Name = "ortaToolStripMenuItem";
            this.ortaToolStripMenuItem.Click += new System.EventHandler(this.ortaToolStripMenuItem_Click);
            // 
            // zorToolStripMenuItem
            // 
            resources.ApplyResources(this.zorToolStripMenuItem, "zorToolStripMenuItem");
            this.zorToolStripMenuItem.Name = "zorToolStripMenuItem";
            this.zorToolStripMenuItem.Click += new System.EventHandler(this.zorToolStripMenuItem_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oyunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ortaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zorToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

