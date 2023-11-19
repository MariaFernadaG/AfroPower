namespace AfroPower
{
    partial class VerFeedbacks
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
            this.listBoxFeedbacks = new System.Windows.Forms.ListBox();
            this.FeedBacks = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxFeedbacks
            // 
            this.listBoxFeedbacks.FormattingEnabled = true;
            this.listBoxFeedbacks.ItemHeight = 16;
            this.listBoxFeedbacks.Location = new System.Drawing.Point(195, 147);
            this.listBoxFeedbacks.Name = "listBoxFeedbacks";
            this.listBoxFeedbacks.Size = new System.Drawing.Size(640, 324);
            this.listBoxFeedbacks.TabIndex = 0;
            // 
            // FeedBacks
            // 
            this.FeedBacks.AutoSize = true;
            this.FeedBacks.Location = new System.Drawing.Point(195, 84);
            this.FeedBacks.Name = "FeedBacks";
            this.FeedBacks.Size = new System.Drawing.Size(77, 16);
            this.FeedBacks.TabIndex = 1;
            this.FeedBacks.Text = "FeedBacks";
            // 
            // VerFeedbacks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 516);
            this.Controls.Add(this.FeedBacks);
            this.Controls.Add(this.listBoxFeedbacks);
            this.Name = "VerFeedbacks";
            this.Text = "VerFeedbacks";
            this.Load += new System.EventHandler(this.VerFeedbacks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFeedbacks;
        private System.Windows.Forms.Label FeedBacks;
    }
}