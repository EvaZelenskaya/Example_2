namespace WindowsFormsApp12
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.char_radioButton = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.lower_radioButton = new System.Windows.Forms.RadioButton();
            this.number_radioButton = new System.Windows.Forms.RadioButton();
            this.input_TextBox = new System.Windows.Forms.TextBox();
            this.check_Button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.char_radioButton);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.lower_radioButton);
            this.groupBox1.Controls.Add(this.number_radioButton);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(45, 66);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1053, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Что введено?";
            // 
            // char_radioButton
            // 
            this.char_radioButton.AutoSize = true;
            this.char_radioButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.char_radioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(238)))), ((int)(((byte)(104)))));
            this.char_radioButton.Location = new System.Drawing.Point(713, 84);
            this.char_radioButton.Margin = new System.Windows.Forms.Padding(4);
            this.char_radioButton.Name = "char_radioButton";
            this.char_radioButton.Size = new System.Drawing.Size(333, 27);
            this.char_radioButton.TabIndex = 3;
            this.char_radioButton.TabStop = true;
            this.char_radioButton.Text = "Строка из специльных символов";
            this.char_radioButton.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(238)))), ((int)(((byte)(104)))));
            this.radioButton3.Location = new System.Drawing.Point(427, 84);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(278, 27);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Строка в верхнем регистре";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // lower_radioButton
            // 
            this.lower_radioButton.AutoSize = true;
            this.lower_radioButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lower_radioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(238)))), ((int)(((byte)(104)))));
            this.lower_radioButton.Location = new System.Drawing.Point(134, 84);
            this.lower_radioButton.Margin = new System.Windows.Forms.Padding(4);
            this.lower_radioButton.Name = "lower_radioButton";
            this.lower_radioButton.Size = new System.Drawing.Size(276, 27);
            this.lower_radioButton.TabIndex = 1;
            this.lower_radioButton.TabStop = true;
            this.lower_radioButton.Text = "Строка в нижнем регистре";
            this.lower_radioButton.UseVisualStyleBackColor = true;
            // 
            // number_radioButton
            // 
            this.number_radioButton.AutoSize = true;
            this.number_radioButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_radioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(238)))), ((int)(((byte)(104)))));
            this.number_radioButton.Location = new System.Drawing.Point(19, 84);
            this.number_radioButton.Margin = new System.Windows.Forms.Padding(4);
            this.number_radioButton.Name = "number_radioButton";
            this.number_radioButton.Size = new System.Drawing.Size(88, 27);
            this.number_radioButton.TabIndex = 0;
            this.number_radioButton.TabStop = true;
            this.number_radioButton.Text = "Число";
            this.number_radioButton.UseVisualStyleBackColor = true;
            // 
            // input_TextBox
            // 
            this.input_TextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_TextBox.Location = new System.Drawing.Point(45, 323);
            this.input_TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.input_TextBox.Multiline = true;
            this.input_TextBox.Name = "input_TextBox";
            this.input_TextBox.Size = new System.Drawing.Size(1053, 39);
            this.input_TextBox.TabIndex = 1;
            // 
            // check_Button
            // 
            this.check_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(238)))), ((int)(((byte)(104)))));
            this.check_Button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_Button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.check_Button.Location = new System.Drawing.Point(918, 396);
            this.check_Button.Margin = new System.Windows.Forms.Padding(4);
            this.check_Button.Name = "check_Button";
            this.check_Button.Size = new System.Drawing.Size(180, 49);
            this.check_Button.TabIndex = 2;
            this.check_Button.Text = "Проверить";
            this.check_Button.UseVisualStyleBackColor = false;
            this.check_Button.Click += new System.EventHandler(this.check_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(1126, 500);
            this.Controls.Add(this.check_Button);
            this.Controls.Add(this.input_TextBox);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Лабораторная работа №12 (Зеленской Евы)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton lower_radioButton;
        private System.Windows.Forms.RadioButton number_radioButton;
        private System.Windows.Forms.TextBox input_TextBox;
        private System.Windows.Forms.Button check_Button;
        private System.Windows.Forms.RadioButton char_radioButton;
    }
}

