namespace HomeImager
{
    partial class GUI
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
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mDown = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.mLeft = new System.Windows.Forms.Button();
            this.mRight = new System.Windows.Forms.Button();
            this.mUp = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.scan = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.bUp = new System.Windows.Forms.Button();
            this.bRight = new System.Windows.Forms.Button();
            this.bLeft = new System.Windows.Forms.Button();
            this.bDown = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 465);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Select video device:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 481);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(583, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(583, 436);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // mDown
            // 
            this.mDown.Location = new System.Drawing.Point(626, 135);
            this.mDown.Name = "mDown";
            this.mDown.Size = new System.Drawing.Size(113, 23);
            this.mDown.TabIndex = 2;
            this.mDown.Text = "Down mid";
            this.mDown.UseVisualStyleBackColor = true;
            this.mDown.Click += new System.EventHandler(this.mDown_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(626, 29);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(169, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // mLeft
            // 
            this.mLeft.Location = new System.Drawing.Point(626, 164);
            this.mLeft.Name = "mLeft";
            this.mLeft.Size = new System.Drawing.Size(113, 23);
            this.mLeft.TabIndex = 6;
            this.mLeft.Text = "Left mid";
            this.mLeft.UseVisualStyleBackColor = true;
            this.mLeft.Click += new System.EventHandler(this.mLeft_Click);
            // 
            // mRight
            // 
            this.mRight.Location = new System.Drawing.Point(626, 193);
            this.mRight.Name = "mRight";
            this.mRight.Size = new System.Drawing.Size(113, 23);
            this.mRight.TabIndex = 7;
            this.mRight.Text = "Right mid";
            this.mRight.UseVisualStyleBackColor = true;
            this.mRight.Click += new System.EventHandler(this.mRight_Click);
            // 
            // mUp
            // 
            this.mUp.Location = new System.Drawing.Point(626, 106);
            this.mUp.Name = "mUp";
            this.mUp.Size = new System.Drawing.Size(113, 23);
            this.mUp.TabIndex = 9;
            this.mUp.Text = "Up mid";
            this.mUp.UseVisualStyleBackColor = true;
            this.mUp.Click += new System.EventHandler(this.mUp_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(626, 56);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Open the COM";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(623, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Select COM:";
            // 
            // scan
            // 
            this.scan.Location = new System.Drawing.Point(626, 338);
            this.scan.Name = "scan";
            this.scan.Size = new System.Drawing.Size(113, 23);
            this.scan.TabIndex = 14;
            this.scan.Text = "Scanning";
            this.scan.UseVisualStyleBackColor = true;
            this.scan.Click += new System.EventHandler(this.scan_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(626, 367);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(113, 23);
            this.save.TabIndex = 15;
            this.save.Text = "Save image";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(626, 396);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(113, 23);
            this.exit.TabIndex = 16;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // bUp
            // 
            this.bUp.Location = new System.Drawing.Point(626, 222);
            this.bUp.Name = "bUp";
            this.bUp.Size = new System.Drawing.Size(113, 23);
            this.bUp.TabIndex = 21;
            this.bUp.Text = "Up  bot";
            this.bUp.UseVisualStyleBackColor = true;
            this.bUp.Click += new System.EventHandler(this.bUp_Click);
            // 
            // bRight
            // 
            this.bRight.Location = new System.Drawing.Point(626, 309);
            this.bRight.Name = "bRight";
            this.bRight.Size = new System.Drawing.Size(113, 23);
            this.bRight.TabIndex = 20;
            this.bRight.Text = "Right bot";
            this.bRight.UseVisualStyleBackColor = true;
            this.bRight.Click += new System.EventHandler(this.bRight_Click);
            // 
            // bLeft
            // 
            this.bLeft.Location = new System.Drawing.Point(626, 280);
            this.bLeft.Name = "bLeft";
            this.bLeft.Size = new System.Drawing.Size(113, 23);
            this.bLeft.TabIndex = 19;
            this.bLeft.Text = "Left bot";
            this.bLeft.UseVisualStyleBackColor = true;
            this.bLeft.Click += new System.EventHandler(this.bLeft_Click);
            // 
            // bDown
            // 
            this.bDown.Location = new System.Drawing.Point(626, 251);
            this.bDown.Name = "bDown";
            this.bDown.Size = new System.Drawing.Size(113, 23);
            this.bDown.TabIndex = 18;
            this.bDown.Text = "Down bot";
            this.bDown.UseVisualStyleBackColor = true;
            this.bDown.Click += new System.EventHandler(this.bDown_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(626, 429);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 20);
            this.textBox1.TabIndex = 22;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 559);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bUp);
            this.Controls.Add(this.bRight);
            this.Controls.Add(this.bLeft);
            this.Controls.Add(this.bDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.save);
            this.Controls.Add(this.scan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.mUp);
            this.Controls.Add(this.mRight);
            this.Controls.Add(this.mLeft);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.mDown);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GUI";
            this.Text = "Home Imager";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button mDown;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button mLeft;
        private System.Windows.Forms.Button mRight;
        private System.Windows.Forms.Button mUp;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button scan;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button bUp;
        private System.Windows.Forms.Button bRight;
        private System.Windows.Forms.Button bLeft;
        private System.Windows.Forms.Button bDown;
        private System.Windows.Forms.TextBox textBox1;

    }
}

