namespace MorseCodeGenerator
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
            this.to_translate = new System.Windows.Forms.RichTextBox();
            this.translate = new System.Windows.Forms.Label();
            this.sound_button = new System.Windows.Forms.Button();
            this.translated_text = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.translate_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // to_translate
            // 
            this.to_translate.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.to_translate.Location = new System.Drawing.Point(0, 56);
            this.to_translate.Name = "to_translate";
            this.to_translate.Size = new System.Drawing.Size(720, 152);
            this.to_translate.TabIndex = 0;
            this.to_translate.Text = "";
            // 
            // translate
            // 
            this.translate.AutoSize = true;
            this.translate.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.translate.Location = new System.Drawing.Point(264, 8);
            this.translate.Name = "translate";
            this.translate.Size = new System.Drawing.Size(211, 35);
            this.translate.TabIndex = 1;
            this.translate.Text = "Text to translate ";
            this.translate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sound_button
            // 
            this.sound_button.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sound_button.Location = new System.Drawing.Point(8, 504);
            this.sound_button.Name = "sound_button";
            this.sound_button.Size = new System.Drawing.Size(360, 72);
            this.sound_button.TabIndex = 2;
            this.sound_button.Text = "Play";
            this.sound_button.UseVisualStyleBackColor = true;
            this.sound_button.Click += new System.EventHandler(this.sound_button_Click);
            // 
            // translated_text
            // 
            this.translated_text.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.translated_text.Location = new System.Drawing.Point(0, 272);
            this.translated_text.Name = "translated_text";
            this.translated_text.Size = new System.Drawing.Size(720, 168);
            this.translated_text.TabIndex = 3;
            this.translated_text.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(264, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Translated text";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // translate_button
            // 
            this.translate_button.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.translate_button.Location = new System.Drawing.Point(-8, 456);
            this.translate_button.Name = "translate_button";
            this.translate_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.translate_button.Size = new System.Drawing.Size(720, 40);
            this.translate_button.TabIndex = 5;
            this.translate_button.Text = "Translate";
            this.translate_button.UseVisualStyleBackColor = true;
            this.translate_button.Click += new System.EventHandler(this.translate_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 586);
            this.Controls.Add(this.translate_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.translated_text);
            this.Controls.Add(this.sound_button);
            this.Controls.Add(this.translate);
            this.Controls.Add(this.to_translate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox to_translate;
        private System.Windows.Forms.Label translate;
        private System.Windows.Forms.Button sound_button;
        private System.Windows.Forms.RichTextBox translated_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button translate_button;
    }
}

