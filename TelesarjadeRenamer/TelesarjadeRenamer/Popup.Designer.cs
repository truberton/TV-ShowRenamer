﻿namespace TelesarjadeRenamer
{
    partial class Popup
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
            this.label1 = new System.Windows.Forms.Label();
            this.failiTüüp_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nimi_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EsimeneOsa_textbox = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mis tüüpi failid need on? (.mp4, .avi, .wma jne)";
            // 
            // failiTüüp_textbox
            // 
            this.failiTüüp_textbox.Location = new System.Drawing.Point(12, 26);
            this.failiTüüp_textbox.Name = "failiTüüp_textbox";
            this.failiTüüp_textbox.Size = new System.Drawing.Size(104, 20);
            this.failiTüüp_textbox.TabIndex = 1;
            this.failiTüüp_textbox.TextChanged += new System.EventHandler(this.failiTüüp_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mis tahad, et faili nimi oleks? (Näide: S01E*, tärni osa küsin hiljem)";
            // 
            // nimi_textbox
            // 
            this.nimi_textbox.Location = new System.Drawing.Point(12, 66);
            this.nimi_textbox.Name = "nimi_textbox";
            this.nimi_textbox.Size = new System.Drawing.Size(104, 20);
            this.nimi_textbox.TabIndex = 3;
            this.nimi_textbox.TextChanged += new System.EventHandler(this.nimi_textbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mis osast/episoodist alustada? (See tärn)";
            // 
            // EsimeneOsa_textbox
            // 
            this.EsimeneOsa_textbox.Location = new System.Drawing.Point(12, 105);
            this.EsimeneOsa_textbox.Name = "EsimeneOsa_textbox";
            this.EsimeneOsa_textbox.Size = new System.Drawing.Size(104, 20);
            this.EsimeneOsa_textbox.TabIndex = 5;
            this.EsimeneOsa_textbox.TextChanged += new System.EventHandler(this.EsimeneOsa_textbox_TextChanged);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(12, 152);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 6;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(107, 171);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(158, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Episoodi numbri ette ei käi 0";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(107, 143);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(166, 17);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Ainult ühte faili tüüpi renamein";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 210);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.EsimeneOsa_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nimi_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.failiTüüp_textbox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Popup";
            this.Text = "Rename";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox failiTüüp_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nimi_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EsimeneOsa_textbox;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}