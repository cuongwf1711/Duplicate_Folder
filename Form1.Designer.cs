namespace Duplicate_Folder
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
            txtSrcFold = new TextBox();
            BrowseSrcFold = new Button();
            label2 = new Label();
            txtDesFold = new TextBox();
            BrowseDesFold = new Button();
            btnStart = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 66);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 0;
            label1.Text = "Source:";
            // 
            // txtSrcFold
            // 
            txtSrcFold.Location = new Point(127, 64);
            txtSrcFold.Name = "txtSrcFold";
            txtSrcFold.Size = new Size(469, 27);
            txtSrcFold.TabIndex = 1;
            // 
            // BrowseSrcFold
            // 
            BrowseSrcFold.Location = new Point(602, 62);
            BrowseSrcFold.Name = "BrowseSrcFold";
            BrowseSrcFold.Size = new Size(94, 29);
            BrowseSrcFold.TabIndex = 2;
            BrowseSrcFold.Text = "Browse";
            BrowseSrcFold.UseVisualStyleBackColor = true;
            BrowseSrcFold.Click += BrowseSrcFold_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 134);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 0;
            label2.Text = "Destination:";
            // 
            // txtDesFold
            // 
            txtDesFold.Location = new Point(127, 132);
            txtDesFold.Name = "txtDesFold";
            txtDesFold.Size = new Size(469, 27);
            txtDesFold.TabIndex = 1;
            // 
            // BrowseDesFold
            // 
            BrowseDesFold.Location = new Point(602, 130);
            BrowseDesFold.Name = "BrowseDesFold";
            BrowseDesFold.Size = new Size(94, 29);
            BrowseDesFold.TabIndex = 2;
            BrowseDesFold.Text = "Browse";
            BrowseDesFold.UseVisualStyleBackColor = true;
            BrowseDesFold.Click += BrowseDesFold_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(331, 199);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 29);
            btnStart.TabIndex = 3;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 240);
            Controls.Add(btnStart);
            Controls.Add(BrowseDesFold);
            Controls.Add(txtDesFold);
            Controls.Add(BrowseSrcFold);
            Controls.Add(label2);
            Controls.Add(txtSrcFold);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSrcFold;
        private Button BrowseSrcFold;
        private Label label2;
        private TextBox txtDesFold;
        private Button BrowseDesFold;
        private Button btnStart;
    }
}
