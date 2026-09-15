using System.Windows.Forms;

namespace _32._1_Holkin_NumberSeek
{
    partial class FormMain
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

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
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
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.recognizeButton = new System.Windows.Forms.Button();
            this.targetNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.saveLearnExample = new System.Windows.Forms.Button();
            this.saveTestExample = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.targetNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(13, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 50);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.changeStatePixelButton);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(69, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.changeStatePixelButton);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(125, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.changeStatePixelButton);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(12, 68);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 50);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.changeStatePixelButton);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(69, 68);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 50);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.changeStatePixelButton);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(125, 68);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(52, 50);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.changeStatePixelButton);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(12, 124);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 50);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.changeStatePixelButton);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(69, 124);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 50);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.changeStatePixelButton);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(125, 124);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(52, 50);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.changeStatePixelButton);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(12, 180);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(50, 50);
            this.button10.TabIndex = 9;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.changeStatePixelButton);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(69, 180);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(50, 50);
            this.button11.TabIndex = 10;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.changeStatePixelButton);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(125, 180);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(52, 50);
            this.button12.TabIndex = 11;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.changeStatePixelButton);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.White;
            this.button13.Location = new System.Drawing.Point(12, 236);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(50, 50);
            this.button13.TabIndex = 12;
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.changeStatePixelButton);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.White;
            this.button14.Location = new System.Drawing.Point(69, 236);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(50, 50);
            this.button14.TabIndex = 13;
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.changeStatePixelButton);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.White;
            this.button15.Location = new System.Drawing.Point(125, 237);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(50, 50);
            this.button15.TabIndex = 14;
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.changeStatePixelButton);
            // 
            // recognizeButton
            // 
            this.recognizeButton.BackColor = System.Drawing.Color.LemonChiffon;
            this.recognizeButton.Location = new System.Drawing.Point(212, 12);
            this.recognizeButton.Name = "recognizeButton";
            this.recognizeButton.Size = new System.Drawing.Size(150, 50);
            this.recognizeButton.TabIndex = 15;
            this.recognizeButton.Text = "Recognize";
            this.recognizeButton.UseVisualStyleBackColor = false;
            this.recognizeButton.Click += new System.EventHandler(this.recognizeClickButton);
            // 
            // targetNumericUpDown
            // 
            this.targetNumericUpDown.Location = new System.Drawing.Point(13, 293);
            this.targetNumericUpDown.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.targetNumericUpDown.Name = "targetNumericUpDown";
            this.targetNumericUpDown.Size = new System.Drawing.Size(162, 22);
            this.targetNumericUpDown.TabIndex = 16;
            this.targetNumericUpDown.ValueChanged += new System.EventHandler(this.numericUpDownTarget_ValueChanged);
            // 
            // saveLearnExample
            // 
            this.saveLearnExample.Location = new System.Drawing.Point(13, 322);
            this.saveLearnExample.Name = "saveLearnExample";
            this.saveLearnExample.Size = new System.Drawing.Size(162, 36);
            this.saveLearnExample.TabIndex = 17;
            this.saveLearnExample.Text = "Save Learn Example";
            this.saveLearnExample.UseVisualStyleBackColor = true;
            this.saveLearnExample.Click += new System.EventHandler(this.onSaveLearn);
            // 
            // saveTestExample
            // 
            this.saveTestExample.Location = new System.Drawing.Point(13, 364);
            this.saveTestExample.Name = "saveTestExample";
            this.saveTestExample.Size = new System.Drawing.Size(162, 36);
            this.saveTestExample.TabIndex = 18;
            this.saveTestExample.Text = "Save Test Example";
            this.saveTestExample.UseVisualStyleBackColor = true;
            this.saveTestExample.Click += new System.EventHandler(this.onSaveTest);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 450);
            this.Controls.Add(this.saveTestExample);
            this.Controls.Add(this.saveLearnExample);
            this.Controls.Add(this.targetNumericUpDown);
            this.Controls.Add(this.recognizeButton);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FormMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.targetNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

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
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private Button recognizeButton;
        private NumericUpDown targetNumericUpDown;
        private Button saveLearnExample;
        private Button saveTestExample;
    }
}

