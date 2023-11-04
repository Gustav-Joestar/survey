namespace WinFormsApp1
{
    partial class Form2
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
            label1=new Label();
            label2=new Label();
            label3=new Label();
            label4=new Label();
            label5=new Label();
            textBox1=new TextBox();
            textBox2=new TextBox();
            textBox3=new TextBox();
            textBox4=new TextBox();
            button1=new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.BackColor=Color.White;
            label1.Font=new Font("Microsoft YaHei", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor=SystemColors.Highlight;
            label1.Location=new Point(34, 20);
            label1.Name="label1";
            label1.Size=new Size(312, 36);
            label1.TabIndex=0;
            label1.Text="ЗАПОЛНИТЕ АНКЕТУ";
            label1.Click+=label1_Click;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.BackColor=Color.White;
            label2.Font=new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor=Color.Black;
            label2.Location=new Point(149, 88);
            label2.Name="label2";
            label2.Size=new Size(75, 17);
            label2.TabIndex=1;
            label2.Text="ФАМИЛИЯ";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.BackColor=Color.White;
            label3.Font=new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor=Color.Black;
            label3.Location=new Point(166, 139);
            label3.Name="label3";
            label3.Size=new Size(38, 17);
            label3.TabIndex=2;
            label3.Text="ИМЯ";
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.BackColor=Color.White;
            label4.Font=new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor=Color.Black;
            label4.Location=new Point(149, 194);
            label4.Name="label4";
            label4.Size=new Size(74, 17);
            label4.TabIndex=3;
            label4.Text="ОТЧЕСТВО";
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.BackColor=Color.White;
            label5.Font=new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor=Color.Black;
            label5.Location=new Point(53, 257);
            label5.Name="label5";
            label5.Size=new Size(284, 17);
            label5.TabIndex=4;
            label5.Text="СЕРИЯ И НОМЕР ПАСПОРТА (ЧЕРЕЗ ПРОБЕЛ)";
            // 
            // textBox1
            // 
            textBox1.Location=new Point(85, 108);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(201, 23);
            textBox1.TabIndex=5;
            textBox1.KeyPress+=textBox1_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Location=new Point(85, 159);
            textBox2.Name="textBox2";
            textBox2.Size=new Size(201, 23);
            textBox2.TabIndex=6;
            textBox2.TextChanged+=textBox2_TextChanged;
            textBox2.KeyPress+=textBox2_KeyPress;
            // 
            // textBox3
            // 
            textBox3.Location=new Point(85, 214);
            textBox3.Name="textBox3";
            textBox3.Size=new Size(201, 23);
            textBox3.TabIndex=7;
            textBox3.KeyPress+=textBox3_KeyPress;
            // 
            // textBox4
            // 
            textBox4.Location=new Point(85, 277);
            textBox4.Name="textBox4";
            textBox4.Size=new Size(201, 23);
            textBox4.TabIndex=8;
            textBox4.KeyPress+=textBox4_KeyPress;
            // 
            // button1
            // 
            button1.BackColor=SystemColors.MenuHighlight;
            button1.Font=new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location=new Point(131, 315);
            button1.Name="button1";
            button1.Size=new Size(122, 34);
            button1.TabIndex=9;
            button1.Text="П Р О Д О Л Ж И Т Ь";
            button1.UseVisualStyleBackColor=false;
            button1.Click+=button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.White;
            ClientSize=new Size(384, 361);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name="Form2";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
    }
}