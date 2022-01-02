namespace TimedMathQuiz
{
    partial class TimedMathQuiz
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimedMathQuiz));
            this.TimeCounterLabel = new System.Windows.Forms.Label();
            this.TimeLeftTextLabel = new System.Windows.Forms.Label();
            this.LeftOfPlusLabel = new System.Windows.Forms.Label();
            this.PlusSignLabel = new System.Windows.Forms.Label();
            this.RightOfPlusLabel = new System.Windows.Forms.Label();
            this.EqualSignAddLabel = new System.Windows.Forms.Label();
            this.AdditionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.LeftOfMinusLabel = new System.Windows.Forms.Label();
            this.MinusSign = new System.Windows.Forms.Label();
            this.RightOfMinusLabel = new System.Windows.Forms.Label();
            this.EqualSignSubtractLabel = new System.Windows.Forms.Label();
            this.SubtractNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.LeftOfMultiplyLabel = new System.Windows.Forms.Label();
            this.MultiplySign = new System.Windows.Forms.Label();
            this.RightOfMultiplyLabel = new System.Windows.Forms.Label();
            this.DivideSign = new System.Windows.Forms.Label();
            this.LeftOfDivideLabel = new System.Windows.Forms.Label();
            this.RightOfDivideLabel = new System.Windows.Forms.Label();
            this.EqualSignDivideLabel = new System.Windows.Forms.Label();
            this.EqualSignMultiplyLabel = new System.Windows.Forms.Label();
            this.DivideNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MultiplyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.StartButton = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.addCheckbox = new System.Windows.Forms.CheckBox();
            this.subtractCheckbox = new System.Windows.Forms.CheckBox();
            this.multiplyCheckbox = new System.Windows.Forms.CheckBox();
            this.divideCheckbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.AdditionNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubtractNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DivideNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MultiplyNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeCounterLabel
            // 
            this.TimeCounterLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimeCounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeCounterLabel.Location = new System.Drawing.Point(266, 9);
            this.TimeCounterLabel.Name = "TimeCounterLabel";
            this.TimeCounterLabel.Size = new System.Drawing.Size(200, 30);
            this.TimeCounterLabel.TabIndex = 0;
            // 
            // TimeLeftTextLabel
            // 
            this.TimeLeftTextLabel.AutoSize = true;
            this.TimeLeftTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLeftTextLabel.Location = new System.Drawing.Point(116, 9);
            this.TimeLeftTextLabel.Name = "TimeLeftTextLabel";
            this.TimeLeftTextLabel.Size = new System.Drawing.Size(142, 31);
            this.TimeLeftTextLabel.TabIndex = 1;
            this.TimeLeftTextLabel.Text = "Time Left: ";
            // 
            // LeftOfPlusLabel
            // 
            this.LeftOfPlusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftOfPlusLabel.Location = new System.Drawing.Point(50, 75);
            this.LeftOfPlusLabel.Name = "LeftOfPlusLabel";
            this.LeftOfPlusLabel.Size = new System.Drawing.Size(60, 50);
            this.LeftOfPlusLabel.TabIndex = 2;
            this.LeftOfPlusLabel.Text = "?";
            this.LeftOfPlusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlusSignLabel
            // 
            this.PlusSignLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusSignLabel.Location = new System.Drawing.Point(116, 75);
            this.PlusSignLabel.Name = "PlusSignLabel";
            this.PlusSignLabel.Size = new System.Drawing.Size(60, 50);
            this.PlusSignLabel.TabIndex = 3;
            this.PlusSignLabel.Text = "+";
            this.PlusSignLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RightOfPlusLabel
            // 
            this.RightOfPlusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightOfPlusLabel.Location = new System.Drawing.Point(182, 75);
            this.RightOfPlusLabel.Name = "RightOfPlusLabel";
            this.RightOfPlusLabel.Size = new System.Drawing.Size(60, 50);
            this.RightOfPlusLabel.TabIndex = 4;
            this.RightOfPlusLabel.Text = "?";
            this.RightOfPlusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EqualSignAddLabel
            // 
            this.EqualSignAddLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualSignAddLabel.Location = new System.Drawing.Point(248, 75);
            this.EqualSignAddLabel.Name = "EqualSignAddLabel";
            this.EqualSignAddLabel.Size = new System.Drawing.Size(60, 50);
            this.EqualSignAddLabel.TabIndex = 5;
            this.EqualSignAddLabel.Text = "=";
            this.EqualSignAddLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdditionNumericUpDown
            // 
            this.AdditionNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdditionNumericUpDown.Location = new System.Drawing.Point(314, 84);
            this.AdditionNumericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.AdditionNumericUpDown.Name = "AdditionNumericUpDown";
            this.AdditionNumericUpDown.Size = new System.Drawing.Size(100, 41);
            this.AdditionNumericUpDown.TabIndex = 6;
            this.AdditionNumericUpDown.Enter += new System.EventHandler(this.AnswerEnter);
            // 
            // LeftOfMinusLabel
            // 
            this.LeftOfMinusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftOfMinusLabel.Location = new System.Drawing.Point(50, 125);
            this.LeftOfMinusLabel.Name = "LeftOfMinusLabel";
            this.LeftOfMinusLabel.Size = new System.Drawing.Size(60, 50);
            this.LeftOfMinusLabel.TabIndex = 7;
            this.LeftOfMinusLabel.Text = "?";
            this.LeftOfMinusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MinusSign
            // 
            this.MinusSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinusSign.Location = new System.Drawing.Point(116, 125);
            this.MinusSign.Name = "MinusSign";
            this.MinusSign.Size = new System.Drawing.Size(60, 50);
            this.MinusSign.TabIndex = 8;
            this.MinusSign.Text = "-";
            this.MinusSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RightOfMinusLabel
            // 
            this.RightOfMinusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightOfMinusLabel.Location = new System.Drawing.Point(182, 125);
            this.RightOfMinusLabel.Name = "RightOfMinusLabel";
            this.RightOfMinusLabel.Size = new System.Drawing.Size(60, 50);
            this.RightOfMinusLabel.TabIndex = 9;
            this.RightOfMinusLabel.Text = "?";
            this.RightOfMinusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EqualSignSubtractLabel
            // 
            this.EqualSignSubtractLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualSignSubtractLabel.Location = new System.Drawing.Point(248, 125);
            this.EqualSignSubtractLabel.Name = "EqualSignSubtractLabel";
            this.EqualSignSubtractLabel.Size = new System.Drawing.Size(60, 50);
            this.EqualSignSubtractLabel.TabIndex = 10;
            this.EqualSignSubtractLabel.Text = "=";
            this.EqualSignSubtractLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubtractNumericUpDown
            // 
            this.SubtractNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtractNumericUpDown.Location = new System.Drawing.Point(314, 134);
            this.SubtractNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.SubtractNumericUpDown.Name = "SubtractNumericUpDown";
            this.SubtractNumericUpDown.Size = new System.Drawing.Size(100, 41);
            this.SubtractNumericUpDown.TabIndex = 11;
            this.SubtractNumericUpDown.Enter += new System.EventHandler(this.AnswerEnter);
            // 
            // LeftOfMultiplyLabel
            // 
            this.LeftOfMultiplyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftOfMultiplyLabel.Location = new System.Drawing.Point(50, 175);
            this.LeftOfMultiplyLabel.Name = "LeftOfMultiplyLabel";
            this.LeftOfMultiplyLabel.Size = new System.Drawing.Size(60, 50);
            this.LeftOfMultiplyLabel.TabIndex = 12;
            this.LeftOfMultiplyLabel.Text = "?";
            this.LeftOfMultiplyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MultiplySign
            // 
            this.MultiplySign.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplySign.Location = new System.Drawing.Point(116, 175);
            this.MultiplySign.Name = "MultiplySign";
            this.MultiplySign.Size = new System.Drawing.Size(60, 50);
            this.MultiplySign.TabIndex = 13;
            this.MultiplySign.Text = "X";
            this.MultiplySign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RightOfMultiplyLabel
            // 
            this.RightOfMultiplyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightOfMultiplyLabel.Location = new System.Drawing.Point(182, 175);
            this.RightOfMultiplyLabel.Name = "RightOfMultiplyLabel";
            this.RightOfMultiplyLabel.Size = new System.Drawing.Size(60, 50);
            this.RightOfMultiplyLabel.TabIndex = 14;
            this.RightOfMultiplyLabel.Text = "?";
            this.RightOfMultiplyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DivideSign
            // 
            this.DivideSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivideSign.Location = new System.Drawing.Point(116, 225);
            this.DivideSign.Name = "DivideSign";
            this.DivideSign.Size = new System.Drawing.Size(60, 50);
            this.DivideSign.TabIndex = 15;
            this.DivideSign.Text = "/";
            this.DivideSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LeftOfDivideLabel
            // 
            this.LeftOfDivideLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftOfDivideLabel.Location = new System.Drawing.Point(50, 225);
            this.LeftOfDivideLabel.Name = "LeftOfDivideLabel";
            this.LeftOfDivideLabel.Size = new System.Drawing.Size(60, 50);
            this.LeftOfDivideLabel.TabIndex = 16;
            this.LeftOfDivideLabel.Text = "?";
            this.LeftOfDivideLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RightOfDivideLabel
            // 
            this.RightOfDivideLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightOfDivideLabel.Location = new System.Drawing.Point(182, 225);
            this.RightOfDivideLabel.Name = "RightOfDivideLabel";
            this.RightOfDivideLabel.Size = new System.Drawing.Size(60, 50);
            this.RightOfDivideLabel.TabIndex = 17;
            this.RightOfDivideLabel.Text = "?";
            this.RightOfDivideLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EqualSignDivideLabel
            // 
            this.EqualSignDivideLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualSignDivideLabel.Location = new System.Drawing.Point(248, 225);
            this.EqualSignDivideLabel.Name = "EqualSignDivideLabel";
            this.EqualSignDivideLabel.Size = new System.Drawing.Size(60, 50);
            this.EqualSignDivideLabel.TabIndex = 18;
            this.EqualSignDivideLabel.Text = "=";
            this.EqualSignDivideLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EqualSignMultiplyLabel
            // 
            this.EqualSignMultiplyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualSignMultiplyLabel.Location = new System.Drawing.Point(248, 175);
            this.EqualSignMultiplyLabel.Name = "EqualSignMultiplyLabel";
            this.EqualSignMultiplyLabel.Size = new System.Drawing.Size(60, 50);
            this.EqualSignMultiplyLabel.TabIndex = 19;
            this.EqualSignMultiplyLabel.Text = "=";
            this.EqualSignMultiplyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DivideNumericUpDown
            // 
            this.DivideNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivideNumericUpDown.Location = new System.Drawing.Point(314, 231);
            this.DivideNumericUpDown.Name = "DivideNumericUpDown";
            this.DivideNumericUpDown.Size = new System.Drawing.Size(100, 41);
            this.DivideNumericUpDown.TabIndex = 21;
            this.DivideNumericUpDown.Enter += new System.EventHandler(this.AnswerEnter);
            // 
            // MultiplyNumericUpDown
            // 
            this.MultiplyNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplyNumericUpDown.Location = new System.Drawing.Point(314, 184);
            this.MultiplyNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.MultiplyNumericUpDown.Name = "MultiplyNumericUpDown";
            this.MultiplyNumericUpDown.Size = new System.Drawing.Size(100, 41);
            this.MultiplyNumericUpDown.TabIndex = 20;
            this.MultiplyNumericUpDown.Enter += new System.EventHandler(this.AnswerEnter);
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(122, 288);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(186, 49);
            this.StartButton.TabIndex = 22;
            this.StartButton.Text = "Start the quiz";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // addCheckbox
            // 
            this.addCheckbox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.addCheckbox.AutoSize = true;
            this.addCheckbox.BackColor = System.Drawing.SystemColors.Control;
            this.addCheckbox.Enabled = false;
            this.addCheckbox.ForeColor = System.Drawing.SystemColors.Control;
            this.addCheckbox.Location = new System.Drawing.Point(435, 103);
            this.addCheckbox.Name = "addCheckbox";
            this.addCheckbox.Size = new System.Drawing.Size(18, 17);
            this.addCheckbox.TabIndex = 23;
            this.addCheckbox.UseVisualStyleBackColor = false;
            // 
            // subtractCheckbox
            // 
            this.subtractCheckbox.AutoSize = true;
            this.subtractCheckbox.Enabled = false;
            this.subtractCheckbox.Location = new System.Drawing.Point(435, 149);
            this.subtractCheckbox.Name = "subtractCheckbox";
            this.subtractCheckbox.Size = new System.Drawing.Size(18, 17);
            this.subtractCheckbox.TabIndex = 24;
            this.subtractCheckbox.UseVisualStyleBackColor = true;
            // 
            // multiplyCheckbox
            // 
            this.multiplyCheckbox.AutoSize = true;
            this.multiplyCheckbox.Enabled = false;
            this.multiplyCheckbox.Location = new System.Drawing.Point(435, 199);
            this.multiplyCheckbox.Name = "multiplyCheckbox";
            this.multiplyCheckbox.Size = new System.Drawing.Size(18, 17);
            this.multiplyCheckbox.TabIndex = 25;
            this.multiplyCheckbox.UseVisualStyleBackColor = true;
            // 
            // divideCheckbox
            // 
            this.divideCheckbox.Enabled = false;
            this.divideCheckbox.Location = new System.Drawing.Point(436, 246);
            this.divideCheckbox.Name = "divideCheckbox";
            this.divideCheckbox.Size = new System.Drawing.Size(17, 23);
            this.divideCheckbox.TabIndex = 26;
            this.divideCheckbox.UseVisualStyleBackColor = true;
            // 
            // TimedMathQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 349);
            this.Controls.Add(this.divideCheckbox);
            this.Controls.Add(this.multiplyCheckbox);
            this.Controls.Add(this.subtractCheckbox);
            this.Controls.Add(this.addCheckbox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.MultiplyNumericUpDown);
            this.Controls.Add(this.DivideNumericUpDown);
            this.Controls.Add(this.EqualSignMultiplyLabel);
            this.Controls.Add(this.EqualSignDivideLabel);
            this.Controls.Add(this.RightOfDivideLabel);
            this.Controls.Add(this.LeftOfDivideLabel);
            this.Controls.Add(this.DivideSign);
            this.Controls.Add(this.RightOfMultiplyLabel);
            this.Controls.Add(this.MultiplySign);
            this.Controls.Add(this.LeftOfMultiplyLabel);
            this.Controls.Add(this.SubtractNumericUpDown);
            this.Controls.Add(this.EqualSignSubtractLabel);
            this.Controls.Add(this.RightOfMinusLabel);
            this.Controls.Add(this.MinusSign);
            this.Controls.Add(this.LeftOfMinusLabel);
            this.Controls.Add(this.AdditionNumericUpDown);
            this.Controls.Add(this.EqualSignAddLabel);
            this.Controls.Add(this.RightOfPlusLabel);
            this.Controls.Add(this.PlusSignLabel);
            this.Controls.Add(this.LeftOfPlusLabel);
            this.Controls.Add(this.TimeLeftTextLabel);
            this.Controls.Add(this.TimeCounterLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TimedMathQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Timed Maths Quiz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CancelButtonClick);
            ((System.ComponentModel.ISupportInitialize)(this.AdditionNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubtractNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DivideNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MultiplyNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeCounterLabel;
        private System.Windows.Forms.Label TimeLeftTextLabel;
        private System.Windows.Forms.Label LeftOfPlusLabel;
        private System.Windows.Forms.Label PlusSignLabel;
        private System.Windows.Forms.Label RightOfPlusLabel;
        private System.Windows.Forms.Label EqualSignAddLabel;
        private System.Windows.Forms.NumericUpDown AdditionNumericUpDown;
        private System.Windows.Forms.Label LeftOfMinusLabel;
        private System.Windows.Forms.Label MinusSign;
        private System.Windows.Forms.Label RightOfMinusLabel;
        private System.Windows.Forms.Label EqualSignSubtractLabel;
        private System.Windows.Forms.NumericUpDown SubtractNumericUpDown;
        private System.Windows.Forms.Label LeftOfMultiplyLabel;
        private System.Windows.Forms.Label MultiplySign;
        private System.Windows.Forms.Label RightOfMultiplyLabel;
        private System.Windows.Forms.Label DivideSign;
        private System.Windows.Forms.Label LeftOfDivideLabel;
        private System.Windows.Forms.Label RightOfDivideLabel;
        private System.Windows.Forms.Label EqualSignDivideLabel;
        private System.Windows.Forms.Label EqualSignMultiplyLabel;
        private System.Windows.Forms.NumericUpDown DivideNumericUpDown;
        private System.Windows.Forms.NumericUpDown MultiplyNumericUpDown;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.CheckBox addCheckbox;
        private System.Windows.Forms.CheckBox subtractCheckbox;
        private System.Windows.Forms.CheckBox multiplyCheckbox;
        private System.Windows.Forms.CheckBox divideCheckbox;
    }
}

