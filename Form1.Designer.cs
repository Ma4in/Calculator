using System.Reflection.PortableExecutable;

namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonPM = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonSqrt = new System.Windows.Forms.Button();
            this.buttonSqr = new System.Windows.Forms.Button();
            this.buttonDrob = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.buttonPercent = new System.Windows.Forms.Button();
            this.buttonEq = new System.Windows.Forms.Button();
            this.buttonMemorySave = new System.Windows.Forms.Button();
            this.buttonMemmoryRead = new System.Windows.Forms.Button();
            this.buttonMemmoryClear = new System.Windows.Forms.Button();
            this.buttonMemmoryPlus = new System.Windows.Forms.Button();
            this.buttonMemmoryMinus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox.Location = new System.Drawing.Point(12, 12);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(360, 50);
            this.textBox.TabIndex = 0;
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox.WordWrap = false;
            this.textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(10, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.TabIndex = 1;
            this.button1.TabStop = false;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPM
            // 
            this.buttonPM.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPM.Location = new System.Drawing.Point(12, 413);
            this.buttonPM.Name = "buttonPM";
            this.buttonPM.Size = new System.Drawing.Size(60, 60);
            this.buttonPM.TabIndex = 1;
            this.buttonPM.TabStop = false;
            this.buttonPM.Text = "+/-";
            this.buttonPM.UseVisualStyleBackColor = true;
            this.buttonPM.Click += new System.EventHandler(this.buttonPM_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(76, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 60);
            this.button2.TabIndex = 1;
            this.button2.TabStop = false;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(142, 347);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 60);
            this.button3.TabIndex = 1;
            this.button3.TabStop = false;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(10, 281);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 60);
            this.button4.TabIndex = 1;
            this.button4.TabStop = false;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(76, 281);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 60);
            this.button5.TabIndex = 1;
            this.button5.TabStop = false;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(142, 281);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 60);
            this.button6.TabIndex = 1;
            this.button6.TabStop = false;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(10, 215);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 60);
            this.button7.TabIndex = 1;
            this.button7.TabStop = false;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(76, 215);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(60, 60);
            this.button8.TabIndex = 1;
            this.button8.TabStop = false;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button9.Location = new System.Drawing.Point(142, 215);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(60, 60);
            this.button9.TabIndex = 1;
            this.button9.TabStop = false;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button0.Location = new System.Drawing.Point(76, 413);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(60, 60);
            this.button0.TabIndex = 1;
            this.button0.TabStop = false;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDot.Location = new System.Drawing.Point(142, 413);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(60, 60);
            this.buttonDot.TabIndex = 1;
            this.buttonDot.TabStop = false;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = true;
            this.buttonDot.Click += new System.EventHandler(this.buttonDot_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPlus.Location = new System.Drawing.Point(208, 347);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(60, 60);
            this.buttonPlus.TabIndex = 1;
            this.buttonPlus.TabStop = false;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMinus.Location = new System.Drawing.Point(208, 281);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(60, 60);
            this.buttonMinus.TabIndex = 1;
            this.buttonMinus.TabStop = false;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMultiply.Location = new System.Drawing.Point(208, 215);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(60, 60);
            this.buttonMultiply.TabIndex = 1;
            this.buttonMultiply.TabStop = false;
            this.buttonMultiply.Text = "x";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDiv.Location = new System.Drawing.Point(208, 149);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(60, 60);
            this.buttonDiv.TabIndex = 1;
            this.buttonDiv.TabStop = false;
            this.buttonDiv.Text = "÷";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.buttonDiv_Click);
            // 
            // buttonSqrt
            // 
            this.buttonSqrt.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSqrt.Location = new System.Drawing.Point(142, 149);
            this.buttonSqrt.Name = "buttonSqrt";
            this.buttonSqrt.Size = new System.Drawing.Size(60, 60);
            this.buttonSqrt.TabIndex = 1;
            this.buttonSqrt.TabStop = false;
            this.buttonSqrt.Text = "√x";
            this.buttonSqrt.UseVisualStyleBackColor = true;
            this.buttonSqrt.Click += new System.EventHandler(this.buttonSqrt_Click);
            // 
            // buttonSqr
            // 
            this.buttonSqr.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSqr.Location = new System.Drawing.Point(76, 149);
            this.buttonSqr.Name = "buttonSqr";
            this.buttonSqr.Size = new System.Drawing.Size(60, 60);
            this.buttonSqr.TabIndex = 1;
            this.buttonSqr.TabStop = false;
            this.buttonSqr.Text = "х²";
            this.buttonSqr.UseVisualStyleBackColor = true;
            this.buttonSqr.Click += new System.EventHandler(this.buttonSqr_Click);
            // 
            // buttonDrob
            // 
            this.buttonDrob.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDrob.Location = new System.Drawing.Point(10, 149);
            this.buttonDrob.Name = "buttonDrob";
            this.buttonDrob.Size = new System.Drawing.Size(60, 60);
            this.buttonDrob.TabIndex = 1;
            this.buttonDrob.TabStop = false;
            this.buttonDrob.Text = "1/x";
            this.buttonDrob.UseVisualStyleBackColor = true;
            this.buttonDrob.Click += new System.EventHandler(this.buttonDrob_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBack.Location = new System.Drawing.Point(208, 83);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(60, 60);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.TabStop = false;
            this.buttonBack.Text = "⌫";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClear.Location = new System.Drawing.Point(142, 83);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(60, 60);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.TabStop = false;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_click);
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClearAll.Location = new System.Drawing.Point(76, 83);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(60, 60);
            this.buttonClearAll.TabIndex = 1;
            this.buttonClearAll.TabStop = false;
            this.buttonClearAll.Text = "CE";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_click);
            // 
            // buttonPercent
            // 
            this.buttonPercent.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPercent.Location = new System.Drawing.Point(12, 83);
            this.buttonPercent.Name = "buttonPercent";
            this.buttonPercent.Size = new System.Drawing.Size(60, 60);
            this.buttonPercent.TabIndex = 1;
            this.buttonPercent.TabStop = false;
            this.buttonPercent.Text = "%";
            this.buttonPercent.UseVisualStyleBackColor = true;
            this.buttonPercent.Click += new System.EventHandler(this.buttonPercent_Click);
            // 
            // buttonEq
            // 
            this.buttonEq.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEq.Location = new System.Drawing.Point(208, 413);
            this.buttonEq.Name = "buttonEq";
            this.buttonEq.Size = new System.Drawing.Size(60, 60);
            this.buttonEq.TabIndex = 1;
            this.buttonEq.TabStop = false;
            this.buttonEq.Text = "=";
            this.buttonEq.UseVisualStyleBackColor = true;
            this.buttonEq.Click += new System.EventHandler(this.buttonEq_Click);
            // 
            // buttonMemorySave
            // 
            this.buttonMemorySave.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMemorySave.Location = new System.Drawing.Point(312, 414);
            this.buttonMemorySave.Name = "buttonMemorySave";
            this.buttonMemorySave.Size = new System.Drawing.Size(60, 60);
            this.buttonMemorySave.TabIndex = 1;
            this.buttonMemorySave.TabStop = false;
            this.buttonMemorySave.Text = "MS";
            this.buttonMemorySave.UseVisualStyleBackColor = true;
            this.buttonMemorySave.Click += new System.EventHandler(this.buttonMemorySave_click);
            // 
            // buttonMemmoryRead
            // 
            this.buttonMemmoryRead.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMemmoryRead.Location = new System.Drawing.Point(312, 348);
            this.buttonMemmoryRead.Name = "buttonMemmoryRead";
            this.buttonMemmoryRead.Size = new System.Drawing.Size(60, 60);
            this.buttonMemmoryRead.TabIndex = 1;
            this.buttonMemmoryRead.TabStop = false;
            this.buttonMemmoryRead.Text = "MR";
            this.buttonMemmoryRead.UseVisualStyleBackColor = true;
            this.buttonMemmoryRead.Click += new System.EventHandler(this.buttonMemoryRead_click);
            // 
            // buttonMemmoryClear
            // 
            this.buttonMemmoryClear.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMemmoryClear.Location = new System.Drawing.Point(312, 281);
            this.buttonMemmoryClear.Name = "buttonMemmoryClear";
            this.buttonMemmoryClear.Size = new System.Drawing.Size(60, 60);
            this.buttonMemmoryClear.TabIndex = 1;
            this.buttonMemmoryClear.TabStop = false;
            this.buttonMemmoryClear.Text = "MC";
            this.buttonMemmoryClear.UseVisualStyleBackColor = true;
            this.buttonMemmoryClear.Click += new System.EventHandler(this.buttonMemoryClear_click);
            // 
            // buttonMemmoryPlus
            // 
            this.buttonMemmoryPlus.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMemmoryPlus.Location = new System.Drawing.Point(312, 215);
            this.buttonMemmoryPlus.Name = "buttonMemmoryPlus";
            this.buttonMemmoryPlus.Size = new System.Drawing.Size(60, 60);
            this.buttonMemmoryPlus.TabIndex = 1;
            this.buttonMemmoryPlus.TabStop = false;
            this.buttonMemmoryPlus.Text = "M+";
            this.buttonMemmoryPlus.UseVisualStyleBackColor = true;
            this.buttonMemmoryPlus.Click += new System.EventHandler(this.buttonMemoryPlus_click);
            // 
            // buttonMemmoryMinus
            // 
            this.buttonMemmoryMinus.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMemmoryMinus.Location = new System.Drawing.Point(312, 150);
            this.buttonMemmoryMinus.Name = "buttonMemmoryMinus";
            this.buttonMemmoryMinus.Size = new System.Drawing.Size(60, 60);
            this.buttonMemmoryMinus.TabIndex = 1;
            this.buttonMemmoryMinus.TabStop = false;
            this.buttonMemmoryMinus.Text = "M-";
            this.buttonMemmoryMinus.UseVisualStyleBackColor = true;
            this.buttonMemmoryMinus.Click += new System.EventHandler(this.buttonMemoryMinus_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 486);
            this.Controls.Add(this.buttonDrob);
            this.Controls.Add(this.buttonSqr);
            this.Controls.Add(this.buttonSqrt);
            this.Controls.Add(this.buttonPercent);
            this.Controls.Add(this.buttonClearAll);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonMemmoryMinus);
            this.Controls.Add(this.buttonMemmoryPlus);
            this.Controls.Add(this.buttonMemmoryClear);
            this.Controls.Add(this.buttonMemmoryRead);
            this.Controls.Add(this.buttonMemorySave);
            this.Controls.Add(this.buttonEq);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonPM);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Claculatorus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox;
        private Button button1;
        private Button buttonPM;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button buttonDot;
        private Button buttonPlus;
        private Button buttonMinus;
        private Button buttonMultiply;
        private Button buttonDiv;
        private Button buttonSqrt;
        private Button buttonSqr;
        private Button buttonDrob;
        private Button buttonBack;
        private Button buttonClear;
        private Button buttonClearAll;
        private Button buttonPercent;
        private Button buttonEq;
        private Button buttonMemorySave;
        private Button buttonMemmoryRead;
        private Button buttonMemmoryClear;
        private Button buttonMemmoryPlus;
        private Button buttonMemmoryMinus;
    }
}