using System;
using System.Windows.Forms;

namespace PassGen
{
    partial class formMain
    {

        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {


            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);          
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCount = new System.Windows.Forms.Label();
            this.labelLength = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonGen = new System.Windows.Forms.Button();
            this.buttonRes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(12, 20);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(114, 13);
            this.labelCount.TabIndex = 0;
            this.labelCount.Text = "Количество паролей:";
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(12, 45);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(94, 13);
            this.labelLength.TabIndex = 1;
            this.labelLength.Text = "Длинна паролей:";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(142, 12);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(234, 20);
            this.textBoxCount.TabIndex = 2;
            // 
            // textBoxLength
            // 
            this.textBoxLength.Location = new System.Drawing.Point(142, 38);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(234, 20);
            this.textBoxLength.TabIndex = 3;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(15, 64);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(361, 153);
            this.textBoxResult.TabIndex = 4;
            // 
            // buttonGen
            // 
            this.buttonGen.Location = new System.Drawing.Point(15, 223);
            this.buttonGen.Name = "buttonGen";
            this.buttonGen.Size = new System.Drawing.Size(88, 23);
            this.buttonGen.TabIndex = 5;
            this.buttonGen.Text = "Генерировать";
            this.buttonGen.UseVisualStyleBackColor = true;
            this.buttonGen.Click += new System.EventHandler(this.buttonGen_Click);
            // 
            // buttonRes
            // 
            this.buttonRes.Location = new System.Drawing.Point(109, 222);
            this.buttonRes.Name = "buttonRes";
            this.buttonRes.Size = new System.Drawing.Size(75, 23);
            this.buttonRes.TabIndex = 6;
            this.buttonRes.Text = "Отчистить";
            this.buttonRes.UseVisualStyleBackColor = true;
            this.buttonRes.Click += new System.EventHandler(this.buttonRes_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(395, 257);
            this.Controls.Add(this.buttonRes);
            this.Controls.Add(this.buttonGen);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxLength);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.labelLength);
            this.Controls.Add(this.labelCount);
            this.Name = "formMain";
            this.Text = "Генератор паролей";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.TextBox textBoxLength;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonGen;
        private System.Windows.Forms.Button buttonRes;


        
    }

}

