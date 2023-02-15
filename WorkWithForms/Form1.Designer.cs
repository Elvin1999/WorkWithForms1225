namespace WorkWithForms
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
            this.openBtn = new System.Windows.Forms.Button();
            this.dataTxtb = new System.Windows.Forms.TextBox();
            this.nametxtb = new System.Windows.Forms.TextBox();
            this.surnameTxtb = new System.Windows.Forms.TextBox();
            this.ageMaskTxtb = new System.Windows.Forms.MaskedTextBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openBtn
            // 
            this.openBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openBtn.Location = new System.Drawing.Point(396, 105);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(174, 73);
            this.openBtn.TabIndex = 0;
            this.openBtn.Text = "Open Form";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // dataTxtb
            // 
            this.dataTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataTxtb.Location = new System.Drawing.Point(131, 123);
            this.dataTxtb.Name = "dataTxtb";
            this.dataTxtb.Size = new System.Drawing.Size(236, 35);
            this.dataTxtb.TabIndex = 1;
            // 
            // nametxtb
            // 
            this.nametxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nametxtb.Location = new System.Drawing.Point(131, 226);
            this.nametxtb.Name = "nametxtb";
            this.nametxtb.Size = new System.Drawing.Size(236, 35);
            this.nametxtb.TabIndex = 1;
            // 
            // surnameTxtb
            // 
            this.surnameTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameTxtb.Location = new System.Drawing.Point(131, 285);
            this.surnameTxtb.Name = "surnameTxtb";
            this.surnameTxtb.Size = new System.Drawing.Size(236, 35);
            this.surnameTxtb.TabIndex = 1;
            // 
            // ageMaskTxtb
            // 
            this.ageMaskTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageMaskTxtb.Location = new System.Drawing.Point(131, 327);
            this.ageMaskTxtb.Mask = "000";
            this.ageMaskTxtb.Name = "ageMaskTxtb";
            this.ageMaskTxtb.Size = new System.Drawing.Size(236, 44);
            this.ageMaskTxtb.TabIndex = 2;
            this.ageMaskTxtb.ValidatingType = typeof(int);
            // 
            // registerBtn
            // 
            this.registerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerBtn.Location = new System.Drawing.Point(131, 377);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(236, 73);
            this.registerBtn.TabIndex = 0;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(597, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 73);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ageMaskTxtb);
            this.Controls.Add(this.surnameTxtb);
            this.Controls.Add(this.nametxtb);
            this.Controls.Add(this.dataTxtb);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.openBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.TextBox dataTxtb;
        private System.Windows.Forms.TextBox nametxtb;
        private System.Windows.Forms.TextBox surnameTxtb;
        private System.Windows.Forms.MaskedTextBox ageMaskTxtb;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Button button1;
    }
}

