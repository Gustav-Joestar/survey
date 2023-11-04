namespace WinFormsApp1
{
    partial class Form5
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
            button1=new Button();
            label1=new Label();
            pictureBox1=new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor=SystemColors.MenuHighlight;
            button1.Font=new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location=new Point(325, 404);
            button1.Name="button1";
            button1.Size=new Size(160, 34);
            button1.TabIndex=11;
            button1.Text="ВЕРНУТЬСЯ НА ГЛАВНУЮ";
            button1.UseVisualStyleBackColor=false;
            button1.Click+=button1_Click;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.BackColor=Color.White;
            label1.Font=new Font("Microsoft YaHei", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor=SystemColors.Highlight;
            label1.Location=new Point(26, 19);
            label1.Name="label1";
            label1.Size=new Size(732, 64);
            label1.TabIndex=12;
            label1.Text="СПАСИБО ЗА ВАШ ГОЛОС!!!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image=Properties.Resources._1_OSFRvGkj0T6Ipfrv5lv4i8NrnTPvD2PaSmjTYvAEBoF8MBaCq_YVEi4StjhPmZ80wWn_nu;
            pictureBox1.Location=new Point(239, 86);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(336, 290);
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex=13;
            pictureBox1.TabStop=false;
            // 
            // Form5
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.White;
            ClientSize=new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name="Form5";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Form5";
            Load+=Form5_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
    }
}