namespace WinFormsApp1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label1=new Label();
            label2=new Label();
            label3=new Label();
            button1=new Button();
            pictureBox1=new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor=SystemColors.Highlight;
            label1.Location=new Point(21, 305);
            label1.Name="label1";
            label1.Size=new Size(579, 22);
            label1.TabIndex=0;
            label1.Text="Губернатор Нижегородской области Глеб Никитин подписал указ,";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor=SystemColors.Highlight;
            label2.Location=new Point(38, 336);
            label2.Name="label2";
            label2.Size=new Size(548, 22);
            label2.TabIndex=1;
            label2.Text="позволяющий жителям Нижнего Новгорода проголосовать за";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Font=new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor=SystemColors.Highlight;
            label3.Location=new Point(157, 367);
            label3.Name="label3";
            label3.Size=new Size(308, 22);
            label3.TabIndex=2;
            label3.Text="желаемый объект благоустройства";
            // 
            // button1
            // 
            button1.BackColor=SystemColors.MenuHighlight;
            button1.Font=new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location=new Point(236, 404);
            button1.Name="button1";
            button1.Size=new Size(122, 34);
            button1.TabIndex=10;
            button1.Text="П Р О Д О Л Ж И Т Ь";
            button1.UseVisualStyleBackColor=false;
            button1.Click+=button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image=(Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location=new Point(63, 12);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(497, 284);
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex=11;
            pictureBox1.TabStop=false;
            // 
            // Form3
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.White;
            ClientSize=new Size(621, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name="Form3";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private PictureBox pictureBox1;
    }
}