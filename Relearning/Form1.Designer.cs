namespace Relearning
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
            MessageLabel = new Label();
            actionButton = new Button();
            SuspendLayout();
            // 
            // MessageLabel
            // 
            MessageLabel.AutoSize = true;
            MessageLabel.Font = new Font("Yu Gothic UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            MessageLabel.Location = new Point(125, 207);
            MessageLabel.Name = "MessageLabel";
            MessageLabel.Size = new Size(312, 45);
            MessageLabel.TabIndex = 0;
            MessageLabel.Text = "操作内容を表示します";
            // 
            // actionButton
            // 
            actionButton.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            actionButton.Location = new Point(125, 91);
            actionButton.Name = "actionButton";
            actionButton.Size = new Size(101, 41);
            actionButton.TabIndex = 1;
            actionButton.Text = "Action";
            actionButton.UseVisualStyleBackColor = true;
            actionButton.Click += actionButton_Click;
            actionButton.MouseLeave += actionButton_MouseLeave;
            actionButton.MouseHover += actionButton_MouseHover;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 405);
            Controls.Add(actionButton);
            Controls.Add(MessageLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MessageLabel;
        private Button actionButton;
    }
}