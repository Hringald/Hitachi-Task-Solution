namespace Hitachi_SPACE_Programme
{
    partial class DataEntryControl
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
            InputFileLocationLabel = new Label();
            InputPathTextBox = new TextBox();
            BrowseInputFolderBtn = new Button();
            RecieverEmailTxtBox = new TextBox();
            SenderPasswordTxtBox = new TextBox();
            SenderEmailTxtBox = new TextBox();
            RecieverEmailLabel = new Label();
            SenderPasswordLabel = new Label();
            SenderEmailInputLabel = new Label();
            EnterEmailLabel = new Label();
            ProcessDataBtn = new Button();
            HumidityLabel = new Label();
            MaxHumidityTxtBox = new TextBox();
            SuspendLayout();
            // 
            // InputFileLocationLabel
            // 
            InputFileLocationLabel.AutoSize = true;
            InputFileLocationLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            InputFileLocationLabel.Location = new Point(211, 49);
            InputFileLocationLabel.Name = "InputFileLocationLabel";
            InputFileLocationLabel.Size = new Size(393, 21);
            InputFileLocationLabel.TabIndex = 0;
            InputFileLocationLabel.Text = "Please enter location of the folder contraining CSV files:";
            // 
            // InputPathTextBox
            // 
            InputPathTextBox.Location = new Point(211, 73);
            InputPathTextBox.Name = "InputPathTextBox";
            InputPathTextBox.Size = new Size(475, 23);
            InputPathTextBox.TabIndex = 1;
            // 
            // BrowseInputFolderBtn
            // 
            BrowseInputFolderBtn.Location = new Point(383, 102);
            BrowseInputFolderBtn.Name = "BrowseInputFolderBtn";
            BrowseInputFolderBtn.Size = new Size(148, 31);
            BrowseInputFolderBtn.TabIndex = 2;
            BrowseInputFolderBtn.Text = "Browse folder";
            BrowseInputFolderBtn.UseVisualStyleBackColor = true;
            BrowseInputFolderBtn.Click += BrowseInputFolderBtn_Click;
            // 
            // RecieverEmailTxtBox
            // 
            RecieverEmailTxtBox.Location = new Point(430, 280);
            RecieverEmailTxtBox.Name = "RecieverEmailTxtBox";
            RecieverEmailTxtBox.Size = new Size(256, 23);
            RecieverEmailTxtBox.TabIndex = 13;
            // 
            // SenderPasswordTxtBox
            // 
            SenderPasswordTxtBox.Location = new Point(430, 244);
            SenderPasswordTxtBox.Name = "SenderPasswordTxtBox";
            SenderPasswordTxtBox.Size = new Size(256, 23);
            SenderPasswordTxtBox.TabIndex = 12;
            // 
            // SenderEmailTxtBox
            // 
            SenderEmailTxtBox.Location = new Point(430, 210);
            SenderEmailTxtBox.Name = "SenderEmailTxtBox";
            SenderEmailTxtBox.Size = new Size(256, 23);
            SenderEmailTxtBox.TabIndex = 11;
            // 
            // RecieverEmailLabel
            // 
            RecieverEmailLabel.AutoSize = true;
            RecieverEmailLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            RecieverEmailLabel.Location = new Point(211, 283);
            RecieverEmailLabel.Name = "RecieverEmailLabel";
            RecieverEmailLabel.Size = new Size(164, 20);
            RecieverEmailLabel.TabIndex = 10;
            RecieverEmailLabel.Text = "Reciever email address:";
            // 
            // SenderPasswordLabel
            // 
            SenderPasswordLabel.AutoSize = true;
            SenderPasswordLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            SenderPasswordLabel.Location = new Point(209, 243);
            SenderPasswordLabel.Name = "SenderPasswordLabel";
            SenderPasswordLabel.Size = new Size(166, 20);
            SenderPasswordLabel.TabIndex = 9;
            SenderPasswordLabel.Text = "Sender email password:";
            // 
            // SenderEmailInputLabel
            // 
            SenderEmailInputLabel.AutoSize = true;
            SenderEmailInputLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            SenderEmailInputLabel.Location = new Point(211, 209);
            SenderEmailInputLabel.Name = "SenderEmailInputLabel";
            SenderEmailInputLabel.Size = new Size(154, 20);
            SenderEmailInputLabel.TabIndex = 8;
            SenderEmailInputLabel.Text = "Sender email address:";
            // 
            // EnterEmailLabel
            // 
            EnterEmailLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EnterEmailLabel.AutoSize = true;
            EnterEmailLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EnterEmailLabel.Location = new Point(211, 174);
            EnterEmailLabel.Name = "EnterEmailLabel";
            EnterEmailLabel.Size = new Size(226, 21);
            EnterEmailLabel.TabIndex = 7;
            EnterEmailLabel.Text = "Please enter the following data:";
            // 
            // ProcessDataBtn
            // 
            ProcessDataBtn.BackColor = Color.Chartreuse;
            ProcessDataBtn.Location = new Point(383, 429);
            ProcessDataBtn.Name = "ProcessDataBtn";
            ProcessDataBtn.Size = new Size(148, 65);
            ProcessDataBtn.TabIndex = 14;
            ProcessDataBtn.Text = "Continue";
            ProcessDataBtn.UseVisualStyleBackColor = false;
            ProcessDataBtn.Click += ProcessBtn_Click;
            // 
            // HumidityLabel
            // 
            HumidityLabel.AutoSize = true;
            HumidityLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HumidityLabel.Location = new Point(211, 318);
            HumidityLabel.Name = "HumidityLabel";
            HumidityLabel.Size = new Size(373, 21);
            HumidityLabel.TabIndex = 15;
            HumidityLabel.Text = "Add additional maximum humidity criteria(optional):";
            // 
            // MaxHumidityTxtBox
            // 
            MaxHumidityTxtBox.Location = new Point(211, 342);
            MaxHumidityTxtBox.Name = "MaxHumidityTxtBox";
            MaxHumidityTxtBox.Size = new Size(52, 23);
            MaxHumidityTxtBox.TabIndex = 16;
            // 
            // DataEntryControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MaxHumidityTxtBox);
            Controls.Add(HumidityLabel);
            Controls.Add(ProcessDataBtn);
            Controls.Add(RecieverEmailTxtBox);
            Controls.Add(SenderPasswordTxtBox);
            Controls.Add(SenderEmailTxtBox);
            Controls.Add(RecieverEmailLabel);
            Controls.Add(SenderPasswordLabel);
            Controls.Add(SenderEmailInputLabel);
            Controls.Add(EnterEmailLabel);
            Controls.Add(BrowseInputFolderBtn);
            Controls.Add(InputPathTextBox);
            Controls.Add(InputFileLocationLabel);
            Name = "DataEntryControl";
            Size = new Size(907, 587);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label InputFileLocationLabel;
        private TextBox InputPathTextBox;
        private Button BrowseInputFolderBtn;
        private TextBox RecieverEmailTxtBox;
        private TextBox SenderPasswordTxtBox;
        private TextBox SenderEmailTxtBox;
        private Label RecieverEmailLabel;
        private Label SenderPasswordLabel;
        private Label SenderEmailInputLabel;
        private Label EnterEmailLabel;
        private Button ProcessDataBtn;
        private Label HumidityLabel;
        private TextBox MaxHumidityTxtBox;
    }
}
