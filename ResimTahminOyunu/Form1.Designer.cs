namespace ResimTahminOyunu
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
            this.pbBig = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.btnTahmin = new System.Windows.Forms.Button();
            this.rb2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbBig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBig
            // 
            this.pbBig.Location = new System.Drawing.Point(12, 12);
            this.pbBig.Name = "pbBig";
            this.pbBig.Size = new System.Drawing.Size(569, 335);
            this.pbBig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBig.TabIndex = 0;
            this.pbBig.TabStop = false;
            // 
            // pb1
            // 
            this.pb1.Image = global::ResimTahminOyunu.Properties.Resources.image1;
            this.pb1.Location = new System.Drawing.Point(12, 374);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(129, 73);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 1;
            this.pb1.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Image = global::ResimTahminOyunu.Properties.Resources.image2;
            this.pb2.Location = new System.Drawing.Point(236, 374);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(129, 73);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 2;
            this.pb2.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.Image = global::ResimTahminOyunu.Properties.Resources.image3;
            this.pb3.Location = new System.Drawing.Point(452, 374);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(129, 73);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb3.TabIndex = 3;
            this.pb3.TabStop = false;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Checked = true;
            this.rb1.Location = new System.Drawing.Point(67, 453);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(14, 13);
            this.rb1.TabIndex = 4;
            this.rb1.TabStop = true;
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.CheckedChanged += new System.EventHandler(this.rb1_CheckedChanged);
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(509, 453);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(14, 13);
            this.rb3.TabIndex = 6;
            this.rb3.UseVisualStyleBackColor = true;
            this.rb3.CheckedChanged += new System.EventHandler(this.rb3_CheckedChanged);
            // 
            // btnTahmin
            // 
            this.btnTahmin.Enabled = false;
            this.btnTahmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTahmin.Location = new System.Drawing.Point(258, 474);
            this.btnTahmin.Name = "btnTahmin";
            this.btnTahmin.Size = new System.Drawing.Size(75, 30);
            this.btnTahmin.TabIndex = 7;
            this.btnTahmin.Text = "TAHMİN";
            this.btnTahmin.UseVisualStyleBackColor = true;
            this.btnTahmin.Click += new System.EventHandler(this.btnTahmin_Click);
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(290, 453);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(14, 13);
            this.rb2.TabIndex = 8;
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 516);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.btnTahmin);
            this.Controls.Add(this.rb3);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.pbBig);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBig;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.Button btnTahmin;
        private System.Windows.Forms.RadioButton rb2;
    }
}

