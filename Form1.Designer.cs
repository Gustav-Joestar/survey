namespace WinFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1=new Label();
            button1=new Button();
            linkLabel1=new LinkLabel();
            label2=new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.BackColor=Color.White;
            label1.Font=new Font("Microsoft YaHei UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor=SystemColors.Highlight;
            label1.Location=new Point(125, 35);
            label1.Name="label1";
            label1.Size=new Size(515, 50);
            label1.TabIndex=0;
            label1.Text="ОНЛАЙН-ГОЛОСОВАНИЕ";
            // 
            // button1
            // 
            button1.BackColor=SystemColors.MenuHighlight;
            button1.Font=new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location=new Point(299, 480);
            button1.Name="button1";
            button1.Size=new Size(139, 43);
            button1.TabIndex=1;
            button1.Text="П Р О Й Т И";
            button1.UseVisualStyleBackColor=false;
            button1.Click+=button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize=true;
            linkLabel1.Location=new Point(629, 9);
            linkLabel1.Name="linkLabel1";
            linkLabel1.Size=new Size(143, 15);
            linkLabel1.TabIndex=2;
            linkLabel1.TabStop=true;
            linkLabel1.Text="Результаты голосования";
            linkLabel1.LinkClicked+=linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor=SystemColors.Highlight;
            label2.Location=new Point(198, 95);
            label2.Name="label2";
            label2.Size=new Size(409, 26);
            label2.TabIndex=3;
            label2.Text="ДЛЯ ЖИТЕЛЕЙ НИЖНЕГО НОВГОРОДА";
            label2.TextAlign=ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.White;
            BackgroundImage=(Image)resources.GetObject("$this.BackgroundImage");
            ClientSize=new Size(784, 561);
            Controls.Add(label2);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name="Form1";
            StartPosition=FormStartPosition.CenterScreen;
            Text=" ";
            Load+=Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private LinkLabel linkLabel1;
        private Label label2;
    }
}