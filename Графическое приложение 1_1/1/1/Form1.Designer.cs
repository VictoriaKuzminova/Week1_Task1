
namespace _1
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
            this.res_button = new System.Windows.Forms.Button();
            this.zn_b_textBox = new System.Windows.Forms.TextBox();
            this.zn_a_textBoxs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.res = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.res_button);
            this.groupBox1.Controls.Add(this.zn_b_textBox);
            this.groupBox1.Controls.Add(this.zn_a_textBoxs);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Значения катетов";
            // 
            // res_button
            // 
            this.res_button.Location = new System.Drawing.Point(190, 161);
            this.res_button.Name = "res_button";
            this.res_button.Size = new System.Drawing.Size(177, 42);
            this.res_button.TabIndex = 4;
            this.res_button.Text = "Площадь";
            this.res_button.UseVisualStyleBackColor = true;
            this.res_button.Click += new System.EventHandler(this.res_button_Click);
            // 
            // zn_b_textBox
            // 
            this.zn_b_textBox.Location = new System.Drawing.Point(354, 100);
            this.zn_b_textBox.Name = "zn_b_textBox";
            this.zn_b_textBox.Size = new System.Drawing.Size(209, 30);
            this.zn_b_textBox.TabIndex = 3;
            this.zn_b_textBox.Text = "1";
            this.zn_b_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.zn_b_textBox_KeyPress);
            // 
            // zn_a_textBoxs
            // 
            this.zn_a_textBoxs.Location = new System.Drawing.Point(354, 40);
            this.zn_a_textBoxs.Name = "zn_a_textBoxs";
            this.zn_a_textBoxs.Size = new System.Drawing.Size(209, 30);
            this.zn_a_textBoxs.TabIndex = 2;
            this.zn_a_textBoxs.Text = "1";
            this.zn_a_textBoxs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.zn_a_textBoxs_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите значение 2-го катета = ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите значение 1-го катета = ";
            // 
            // res
            // 
            this.res.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.res.Location = new System.Drawing.Point(12, 242);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(569, 196);
            this.res.TabIndex = 1;
            this.res.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 450);
            this.Controls.Add(this.res);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Площадь треугольника";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button res_button;
        private System.Windows.Forms.TextBox zn_b_textBox;
        private System.Windows.Forms.TextBox zn_a_textBoxs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox res;
    }
}

