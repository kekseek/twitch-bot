namespace TwitchChatBot {
    partial class LoginForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.LoginButton = new System.Windows.Forms.Button();
            this.TwitchLoginTextBox = new System.Windows.Forms.TextBox();
            this.OauthTokenTextBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginErrorHandler = new System.Windows.Forms.Label();
            this.OauthErrorHandler = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.DarkMagenta;
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LoginButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LoginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkMagenta;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LoginButton.Location = new System.Drawing.Point(12, 180);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(105, 33);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // TwitchLoginTextBox
            // 
            this.TwitchLoginTextBox.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TwitchLoginTextBox.Location = new System.Drawing.Point(12, 28);
            this.TwitchLoginTextBox.Name = "TwitchLoginTextBox";
            this.TwitchLoginTextBox.Size = new System.Drawing.Size(181, 26);
            this.TwitchLoginTextBox.TabIndex = 1;
            // 
            // OauthTokenTextBox
            // 
            this.OauthTokenTextBox.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OauthTokenTextBox.Location = new System.Drawing.Point(12, 99);
            this.OauthTokenTextBox.Name = "OauthTokenTextBox";
            this.OauthTokenTextBox.Size = new System.Drawing.Size(181, 26);
            this.OauthTokenTextBox.TabIndex = 2;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LoginLabel.Location = new System.Drawing.Point(12, 9);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(88, 16);
            this.LoginLabel.TabIndex = 3;
            this.LoginLabel.Text = "Twitch login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(9, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Oauth token";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // LoginErrorHandler
            // 
            this.LoginErrorHandler.AutoSize = true;
            this.LoginErrorHandler.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginErrorHandler.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LoginErrorHandler.Location = new System.Drawing.Point(233, 28);
            this.LoginErrorHandler.Name = "LoginErrorHandler";
            this.LoginErrorHandler.Size = new System.Drawing.Size(0, 18);
            this.LoginErrorHandler.TabIndex = 6;
            // 
            // OauthErrorHandler
            // 
            this.OauthErrorHandler.AutoSize = true;
            this.OauthErrorHandler.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OauthErrorHandler.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.OauthErrorHandler.Location = new System.Drawing.Point(233, 107);
            this.OauthErrorHandler.Name = "OauthErrorHandler";
            this.OauthErrorHandler.Size = new System.Drawing.Size(0, 18);
            this.OauthErrorHandler.TabIndex = 7;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(508, 245);
            this.Controls.Add(this.OauthErrorHandler);
            this.Controls.Add(this.LoginErrorHandler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.OauthTokenTextBox);
            this.Controls.Add(this.TwitchLoginTextBox);
            this.Controls.Add(this.LoginButton);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox TwitchLoginTextBox;
        private System.Windows.Forms.TextBox OauthTokenTextBox;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LoginErrorHandler;
        private System.Windows.Forms.Label OauthErrorHandler;
    }
}