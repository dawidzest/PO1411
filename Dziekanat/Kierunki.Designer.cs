﻿namespace Dziekanat
{
    partial class Kierunki
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
            this.KierListbox = new System.Windows.Forms.ListBox();
            this.KierHeader = new System.Windows.Forms.Label();
            this.PowrotKierButton = new System.Windows.Forms.Button();
            this.StworzKierButton = new System.Windows.Forms.Button();
            this.ListaKierLabel = new System.Windows.Forms.Label();
            this.DodajStudButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KierListbox
            // 
            this.KierListbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.KierListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KierListbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.KierListbox.FormattingEnabled = true;
            this.KierListbox.Location = new System.Drawing.Point(28, 115);
            this.KierListbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.KierListbox.Name = "KierListbox";
            this.KierListbox.Size = new System.Drawing.Size(356, 158);
            this.KierListbox.TabIndex = 7;
            // 
            // KierHeader
            // 
            this.KierHeader.AutoSize = true;
            this.KierHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold);
            this.KierHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.KierHeader.Location = new System.Drawing.Point(22, 32);
            this.KierHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.KierHeader.Name = "KierHeader";
            this.KierHeader.Size = new System.Drawing.Size(118, 37);
            this.KierHeader.TabIndex = 8;
            this.KierHeader.Text = "Kierunki";
            // 
            // PowrotKierButton
            // 
            this.PowrotKierButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.PowrotKierButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.PowrotKierButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.PowrotKierButton.Location = new System.Drawing.Point(272, 369);
            this.PowrotKierButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PowrotKierButton.Name = "PowrotKierButton";
            this.PowrotKierButton.Size = new System.Drawing.Size(112, 50);
            this.PowrotKierButton.TabIndex = 13;
            this.PowrotKierButton.Text = "Powrot";
            this.PowrotKierButton.UseVisualStyleBackColor = false;
            this.PowrotKierButton.Click += new System.EventHandler(this.PowrotKierButton_Click);
            // 
            // StworzKierButton
            // 
            this.StworzKierButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.StworzKierButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.StworzKierButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.StworzKierButton.Location = new System.Drawing.Point(28, 277);
            this.StworzKierButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StworzKierButton.Name = "StworzKierButton";
            this.StworzKierButton.Size = new System.Drawing.Size(172, 50);
            this.StworzKierButton.TabIndex = 14;
            this.StworzKierButton.Text = "Stworz kierunek";
            this.StworzKierButton.UseVisualStyleBackColor = false;
            this.StworzKierButton.Click += new System.EventHandler(this.StworzKierButton_Click);
            // 
            // ListaKierLabel
            // 
            this.ListaKierLabel.AutoSize = true;
            this.ListaKierLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.ListaKierLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ListaKierLabel.Location = new System.Drawing.Point(25, 92);
            this.ListaKierLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ListaKierLabel.Name = "ListaKierLabel";
            this.ListaKierLabel.Size = new System.Drawing.Size(123, 20);
            this.ListaKierLabel.TabIndex = 16;
            this.ListaKierLabel.Text = "Lista kierunkow:";
            // 
            // DodajStudButton
            // 
            this.DodajStudButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.DodajStudButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.DodajStudButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.DodajStudButton.Location = new System.Drawing.Point(212, 277);
            this.DodajStudButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DodajStudButton.Name = "DodajStudButton";
            this.DodajStudButton.Size = new System.Drawing.Size(172, 50);
            this.DodajStudButton.TabIndex = 17;
            this.DodajStudButton.Text = "Dodaj studenta";
            this.DodajStudButton.UseVisualStyleBackColor = false;
            this.DodajStudButton.Click += new System.EventHandler(this.DodajStudButton_Click);
            // 
            // Kierunki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(414, 443);
            this.Controls.Add(this.DodajStudButton);
            this.Controls.Add(this.ListaKierLabel);
            this.Controls.Add(this.StworzKierButton);
            this.Controls.Add(this.PowrotKierButton);
            this.Controls.Add(this.KierHeader);
            this.Controls.Add(this.KierListbox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Kierunki";
            this.Text = "Dziekanat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox KierListbox;
        private System.Windows.Forms.Label KierHeader;
        private System.Windows.Forms.Button PowrotKierButton;
        private System.Windows.Forms.Button StworzKierButton;
        private System.Windows.Forms.Label ListaKierLabel;
        private System.Windows.Forms.Button DodajStudButton;
    }
}