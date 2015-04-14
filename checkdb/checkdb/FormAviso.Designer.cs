namespace checkdb
{
    partial class FormAviso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAviso));
            this.buttonAceitaTermos = new System.Windows.Forms.Button();
            this.checkBoxTermos = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonAceitaTermos
            // 
            this.buttonAceitaTermos.Enabled = false;
            this.buttonAceitaTermos.Location = new System.Drawing.Point(229, 345);
            this.buttonAceitaTermos.Name = "buttonAceitaTermos";
            this.buttonAceitaTermos.Size = new System.Drawing.Size(75, 23);
            this.buttonAceitaTermos.TabIndex = 0;
            this.buttonAceitaTermos.Text = "Ok";
            this.buttonAceitaTermos.UseVisualStyleBackColor = true;
            this.buttonAceitaTermos.Click += new System.EventHandler(this.buttonAceitaTermos_Click);
            // 
            // checkBoxTermos
            // 
            this.checkBoxTermos.AutoSize = true;
            this.checkBoxTermos.Location = new System.Drawing.Point(12, 309);
            this.checkBoxTermos.Name = "checkBoxTermos";
            this.checkBoxTermos.Size = new System.Drawing.Size(159, 17);
            this.checkBoxTermos.TabIndex = 1;
            this.checkBoxTermos.Text = "Li e aceitei os termos acima.";
            this.checkBoxTermos.UseVisualStyleBackColor = true;
            this.checkBoxTermos.CheckedChanged += new System.EventHandler(this.checkBoxTermos_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(536, 291);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Form2
            // 
            this.AcceptButton = this.buttonAceitaTermos;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 410);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.checkBoxTermos);
            this.Controls.Add(this.buttonAceitaTermos);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAceitaTermos;
        private System.Windows.Forms.CheckBox checkBoxTermos;
        private System.Windows.Forms.RichTextBox richTextBox1;

    }
}