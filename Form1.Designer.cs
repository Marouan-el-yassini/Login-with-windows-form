namespace WinFormsApp8
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
            label1 = new Label();
            AboutAppBtn = new Button();
            LoginBtn = new Button();
            ExitBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 29F, FontStyle.Bold);
            label1.Location = new Point(234, 108);
            label1.Name = "label1";
            label1.Size = new Size(690, 77);
            label1.TabIndex = 0;
            label1.Text = "Dashboard Application";
            // 
            // AboutAppBtn
            // 
            AboutAppBtn.Location = new Point(76, 297);
            AboutAppBtn.Name = "AboutAppBtn";
            AboutAppBtn.Size = new Size(437, 77);
            AboutAppBtn.TabIndex = 1;
            AboutAppBtn.Text = "About App";
            AboutAppBtn.UseVisualStyleBackColor = true;
            AboutAppBtn.Click += AboutAppBtn_Click;
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(606, 297);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(438, 77);
            LoginBtn.TabIndex = 2;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(370, 420);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(384, 87);
            ExitBtn.TabIndex = 3;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(20F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 550);
            Controls.Add(ExitBtn);
            Controls.Add(LoginBtn);
            Controls.Add(AboutAppBtn);
            Controls.Add(label1);
            Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button AboutAppBtn;
        private Button LoginBtn;
        private Button ExitBtn;
    }
}
