namespace tapsiriq4
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
            this.lblSual = new System.Windows.Forms.Label();
            this.grpCavablar = new System.Windows.Forms.GroupBox();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.btnNovbeti = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.grpCavablar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSual
            // 
            this.lblSual.AutoSize = true;
            this.lblSual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblSual.Location = new System.Drawing.Point(43, 22);
            this.lblSual.Name = "lblSual";
            this.lblSual.Size = new System.Drawing.Size(92, 29);
            this.lblSual.TabIndex = 0;
            this.lblSual.Text = "Suallar";
            // 
            // grpCavablar
            // 
            this.grpCavablar.Controls.Add(this.rb4);
            this.grpCavablar.Controls.Add(this.rb1);
            this.grpCavablar.Controls.Add(this.rb3);
            this.grpCavablar.Controls.Add(this.rb2);
            this.grpCavablar.Location = new System.Drawing.Point(46, 56);
            this.grpCavablar.Name = "grpCavablar";
            this.grpCavablar.Size = new System.Drawing.Size(200, 123);
            this.grpCavablar.TabIndex = 1;
            this.grpCavablar.TabStop = false;
            this.grpCavablar.Text = "variantlar";
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(6, 21);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(37, 20);
            this.rb1.TabIndex = 2;
            this.rb1.TabStop = true;
            this.rb1.Text = "A";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(6, 47);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(37, 20);
            this.rb2.TabIndex = 3;
            this.rb2.TabStop = true;
            this.rb2.Text = "B";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(6, 73);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(37, 20);
            this.rb3.TabIndex = 4;
            this.rb3.TabStop = true;
            this.rb3.Text = "C";
            this.rb3.UseVisualStyleBackColor = true;
            this.rb3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(6, 99);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(38, 20);
            this.rb4.TabIndex = 5;
            this.rb4.TabStop = true;
            this.rb4.Text = "D";
            this.rb4.UseVisualStyleBackColor = true;
            this.rb4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // btnNovbeti
            // 
            this.btnNovbeti.Location = new System.Drawing.Point(46, 200);
            this.btnNovbeti.Name = "btnNovbeti";
            this.btnNovbeti.Size = new System.Drawing.Size(75, 23);
            this.btnNovbeti.TabIndex = 2;
            this.btnNovbeti.Text = "sonraki";
            this.btnNovbeti.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(46, 265);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnNovbeti);
            this.Controls.Add(this.grpCavablar);
            this.Controls.Add(this.lblSual);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpCavablar.ResumeLayout(false);
            this.grpCavablar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSual;
        private System.Windows.Forms.GroupBox grpCavablar;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.Button btnNovbeti;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

