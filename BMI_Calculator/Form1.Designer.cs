namespace BMI_Calculator
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
            this.JUDUL = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.weight = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.Label();
            this.weightBox = new System.Windows.Forms.TextBox();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // JUDUL
            // 
            this.JUDUL.AutoSize = true;
            this.JUDUL.BackColor = System.Drawing.Color.Transparent;
            this.JUDUL.Font = new System.Drawing.Font("Montserrat Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JUDUL.Location = new System.Drawing.Point(265, 67);
            this.JUDUL.Name = "JUDUL";
            this.JUDUL.Size = new System.Drawing.Size(195, 27);
            this.JUDUL.TabIndex = 0;
            this.JUDUL.Text = "YOUR PROGRESS";
            this.JUDUL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.JUDUL.Click += new System.EventHandler(this.label1_Click);
            // 
            // weight
            // 
            this.weight.AutoSize = true;
            this.weight.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight.Location = new System.Drawing.Point(51, 119);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(135, 27);
            this.weight.TabIndex = 1;
            this.weight.Text = "Weight (Kg)";
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.height.Location = new System.Drawing.Point(53, 227);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(133, 27);
            this.height.TabIndex = 2;
            this.height.Text = "Height (cm)";
            // 
            // weightBox
            // 
            this.weightBox.Location = new System.Drawing.Point(56, 164);
            this.weightBox.Name = "weightBox";
            this.weightBox.Size = new System.Drawing.Size(195, 22);
            this.weightBox.TabIndex = 3;
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(56, 268);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(195, 22);
            this.heightBox.TabIndex = 4;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(410, 119);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(88, 27);
            this.result.TabIndex = 5;
            this.result.Text = "Result :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(493, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::BMI_Calculator.Properties.Resources.rndm1_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(-123, -126);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(245, 191);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::BMI_Calculator.Properties.Resources.rndm1_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(-46, 347);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::BMI_Calculator.Properties.Resources.rndm1_removebg_preview;
            this.pictureBox6.Location = new System.Drawing.Point(585, -78);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(245, 191);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 14;
            this.pictureBox6.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 46);
            this.label1.TabIndex = 18;
            this.label1.Text = "Track";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(767, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.weightBox);
            this.Controls.Add(this.height);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.JUDUL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "BMI Calculator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label JUDUL;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label weight;
        private System.Windows.Forms.Label height;
        private System.Windows.Forms.TextBox weightBox;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}

