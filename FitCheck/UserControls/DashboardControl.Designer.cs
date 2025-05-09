namespace FitCheck.UserControls
{
    partial class DashboardControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel3 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            memberPanel = new Panel();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(245, 245, 255);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(memberPanel);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1531, 808);
            panel3.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(5, 217, 157);
            panel5.Location = new Point(946, 16);
            panel5.Name = "panel5";
            panel5.Size = new Size(418, 156);
            panel5.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 90, 131);
            panel4.Location = new Point(491, 16);
            panel4.Name = "panel4";
            panel4.Size = new Size(418, 156);
            panel4.TabIndex = 1;
            // 
            // memberPanel
            // 
            memberPanel.BackColor = Color.FromArgb(97, 102, 245);
            memberPanel.Location = new Point(35, 16);
            memberPanel.Name = "memberPanel";
            memberPanel.Size = new Size(418, 156);
            memberPanel.TabIndex = 0;
            // 
            // DashboardControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Name = "DashboardControl";
            Size = new Size(1531, 808);
            Load += DashboardControl_Load;
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel5;
        private Panel panel4;
        private Panel memberPanel;
    }
}
