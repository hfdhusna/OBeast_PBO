namespace BMI_Calculator
{
    partial class Form3
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
            this.weight = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.radbtnMale = new System.Windows.Forms.RadioButton();
            this.radbtnFemale = new System.Windows.Forms.RadioButton();
            this.birthDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // weight
            // 
            this.weight.AutoSize = true;
            this.weight.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight.Location = new System.Drawing.Point(56, 66);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(109, 27);
            this.weight.TabIndex = 7;
            this.weight.Text = "Birthdate";
            this.weight.Click += new System.EventHandler(this.weight_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "Weight (kg)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtWeight.Location = new System.Drawing.Point(61, 228);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(204, 23);
            this.txtWeight.TabIndex = 10;
            this.txtWeight.Text = "Weight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 27);
            this.label2.TabIndex = 11;
            this.label2.Text = "Height (cm)";
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtHeight.Location = new System.Drawing.Point(61, 297);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(204, 23);
            this.txtHeight.TabIndex = 12;
            this.txtHeight.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 27);
            this.label3.TabIndex = 13;
            this.label3.Text = "Gender";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSaveChanges.Font = new System.Drawing.Font("Montserrat Medium", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.Location = new System.Drawing.Point(153, 357);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(112, 25);
            this.btnSaveChanges.TabIndex = 16;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BMI_Calculator.Properties.Resources._50116451_1b45_4a42_9192_84151fc582e5_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(354, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(414, 324);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::BMI_Calculator.Properties.Resources.rndm1_removebg_preview;
            this.pictureBox6.Location = new System.Drawing.Point(687, 357);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(245, 191);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 17;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::BMI_Calculator.Properties.Resources.rndm1_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(237, -106);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(245, 191);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // radbtnMale
            // 
            this.radbtnMale.AutoSize = true;
            this.radbtnMale.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnMale.Location = new System.Drawing.Point(61, 163);
            this.radbtnMale.Name = "radbtnMale";
            this.radbtnMale.Size = new System.Drawing.Size(61, 22);
            this.radbtnMale.TabIndex = 19;
            this.radbtnMale.TabStop = true;
            this.radbtnMale.Text = "Male";
            this.radbtnMale.UseVisualStyleBackColor = true;
            this.radbtnMale.CheckedChanged += new System.EventHandler(this.radbtnMale_CheckedChanged);
            // 
            // radbtnFemale
            // 
            this.radbtnFemale.AutoSize = true;
            this.radbtnFemale.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnFemale.Location = new System.Drawing.Point(128, 163);
            this.radbtnFemale.Name = "radbtnFemale";
            this.radbtnFemale.Size = new System.Drawing.Size(79, 22);
            this.radbtnFemale.TabIndex = 20;
            this.radbtnFemale.TabStop = true;
            this.radbtnFemale.Text = "Female";
            this.radbtnFemale.UseVisualStyleBackColor = true;
            this.radbtnFemale.CheckedChanged += new System.EventHandler(this.radbtnFemale_CheckedChanged);
            // 
            // birthDate
            // 
            this.birthDate.CalendarFont = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDate.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDate.Location = new System.Drawing.Point(61, 97);
            this.birthDate.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.birthDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(200, 23);
            this.birthDate.TabIndex = 21;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(808, 460);
            this.Controls.Add(this.birthDate);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.radbtnFemale);
            this.Controls.Add(this.radbtnMale);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.weight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form3";
            this.Text = "User Data Input";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label weight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton radbtnMale;
        private System.Windows.Forms.RadioButton radbtnFemale;
        private System.Windows.Forms.DateTimePicker birthDate;
    }
}