
namespace eDnevnik
{
    partial class Glavna
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
            this.šifarniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odeljenjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.osobaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.školskaGodinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.podaciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raspodelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oCeneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izveštajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prosekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ForeColor = System.Drawing.Color.AliceBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.šifarniciToolStripMenuItem,
            this.podaciToolStripMenuItem,
            this.izveštajiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // šifarniciToolStripMenuItem
            // 
            this.šifarniciToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.šifarniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odeljenjeToolStripMenuItem,
            this.osobaToolStripMenuItem,
            this.smerToolStripMenuItem,
            this.školskaGodinaToolStripMenuItem});
            this.šifarniciToolStripMenuItem.ForeColor = System.Drawing.Color.AliceBlue;
            this.šifarniciToolStripMenuItem.Name = "šifarniciToolStripMenuItem";
            this.šifarniciToolStripMenuItem.Size = new System.Drawing.Size(79, 23);
            this.šifarniciToolStripMenuItem.Text = "Šifarnici";
            // 
            // odeljenjeToolStripMenuItem
            // 
            this.odeljenjeToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.odeljenjeToolStripMenuItem.Name = "odeljenjeToolStripMenuItem";
            this.odeljenjeToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.odeljenjeToolStripMenuItem.Text = "Odeljenje";
            this.odeljenjeToolStripMenuItem.Click += new System.EventHandler(this.odeljenjeToolStripMenuItem_Click);
            // 
            // osobaToolStripMenuItem
            // 
            this.osobaToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.osobaToolStripMenuItem.Name = "osobaToolStripMenuItem";
            this.osobaToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.osobaToolStripMenuItem.Text = "Osoba";
            this.osobaToolStripMenuItem.Click += new System.EventHandler(this.osobaToolStripMenuItem_Click);
            // 
            // smerToolStripMenuItem
            // 
            this.smerToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.smerToolStripMenuItem.Name = "smerToolStripMenuItem";
            this.smerToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.smerToolStripMenuItem.Text = "Smer";
            this.smerToolStripMenuItem.Click += new System.EventHandler(this.smerToolStripMenuItem_Click);
            // 
            // školskaGodinaToolStripMenuItem
            // 
            this.školskaGodinaToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.školskaGodinaToolStripMenuItem.Name = "školskaGodinaToolStripMenuItem";
            this.školskaGodinaToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.školskaGodinaToolStripMenuItem.Text = "Školska godina";
            this.školskaGodinaToolStripMenuItem.Click += new System.EventHandler(this.školskaGodinaToolStripMenuItem_Click);
            // 
            // podaciToolStripMenuItem
            // 
            this.podaciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raspodelaToolStripMenuItem,
            this.oCeneToolStripMenuItem});
            this.podaciToolStripMenuItem.Name = "podaciToolStripMenuItem";
            this.podaciToolStripMenuItem.Size = new System.Drawing.Size(71, 23);
            this.podaciToolStripMenuItem.Text = "Podaci";
            // 
            // raspodelaToolStripMenuItem
            // 
            this.raspodelaToolStripMenuItem.Name = "raspodelaToolStripMenuItem";
            this.raspodelaToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.raspodelaToolStripMenuItem.Text = "Raspodela";
            // 
            // oCeneToolStripMenuItem
            // 
            this.oCeneToolStripMenuItem.Name = "oCeneToolStripMenuItem";
            this.oCeneToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.oCeneToolStripMenuItem.Text = "Ocene";
            this.oCeneToolStripMenuItem.Click += new System.EventHandler(this.oCeneToolStripMenuItem_Click);
            // 
            // izveštajiToolStripMenuItem
            // 
            this.izveštajiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prosekToolStripMenuItem});
            this.izveštajiToolStripMenuItem.Name = "izveštajiToolStripMenuItem";
            this.izveštajiToolStripMenuItem.Size = new System.Drawing.Size(79, 23);
            this.izveštajiToolStripMenuItem.Text = "Izveštaji";
            // 
            // prosekToolStripMenuItem
            // 
            this.prosekToolStripMenuItem.Name = "prosekToolStripMenuItem";
            this.prosekToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.prosekToolStripMenuItem.Text = "Prosek";
            // 
            // Glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(47)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.AliceBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Glavna";
            this.Text = "Glavna";
            this.Load += new System.EventHandler(this.Glavna_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem šifarniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem osobaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odeljenjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem školskaGodinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem podaciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raspodelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oCeneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izveštajiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prosekToolStripMenuItem;
    }
}