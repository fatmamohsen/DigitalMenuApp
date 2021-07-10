namespace WindowsFormsApplication4
{
    partial class inputform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inputform));
            this.codebox = new System.Windows.Forms.TextBox();
            this.numberbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sizebox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.okp = new System.Windows.Forms.Button();
            this.cancelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // codebox
            // 
            this.codebox.Location = new System.Drawing.Point(217, 82);
            this.codebox.Name = "codebox";
            this.codebox.Size = new System.Drawing.Size(148, 20);
            this.codebox.TabIndex = 0;
            this.codebox.TextChanged += new System.EventHandler(this.codebox_TextChanged);
            // 
            // numberbox
            // 
            this.numberbox.Location = new System.Drawing.Point(217, 133);
            this.numberbox.Name = "numberbox";
            this.numberbox.Size = new System.Drawing.Size(148, 20);
            this.numberbox.TabIndex = 1;
            this.numberbox.TextChanged += new System.EventHandler(this.numberbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "CODE :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.label2.Location = new System.Drawing.Point(110, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "NUMBER : ";
            // 
            // sizebox
            // 
            this.sizebox.FormattingEnabled = true;
            this.sizebox.Location = new System.Drawing.Point(196, 195);
            this.sizebox.Name = "sizebox";
            this.sizebox.Size = new System.Drawing.Size(169, 21);
            this.sizebox.TabIndex = 4;
            this.sizebox.SelectedIndexChanged += new System.EventHandler(this.sizebox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.label3.Location = new System.Drawing.Point(110, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "SIZE :";
            // 
            // okp
            // 
            this.okp.Location = new System.Drawing.Point(413, 322);
            this.okp.Name = "okp";
            this.okp.Size = new System.Drawing.Size(75, 30);
            this.okp.TabIndex = 6;
            this.okp.Text = "Ok";
            this.okp.UseVisualStyleBackColor = true;
            this.okp.Click += new System.EventHandler(this.okp_Click);
            // 
            // cancelp
            // 
            this.cancelp.Location = new System.Drawing.Point(332, 322);
            this.cancelp.Name = "cancelp";
            this.cancelp.Size = new System.Drawing.Size(75, 30);
            this.cancelp.TabIndex = 7;
            this.cancelp.Text = "Cancel";
            this.cancelp.UseVisualStyleBackColor = true;
            this.cancelp.Click += new System.EventHandler(this.cancelp_Click);
            // 
            // inputform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(500, 364);
            this.Controls.Add(this.cancelp);
            this.Controls.Add(this.okp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sizebox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberbox);
            this.Controls.Add(this.codebox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "inputform";
            this.Text = "inputform";
            this.Load += new System.EventHandler(this.inputform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codebox;
        private System.Windows.Forms.TextBox numberbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sizebox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button okp;
        private System.Windows.Forms.Button cancelp;
    }
}