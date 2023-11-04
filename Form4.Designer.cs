namespace WinFormsApp1
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            comboBox1=new ComboBox();
            button1=new Button();
            pictureBox1=new PictureBox();
            pictureBox2=new PictureBox();
            pictureBox3=new PictureBox();
            label1=new Label();
            label2=new Label();
            label3=new Label();
            label6=new Label();
            label7=new Label();
            label8=new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.BackColor=SystemColors.Window;
            comboBox1.Font=new Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled=true;
            comboBox1.Location=new Point(383, 478);
            comboBox1.Name="comboBox1";
            comboBox1.Size=new Size(444, 34);
            comboBox1.TabIndex=0;
            comboBox1.KeyPress+=comboBox1_KeyPress;
            // 
            // button1
            // 
            button1.BackColor=SystemColors.MenuHighlight;
            button1.Font=new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location=new Point(544, 518);
            button1.Name="button1";
            button1.Size=new Size(122, 34);
            button1.TabIndex=11;
            button1.Text="П О Д Т В Е Р Д И Т Ь";
            button1.UseVisualStyleBackColor=false;
            button1.Click+=button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image=(Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location=new Point(12, 110);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(380, 270);
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex=12;
            pictureBox1.TabStop=false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image=(Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location=new Point(420, 110);
            pictureBox2.Name="pictureBox2";
            pictureBox2.Size=new Size(380, 270);
            pictureBox2.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex=13;
            pictureBox2.TabStop=false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image=(Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location=new Point(824, 110);
            pictureBox3.Name="pictureBox3";
            pictureBox3.Size=new Size(380, 270);
            pictureBox3.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex=14;
            pictureBox3.TabStop=false;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor=SystemColors.Highlight;
            label1.Location=new Point(28, 383);
            label1.Name="label1";
            label1.Size=new Size(349, 26);
            label1.TabIndex=15;
            label1.Text="Строительство детских площадок";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor=SystemColors.Highlight;
            label2.Location=new Point(910, 383);
            label2.Name="label2";
            label2.Size=new Size(203, 26);
            label2.TabIndex=16;
            label2.Text="Реставрация парка";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Font=new Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor=SystemColors.Highlight;
            label3.Location=new Point(534, 383);
            label3.Name="label3";
            label3.Size=new Size(148, 26);
            label3.TabIndex=17;
            label3.Text="Ремонт дорог";
            // 
            // label6
            // 
            label6.AutoSize=true;
            label6.BackColor=Color.SandyBrown;
            label6.Font=new Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor=SystemColors.Desktop;
            label6.Location=new Point(178, 418);
            label6.Name="label6";
            label6.Size=new Size(24, 26);
            label6.TabIndex=20;
            label6.Text="1";
            // 
            // label7
            // 
            label7.AutoSize=true;
            label7.BackColor=Color.SandyBrown;
            label7.Font=new Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor=SystemColors.Desktop;
            label7.Location=new Point(1000, 418);
            label7.Name="label7";
            label7.Size=new Size(24, 26);
            label7.TabIndex=21;
            label7.Text="3";
            // 
            // label8
            // 
            label8.AutoSize=true;
            label8.BackColor=Color.SandyBrown;
            label8.Font=new Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor=SystemColors.Desktop;
            label8.Location=new Point(596, 418);
            label8.Name="label8";
            label8.Size=new Size(24, 26);
            label8.TabIndex=22;
            label8.Text="2";
            // 
            // Form4
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.White;
            ClientSize=new Size(1216, 564);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Name="Form4";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Form4";
            Load+=Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}