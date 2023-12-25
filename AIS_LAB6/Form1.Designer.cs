namespace AIS_LAB6
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.digitPadLabel = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.processingTimer = new System.Windows.Forms.Timer(this.components);
            this.waitTimer = new System.Windows.Forms.Timer(this.components);
            this.cashLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button1.Location = new System.Drawing.Point(286, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.EnterDigit);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button2.Location = new System.Drawing.Point(332, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.EnterDigit);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button3.Location = new System.Drawing.Point(378, 257);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 42);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.EnterDigit);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button4.Location = new System.Drawing.Point(286, 305);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 42);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.EnterDigit);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button5.Location = new System.Drawing.Point(332, 305);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 42);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.EnterDigit);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button6.Location = new System.Drawing.Point(378, 305);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 42);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.EnterDigit);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button7.Location = new System.Drawing.Point(286, 353);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(40, 42);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.EnterDigit);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button8.Location = new System.Drawing.Point(332, 353);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(40, 42);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.EnterDigit);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button9.Location = new System.Drawing.Point(378, 353);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(40, 42);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.EnterDigit);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button10.Location = new System.Drawing.Point(332, 401);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(40, 42);
            this.button10.TabIndex = 9;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.EnterDigit);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button11.ForeColor = System.Drawing.Color.LawnGreen;
            this.button11.Location = new System.Drawing.Point(378, 401);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(40, 42);
            this.button11.TabIndex = 10;
            this.button11.Text = "V";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.EnterDigit);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button12.ForeColor = System.Drawing.Color.Red;
            this.button12.Location = new System.Drawing.Point(286, 401);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(40, 42);
            this.button12.TabIndex = 11;
            this.button12.Text = "X";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.EnterDigit);
            // 
            // digitPadLabel
            // 
            this.digitPadLabel.AutoSize = true;
            this.digitPadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.digitPadLabel.Location = new System.Drawing.Point(308, 215);
            this.digitPadLabel.Name = "digitPadLabel";
            this.digitPadLabel.Size = new System.Drawing.Size(93, 39);
            this.digitPadLabel.TabIndex = 12;
            this.digitPadLabel.Text = "0000";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(217, 257);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(63, 86);
            this.button13.TabIndex = 13;
            this.button13.Text = "Снять деньги";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(424, 261);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(81, 86);
            this.button14.TabIndex = 14;
            this.button14.Text = "Положить деньги";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(286, 106);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(141, 56);
            this.button15.TabIndex = 15;
            this.button15.Text = "Завершить работу";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(289, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Введите PIN";
            // 
            // processingTimer
            // 
            this.processingTimer.Interval = 500;
            this.processingTimer.Tick += new System.EventHandler(this.processingTimer_Tick);
            // 
            // waitTimer
            // 
            this.waitTimer.Interval = 3500;
            this.waitTimer.Tick += new System.EventHandler(this.waitTimer_Tick);
            // 
            // cashLabel
            // 
            this.cashLabel.AutoSize = true;
            this.cashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cashLabel.Location = new System.Drawing.Point(26, 305);
            this.cashLabel.Name = "cashLabel";
            this.cashLabel.Size = new System.Drawing.Size(170, 25);
            this.cashLabel.TabIndex = 20;
            this.cashLabel.Text = "Наличные: 500 р.";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AIS_LAB6.Properties.Resources.wRg_44iQ_ak;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(273, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AIS_LAB6.Properties.Resources.kanye_west;
            this.pictureBox1.Location = new System.Drawing.Point(12, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cashLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.digitPadLabel);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label digitPadLabel;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer processingTimer;
        private System.Windows.Forms.Timer waitTimer;
        private System.Windows.Forms.Label cashLabel;
    }
}

