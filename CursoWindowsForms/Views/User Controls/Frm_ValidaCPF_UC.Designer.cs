﻿namespace CursoWindowsForms.User_Controls
{
    partial class Frm_ValidaCPF_UC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Valida = new System.Windows.Forms.Button();
            this.Btn_Reset = new System.Windows.Forms.Button();
            this.Lbl_Resultado = new System.Windows.Forms.Label();
            this.Msk_CPF = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Btn_Valida
            // 
            this.Btn_Valida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Valida.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Valida.Location = new System.Drawing.Point(253, 92);
            this.Btn_Valida.Name = "Btn_Valida";
            this.Btn_Valida.Size = new System.Drawing.Size(111, 23);
            this.Btn_Valida.TabIndex = 7;
            this.Btn_Valida.Text = "Valida";
            this.Btn_Valida.UseVisualStyleBackColor = true;
            this.Btn_Valida.Click += new System.EventHandler(this.Btn_Valida_Click);
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Reset.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Reset.Location = new System.Drawing.Point(253, 63);
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Size = new System.Drawing.Size(111, 23);
            this.Btn_Reset.TabIndex = 6;
            this.Btn_Reset.Text = "Limpa";
            this.Btn_Reset.UseVisualStyleBackColor = true;
            this.Btn_Reset.Click += new System.EventHandler(this.Btn_Reset_Click);
            // 
            // Lbl_Resultado
            // 
            this.Lbl_Resultado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_Resultado.AutoSize = true;
            this.Lbl_Resultado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Resultado.Location = new System.Drawing.Point(20, 111);
            this.Lbl_Resultado.Name = "Lbl_Resultado";
            this.Lbl_Resultado.Size = new System.Drawing.Size(0, 19);
            this.Lbl_Resultado.TabIndex = 5;
            // 
            // Msk_CPF
            // 
            this.Msk_CPF.Location = new System.Drawing.Point(20, 66);
            this.Msk_CPF.Mask = "000,000,000-00";
            this.Msk_CPF.Name = "Msk_CPF";
            this.Msk_CPF.Size = new System.Drawing.Size(218, 20);
            this.Msk_CPF.TabIndex = 4;
            // 
            // Frm_ValidaCPF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_Valida);
            this.Controls.Add(this.Btn_Reset);
            this.Controls.Add(this.Lbl_Resultado);
            this.Controls.Add(this.Msk_CPF);
            this.Name = "Frm_ValidaCPF";
            this.Size = new System.Drawing.Size(384, 193);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Valida;
        private System.Windows.Forms.Button Btn_Reset;
        private System.Windows.Forms.Label Lbl_Resultado;
        private System.Windows.Forms.MaskedTextBox Msk_CPF;
    }
}