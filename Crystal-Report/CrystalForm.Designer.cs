﻿namespace Crystal_Report
{
    partial class CrystalForm
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
            this.Presentarbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Presentarbutton
            // 
            this.Presentarbutton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Presentarbutton.Location = new System.Drawing.Point(120, 194);
            this.Presentarbutton.Name = "Presentarbutton";
            this.Presentarbutton.Size = new System.Drawing.Size(152, 56);
            this.Presentarbutton.TabIndex = 0;
            this.Presentarbutton.Text = "Presentar Reporte ";
            this.Presentarbutton.UseVisualStyleBackColor = true;
            this.Presentarbutton.Click += new System.EventHandler(this.Presentarbutton_Click);
            // 
            // CrystalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Presentarbutton);
            this.Name = "CrystalForm";
            this.Text = "Crystal Report";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Presentarbutton;
    }
}

