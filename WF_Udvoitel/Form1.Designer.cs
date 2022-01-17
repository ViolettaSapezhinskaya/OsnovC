namespace WF_Udvoitel
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
            this.Comand2 = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Number = new System.Windows.Forms.Label();
            this.Comand1 = new System.Windows.Forms.Button();
            this.End = new System.Windows.Forms.Label();
            this.moves = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Comand2
            // 
            this.Comand2.Location = new System.Drawing.Point(168, 72);
            this.Comand2.Name = "Comand2";
            this.Comand2.Size = new System.Drawing.Size(104, 36);
            this.Comand2.TabIndex = 1;
            this.Comand2.Text = "x2";
            this.Comand2.UseVisualStyleBackColor = true;
            this.Comand2.Click += new System.EventHandler(this.Comand2_Click);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Reset.Location = new System.Drawing.Point(168, 119);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(104, 37);
            this.Reset.TabIndex = 2;
            this.Reset.Text = "Сброс";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Number
            // 
            this.Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number.Location = new System.Drawing.Point(41, 46);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(59, 26);
            this.Number.TabIndex = 3;
            this.Number.Text = "Reset";
            // 
            // Comand1
            // 
            this.Comand1.Location = new System.Drawing.Point(168, 23);
            this.Comand1.Name = "Comand1";
            this.Comand1.Size = new System.Drawing.Size(104, 32);
            this.Comand1.TabIndex = 4;
            this.Comand1.Text = "+1";
            this.Comand1.UseVisualStyleBackColor = true;
            this.Comand1.Click += new System.EventHandler(this.Comand1_Click);
            // 
            // End
            // 
            this.End.AutoSize = true;
            this.End.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.End.Location = new System.Drawing.Point(42, 119);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(30, 16);
            this.End.TabIndex = 5;
            this.End.Text = "end";
            // 
            // moves
            // 
            this.moves.AutoSize = true;
            this.moves.Location = new System.Drawing.Point(42, 72);
            this.moves.Name = "moves";
            this.moves.Size = new System.Drawing.Size(38, 13);
            this.moves.TabIndex = 6;
            this.moves.Text = "moves";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 229);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.moves);
            this.Controls.Add(this.End);
            this.Controls.Add(this.Comand1);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Comand2);
            this.Name = "Form1";
            this.Text = "sdf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Comand2;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.Button Comand1;
        private System.Windows.Forms.Label End;
        private System.Windows.Forms.Label moves;
        private System.Windows.Forms.Button button1;
    }
}

