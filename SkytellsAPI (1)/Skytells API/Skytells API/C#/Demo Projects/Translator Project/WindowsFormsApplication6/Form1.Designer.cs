namespace WindowsFormsApplication6
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
            this.txtLitter = new System.Windows.Forms.TextBox();
            this.cInputLang = new System.Windows.Forms.ComboBox();
            this.cOutputLang = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLitter
            // 
            this.txtLitter.Location = new System.Drawing.Point(15, 16);
            this.txtLitter.Multiline = true;
            this.txtLitter.Name = "txtLitter";
            this.txtLitter.Size = new System.Drawing.Size(344, 116);
            this.txtLitter.TabIndex = 0;
            // 
            // cInputLang
            // 
            this.cInputLang.FormattingEnabled = true;
            this.cInputLang.Location = new System.Drawing.Point(15, 138);
            this.cInputLang.Name = "cInputLang";
            this.cInputLang.Size = new System.Drawing.Size(74, 21);
            this.cInputLang.TabIndex = 1;
            // 
            // cOutputLang
            // 
            this.cOutputLang.FormattingEnabled = true;
            this.cOutputLang.Location = new System.Drawing.Point(95, 138);
            this.cOutputLang.Name = "cOutputLang";
            this.cOutputLang.Size = new System.Drawing.Size(74, 21);
            this.cOutputLang.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 21);
            this.button1.TabIndex = 3;
            this.button1.Text = "Translate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 172);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cOutputLang);
            this.Controls.Add(this.cInputLang);
            this.Controls.Add(this.txtLitter);
            this.Name = "Form1";
            this.Text = "Skytells Demo Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLitter;
        private System.Windows.Forms.ComboBox cInputLang;
        private System.Windows.Forms.ComboBox cOutputLang;
        private System.Windows.Forms.Button button1;

    }
}

