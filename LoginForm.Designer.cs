namespace WinFormsApp8
{
    partial class LoginForm
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
            UserIdLabel = new Label();
            label2 = new Label();
            UserIdBox = new TextBox();
            PassBox = new TextBox();
            label3 = new Label();
            LoginBtn = new Button();
            ResetBtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // UserIdLabel
            // 
            UserIdLabel.AutoSize = true;
            UserIdLabel.Location = new Point(255, 201);
            UserIdLabel.Name = "UserIdLabel";
            UserIdLabel.Size = new Size(132, 45);
            UserIdLabel.TabIndex = 0;
            UserIdLabel.Text = "User Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(238, 311);
            label2.Name = "label2";
            label2.Size = new Size(171, 45);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // UserIdBox
            // 
            UserIdBox.Location = new Point(443, 198);
            UserIdBox.Name = "UserIdBox";
            UserIdBox.Size = new Size(470, 51);
            UserIdBox.TabIndex = 2;
            UserIdBox.TextChanged += textBox1_TextChanged;
            // 
            // PassBox
            // 
            PassBox.Location = new Point(443, 311);
            PassBox.Name = "PassBox";
            PassBox.Size = new Size(470, 51);
            PassBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(363, 84);
            label3.Name = "label3";
            label3.Size = new Size(357, 45);
            label3.TabIndex = 4;
            label3.Text = "Account Information ";
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(443, 415);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(222, 56);
            LoginBtn.TabIndex = 5;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // ResetBtn
            // 
            ResetBtn.Location = new Point(691, 415);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(222, 56);
            ResetBtn.TabIndex = 6;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = true;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(236, 421);
            label1.Name = "label1";
            label1.Size = new Size(173, 45);
            label1.TabIndex = 7;
            label1.Text = "---------->";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(20F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 550);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(ResetBtn);
            Controls.Add(LoginBtn);
            Controls.Add(label3);
            Controls.Add(PassBox);
            Controls.Add(UserIdBox);
            Controls.Add(label2);
            Controls.Add(UserIdLabel);
            Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UserIdLabel;
        private Label label2;
        private TextBox UserIdBox;
        private TextBox PassBox;
        private Label label3;
        private Button LoginBtn;
        private Button ResetBtn;
        private Label label1;
    }
}