namespace FitCheck
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
            button1 = new Button();
            panel1 = new Panel();
            label2 = new Label();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-3, 124);
            button1.Name = "button1";
            button1.Size = new Size(272, 78);
            button1.TabIndex = 1;
            button1.Text = "Dashboard";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(70, 70, 70);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(269, 904);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 26);
            label2.Name = "label2";
            label2.Size = new Size(233, 67);
            label2.TabIndex = 1;
            label2.Text = "FitCheck";
            label2.Click += label2_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.DimGray;
            button6.BackgroundImageLayout = ImageLayout.None;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.White;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(0, 499);
            button6.Name = "button6";
            button6.Size = new Size(269, 78);
            button6.TabIndex = 6;
            button6.Text = "Báo cáo";
            button6.TextImageRelation = TextImageRelation.ImageBeforeText;
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.DimGray;
            button5.BackgroundImageLayout = ImageLayout.None;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(-3, 424);
            button5.Name = "button5";
            button5.Size = new Size(272, 78);
            button5.TabIndex = 5;
            button5.Text = "Lịch sử";
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.DimGray;
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 346);
            button4.Name = "button4";
            button4.Size = new Size(269, 78);
            button4.TabIndex = 4;
            button4.Text = "Thanh Toán";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.DimGray;
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 271);
            button3.Name = "button3";
            button3.Size = new Size(269, 78);
            button3.TabIndex = 3;
            button3.Text = "Gói tập";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.DimGray;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-3, 197);
            button2.Name = "button2";
            button2.Size = new Size(272, 78);
            button2.TabIndex = 2;
            button2.Text = "Hội viên";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 0);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(269, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1492, 124);
            panel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 25.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(6, 9);
            label1.Name = "label1";
            label1.Size = new Size(389, 90);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(55, 56, 60);
            ClientSize = new Size(1761, 904);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button button2;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Label label2;
    }
}
