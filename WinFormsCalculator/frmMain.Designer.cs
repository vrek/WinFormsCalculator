namespace WinFormsCalculator
{
    partial class FrmMain
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
            Screen_Display = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            add = new Button();
            subtract = new Button();
            multiply = new Button();
            divide = new Button();
            button17 = new Button();
            button18 = new Button();
            Expression = new TextBox();
            SuspendLayout();
            // 
            // Screen_Display
            // 
            Screen_Display.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Screen_Display.Location = new Point(15, 77);
            Screen_Display.Name = "Screen_Display";
            Screen_Display.Size = new Size(318, 35);
            Screen_Display.TabIndex = 0;
            Screen_Display.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 232);
            button1.Name = "button1";
            button1.Size = new Size(75, 32);
            button1.TabIndex = 1;
            button1.Text = "0";
            button1.UseVisualStyleBackColor = true;
            button1.Click += CmdNumberButtonPressed;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(15, 194);
            button2.Name = "button2";
            button2.Size = new Size(75, 32);
            button2.TabIndex = 2;
            button2.Text = "1";
            button2.UseVisualStyleBackColor = true;
            button2.Click += CmdNumberButtonPressed;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(96, 194);
            button3.Name = "button3";
            button3.Size = new Size(75, 32);
            button3.TabIndex = 3;
            button3.Text = "2";
            button3.UseVisualStyleBackColor = true;
            button3.Click += CmdNumberButtonPressed;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(177, 194);
            button4.Name = "button4";
            button4.Size = new Size(75, 32);
            button4.TabIndex = 4;
            button4.Text = "3";
            button4.UseVisualStyleBackColor = true;
            button4.Click += CmdNumberButtonPressed;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(176, 232);
            button5.Name = "button5";
            button5.Size = new Size(75, 32);
            button5.TabIndex = 5;
            button5.Text = "CLR";
            button5.UseVisualStyleBackColor = true;
            button5.Click += CmdClearPressed;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(15, 156);
            button6.Name = "button6";
            button6.Size = new Size(75, 32);
            button6.TabIndex = 6;
            button6.Text = "4";
            button6.UseVisualStyleBackColor = true;
            button6.Click += CmdNumberButtonPressed;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(96, 156);
            button7.Name = "button7";
            button7.Size = new Size(75, 32);
            button7.TabIndex = 7;
            button7.Text = "5";
            button7.UseVisualStyleBackColor = true;
            button7.Click += CmdNumberButtonPressed;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.Location = new Point(177, 156);
            button8.Name = "button8";
            button8.Size = new Size(75, 32);
            button8.TabIndex = 8;
            button8.Text = "6";
            button8.UseVisualStyleBackColor = true;
            button8.Click += CmdNumberButtonPressed;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.Location = new Point(15, 118);
            button9.Name = "button9";
            button9.Size = new Size(75, 32);
            button9.TabIndex = 9;
            button9.Text = "7";
            button9.UseVisualStyleBackColor = true;
            button9.Click += CmdNumberButtonPressed;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.Location = new Point(96, 118);
            button10.Name = "button10";
            button10.Size = new Size(75, 32);
            button10.TabIndex = 10;
            button10.Text = "8";
            button10.UseVisualStyleBackColor = true;
            button10.Click += CmdNumberButtonPressed;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button11.Location = new Point(177, 118);
            button11.Name = "button11";
            button11.Size = new Size(75, 32);
            button11.TabIndex = 11;
            button11.Text = "9";
            button11.UseVisualStyleBackColor = true;
            button11.Click += CmdNumberButtonPressed;
            // 
            // button12
            // 
            button12.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button12.Location = new Point(94, 232);
            button12.Name = "button12";
            button12.Size = new Size(75, 32);
            button12.TabIndex = 12;
            button12.Text = "=";
            button12.UseVisualStyleBackColor = true;
            button12.Click += CmdEqualButtonPressed;
            // 
            // add
            // 
            add.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add.Location = new Point(258, 232);
            add.Name = "add";
            add.Size = new Size(75, 32);
            add.TabIndex = 13;
            add.Text = "+";
            add.UseVisualStyleBackColor = true;
            add.Click += CmdOperationButtonPressed;
            // 
            // subtract
            // 
            subtract.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subtract.Location = new Point(258, 194);
            subtract.Name = "subtract";
            subtract.Size = new Size(75, 32);
            subtract.TabIndex = 14;
            subtract.Text = "-";
            subtract.UseVisualStyleBackColor = true;
            subtract.Click += CmdOperationButtonPressed;
            // 
            // multiply
            // 
            multiply.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            multiply.Location = new Point(258, 156);
            multiply.Name = "multiply";
            multiply.Size = new Size(75, 32);
            multiply.TabIndex = 15;
            multiply.Text = "*";
            multiply.UseVisualStyleBackColor = true;
            multiply.Click += CmdOperationButtonPressed;
            // 
            // divide
            // 
            divide.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            divide.Location = new Point(258, 118);
            divide.Name = "divide";
            divide.Size = new Size(75, 32);
            divide.TabIndex = 16;
            divide.Text = "/";
            divide.UseVisualStyleBackColor = true;
            divide.Click += CmdOperationButtonPressed;
            // 
            // button17
            // 
            button17.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button17.Location = new Point(339, 118);
            button17.Name = "button17";
            button17.Size = new Size(75, 32);
            button17.TabIndex = 17;
            button17.Text = "(";
            button17.UseVisualStyleBackColor = true;
            button17.Click += CmdOperationButtonPressed;
            // 
            // button18
            // 
            button18.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button18.Location = new Point(339, 156);
            button18.Name = "button18";
            button18.Size = new Size(75, 32);
            button18.TabIndex = 18;
            button18.Text = ")";
            button18.UseVisualStyleBackColor = true;
            button18.Click += CmdOperationButtonPressed;
            // 
            // Expression
            // 
            Expression.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Expression.Location = new Point(12, 36);
            Expression.Name = "Expression";
            Expression.Size = new Size(318, 35);
            Expression.TabIndex = 19;
            Expression.TextAlign = HorizontalAlignment.Right;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 292);
            Controls.Add(Expression);
            Controls.Add(button18);
            Controls.Add(button17);
            Controls.Add(divide);
            Controls.Add(multiply);
            Controls.Add(subtract);
            Controls.Add(add);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Screen_Display);
            Name = "FrmMain";
            Text = "Ray's Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Screen_Display;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button add;
        private Button subtract;
        private Button multiply;
        private Button divide;
        private Button button17;
        private Button button18;
        private TextBox Expression;
    }
}
