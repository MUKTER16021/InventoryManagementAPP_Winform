namespace InventoryManagementApp.UI
{
    partial class UserUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.emailAddressTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.imageButton = new System.Windows.Forms.Button();
            this.uploadPicturBox = new System.Windows.Forms.PictureBox();
            this.addButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.showUserListView = new System.Windows.Forms.ListView();
            this.removeButton = new System.Windows.Forms.Button();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uploadPicturBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.typeComboBox);
            this.groupBox1.Controls.Add(this.statusComboBox);
            this.groupBox1.Controls.Add(this.removeButton);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.uploadPicturBox);
            this.groupBox1.Controls.Add(this.imageButton);
            this.groupBox1.Controls.Add(this.emailAddressTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.confirmPasswordTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.passwordTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.userNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1047, 260);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add User Information";
            // 
            // emailAddressTextBox
            // 
            this.emailAddressTextBox.Location = new System.Drawing.Point(315, 57);
            this.emailAddressTextBox.Name = "emailAddressTextBox";
            this.emailAddressTextBox.Size = new System.Drawing.Size(405, 26);
            this.emailAddressTextBox.TabIndex = 3;
            this.emailAddressTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email Address :";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(315, 25);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(405, 26);
            this.userNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password :";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(315, 89);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(405, 26);
            this.passwordTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Confirm Password :";
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(315, 121);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(405, 26);
            this.confirmPasswordTextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Type :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Status :";
            // 
            // imageButton
            // 
            this.imageButton.Location = new System.Drawing.Point(746, 188);
            this.imageButton.Name = "imageButton";
            this.imageButton.Size = new System.Drawing.Size(166, 35);
            this.imageButton.TabIndex = 5;
            this.imageButton.Text = "Choose an image";
            this.imageButton.UseVisualStyleBackColor = true;
            // 
            // uploadPicturBox
            // 
            this.uploadPicturBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uploadPicturBox.Location = new System.Drawing.Point(746, 25);
            this.uploadPicturBox.Name = "uploadPicturBox";
            this.uploadPicturBox.Size = new System.Drawing.Size(166, 157);
            this.uploadPicturBox.TabIndex = 6;
            this.uploadPicturBox.TabStop = false;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(514, 215);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(109, 38);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.showUserListView);
            this.groupBox2.Location = new System.Drawing.Point(13, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1047, 257);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Show User";
            // 
            // showUserListView
            // 
            this.showUserListView.HideSelection = false;
            this.showUserListView.Location = new System.Drawing.Point(7, 26);
            this.showUserListView.Name = "showUserListView";
            this.showUserListView.Size = new System.Drawing.Size(1034, 225);
            this.showUserListView.TabIndex = 0;
            this.showUserListView.UseCompatibleStateImageBehavior = false;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(399, 216);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(109, 38);
            this.removeButton.TabIndex = 7;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(315, 185);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(405, 28);
            this.statusComboBox.TabIndex = 8;
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(315, 153);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(405, 28);
            this.typeComboBox.TabIndex = 8;
            // 
            // UserUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 548);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserUI";
            this.Load += new System.EventHandler(this.UserUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uploadPicturBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox emailAddressTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button imageButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox uploadPicturBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView showUserListView;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.ComboBox statusComboBox;
    }
}