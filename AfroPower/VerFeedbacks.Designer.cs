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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxFeedbacks
            // 
            this.listBoxFeedbacks.FormattingEnabled = true;
            this.listBoxFeedbacks.Location = new System.Drawing.Point(179, 116);
            this.listBoxFeedbacks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxFeedbacks.Name = "listBoxFeedbacks";
            this.listBoxFeedbacks.Size = new System.Drawing.Size(673, 381);
            this.listBoxFeedbacks.TabIndex = 0;
            // 
            // FeedBacks
            // 
            this.FeedBacks.AutoSize = true;
            this.FeedBacks.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.FeedBacks.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeedBacks.Location = new System.Drawing.Point(384, 25);
            this.FeedBacks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FeedBacks.Name = "FeedBacks";
            this.FeedBacks.Size = new System.Drawing.Size(265, 55);
            this.FeedBacks.TabIndex = 1;
            this.FeedBacks.Text = "FeedBacks";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(909, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "VOLTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VerFeedbacks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1008, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FeedBacks);
            this.Controls.Add(this.listBoxFeedbacks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VerFeedbacks";
            this.Text = "VerFeedbacks";
            this.Load += new System.EventHandler(this.VerFeedbacks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFeedbacks;
        private System.Windows.Forms.Label FeedBacks;
        private System.Windows.Forms.Button button1;
    }
}