using System.Globalization;

namespace Hitachi_SPACE_Programme
{
    partial class IndexControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndexControl));
            IndexTitle = new Label();
            IndexTextContent = new Label();
            IndexContinueBtn = new Button();
            SuspendLayout();
            // 
            // IndexTitle
            // 
            IndexTitle.Anchor = AnchorStyles.Top;
            IndexTitle.AutoSize = true;
            IndexTitle.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            IndexTitle.ForeColor = Color.Firebrick;
            IndexTitle.Location = new Point(270, 2);
            IndexTitle.Name = "IndexTitle";
            IndexTitle.Size = new Size(423, 65);
            IndexTitle.TabIndex = 3;
            IndexTitle.Text = "SPACE Programme";
            IndexTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // IndexTextContent
            // 
            IndexTextContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            IndexTextContent.AutoSize = true;
            IndexTextContent.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            IndexTextContent.Location = new Point(139, 67);
            IndexTextContent.Name = "IndexTextContent";
            IndexTextContent.Size = new Size(653, 360);
            IndexTextContent.TabIndex = 6;
            IndexTextContent.Text = resources.GetString("IndexTextContent.Text");
            // 
            // IndexContinueBtn
            // 
            IndexContinueBtn.BackColor = Color.Chartreuse;
            IndexContinueBtn.Location = new Point(397, 430);
            IndexContinueBtn.Name = "IndexContinueBtn";
            IndexContinueBtn.Size = new Size(167, 76);
            IndexContinueBtn.TabIndex = 7;
            IndexContinueBtn.Text = "Continue";
            IndexContinueBtn.UseVisualStyleBackColor = false;
            IndexContinueBtn.Click += IndexTextContent_Click;
            // 
            // IndexControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(IndexContinueBtn);
            Controls.Add(IndexTextContent);
            Controls.Add(IndexTitle);
            Name = "IndexControl";
            Size = new Size(907, 587);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label IndexTitle;
        private Label IndexTextContent;
        private Button IndexContinueBtn;
    }
}
