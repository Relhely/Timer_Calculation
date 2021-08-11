
namespace Clock_calculater
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.time_in = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Outbox = new System.Windows.Forms.TextBox();
            this.Num1 = new System.Windows.Forms.Button();
            this.Num2 = new System.Windows.Forms.Button();
            this.Num3 = new System.Windows.Forms.Button();
            this.Num4 = new System.Windows.Forms.Button();
            this.Num5 = new System.Windows.Forms.Button();
            this.Num6 = new System.Windows.Forms.Button();
            this.Num7 = new System.Windows.Forms.Button();
            this.Num8 = new System.Windows.Forms.Button();
            this.Num9 = new System.Windows.Forms.Button();
            this.Num0 = new System.Windows.Forms.Button();
            this.Num_enter = new System.Windows.Forms.Button();
            this.pgup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "輸入時間:";
            // 
            // time_in
            // 
            this.time_in.ImeMode = System.Windows.Forms.ImeMode.On;
            this.time_in.Location = new System.Drawing.Point(94, 26);
            this.time_in.Name = "time_in";
            this.time_in.Size = new System.Drawing.Size(100, 22);
            this.time_in.TabIndex = 2;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(212, 25);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 3;
            this.Calculate.Text = "計算";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(293, 25);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 4;
            this.Clear.Text = "清空";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Outbox
            // 
            this.Outbox.Location = new System.Drawing.Point(337, 68);
            this.Outbox.Multiline = true;
            this.Outbox.Name = "Outbox";
            this.Outbox.Size = new System.Drawing.Size(215, 309);
            this.Outbox.TabIndex = 5;
            // 
            // Num1
            // 
            this.Num1.Location = new System.Drawing.Point(15, 263);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(60, 61);
            this.Num1.TabIndex = 6;
            this.Num1.Text = "1";
            this.Num1.UseVisualStyleBackColor = true;
            this.Num1.Click += new System.EventHandler(this.Num1_Click);
            // 
            // Num2
            // 
            this.Num2.Location = new System.Drawing.Point(95, 263);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(60, 61);
            this.Num2.TabIndex = 7;
            this.Num2.Text = "2";
            this.Num2.UseVisualStyleBackColor = true;
            this.Num2.Click += new System.EventHandler(this.Num2_Click);
            // 
            // Num3
            // 
            this.Num3.Location = new System.Drawing.Point(175, 263);
            this.Num3.Name = "Num3";
            this.Num3.Size = new System.Drawing.Size(60, 61);
            this.Num3.TabIndex = 8;
            this.Num3.Text = "3";
            this.Num3.UseVisualStyleBackColor = true;
            this.Num3.Click += new System.EventHandler(this.Num3_Click);
            // 
            // Num4
            // 
            this.Num4.Location = new System.Drawing.Point(15, 178);
            this.Num4.Name = "Num4";
            this.Num4.Size = new System.Drawing.Size(60, 61);
            this.Num4.TabIndex = 9;
            this.Num4.Text = "4";
            this.Num4.UseVisualStyleBackColor = true;
            this.Num4.Click += new System.EventHandler(this.Num4_Click);
            // 
            // Num5
            // 
            this.Num5.Location = new System.Drawing.Point(95, 178);
            this.Num5.Name = "Num5";
            this.Num5.Size = new System.Drawing.Size(60, 61);
            this.Num5.TabIndex = 10;
            this.Num5.Text = "5";
            this.Num5.UseVisualStyleBackColor = true;
            this.Num5.Click += new System.EventHandler(this.Num5_Click);
            // 
            // Num6
            // 
            this.Num6.Location = new System.Drawing.Point(175, 178);
            this.Num6.Name = "Num6";
            this.Num6.Size = new System.Drawing.Size(60, 61);
            this.Num6.TabIndex = 11;
            this.Num6.Text = "6";
            this.Num6.UseVisualStyleBackColor = true;
            this.Num6.Click += new System.EventHandler(this.Num6_Click);
            // 
            // Num7
            // 
            this.Num7.Location = new System.Drawing.Point(15, 101);
            this.Num7.Name = "Num7";
            this.Num7.Size = new System.Drawing.Size(60, 61);
            this.Num7.TabIndex = 12;
            this.Num7.Text = "7";
            this.Num7.UseVisualStyleBackColor = true;
            this.Num7.Click += new System.EventHandler(this.Num7_Click);
            // 
            // Num8
            // 
            this.Num8.Location = new System.Drawing.Point(95, 101);
            this.Num8.Name = "Num8";
            this.Num8.Size = new System.Drawing.Size(60, 61);
            this.Num8.TabIndex = 13;
            this.Num8.Text = "8";
            this.Num8.UseVisualStyleBackColor = true;
            this.Num8.Click += new System.EventHandler(this.Num8_Click);
            // 
            // Num9
            // 
            this.Num9.Location = new System.Drawing.Point(175, 101);
            this.Num9.Name = "Num9";
            this.Num9.Size = new System.Drawing.Size(60, 61);
            this.Num9.TabIndex = 14;
            this.Num9.Text = "9";
            this.Num9.UseVisualStyleBackColor = true;
            this.Num9.Click += new System.EventHandler(this.Num9_Click);
            // 
            // Num0
            // 
            this.Num0.Location = new System.Drawing.Point(254, 263);
            this.Num0.Name = "Num0";
            this.Num0.Size = new System.Drawing.Size(60, 61);
            this.Num0.TabIndex = 15;
            this.Num0.Text = "0";
            this.Num0.UseVisualStyleBackColor = true;
            this.Num0.Click += new System.EventHandler(this.Num0_Click);
            // 
            // Num_enter
            // 
            this.Num_enter.Location = new System.Drawing.Point(254, 178);
            this.Num_enter.Name = "Num_enter";
            this.Num_enter.Size = new System.Drawing.Size(60, 61);
            this.Num_enter.TabIndex = 16;
            this.Num_enter.Text = "Enter";
            this.Num_enter.UseVisualStyleBackColor = true;
            this.Num_enter.Click += new System.EventHandler(this.Num_enter_Click);
            // 
            // pgup
            // 
            this.pgup.Location = new System.Drawing.Point(254, 101);
            this.pgup.Name = "pgup";
            this.pgup.Size = new System.Drawing.Size(60, 61);
            this.pgup.TabIndex = 17;
            this.pgup.Text = "<-";
            this.pgup.UseVisualStyleBackColor = true;
            this.pgup.Click += new System.EventHandler(this.pgup_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 450);
            this.Controls.Add(this.pgup);
            this.Controls.Add(this.Num_enter);
            this.Controls.Add(this.Num0);
            this.Controls.Add(this.Num9);
            this.Controls.Add(this.Num8);
            this.Controls.Add(this.Num7);
            this.Controls.Add(this.Num6);
            this.Controls.Add(this.Num5);
            this.Controls.Add(this.Num4);
            this.Controls.Add(this.Num3);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.Outbox);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.time_in);
            this.Controls.Add(this.label1);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Form1";
            this.Text = "時間加法器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox time_in;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.TextBox Outbox;
        private System.Windows.Forms.Button Num1;
        private System.Windows.Forms.Button Num2;
        private System.Windows.Forms.Button Num3;
        private System.Windows.Forms.Button Num4;
        private System.Windows.Forms.Button Num5;
        private System.Windows.Forms.Button Num6;
        private System.Windows.Forms.Button Num7;
        private System.Windows.Forms.Button Num8;
        private System.Windows.Forms.Button Num9;
        private System.Windows.Forms.Button Num0;
        private System.Windows.Forms.Button Num_enter;
        private System.Windows.Forms.Button pgup;
    }
}

