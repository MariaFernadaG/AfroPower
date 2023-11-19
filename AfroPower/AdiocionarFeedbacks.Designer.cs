namespace AfroPower
{
    partial class AdiocionarFeedbacks
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bnt_Adcionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 134);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(623, 135);
            this.textBox1.TabIndex = 0;
            // 
            // bnt_Adcionar
            // 
            this.bnt_Adcionar.Location = new System.Drawing.Point(588, 232);
            this.bnt_Adcionar.Name = "bnt_Adcionar";
            this.bnt_Adcionar.Size = new System.Drawing.Size(75, 23);
            this.bnt_Adcionar.TabIndex = 1;
            this.bnt_Adcionar.Text = "button1";
            this.bnt_Adcionar.UseVisualStyleBackColor = true;
            this.bnt_Adcionar.Click += new System.EventHandler(this.bnt_Adcionar_Click);
            // 
            // AdiocionarFeedbacks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bnt_Adcionar);
            this.Controls.Add(this.textBox1);
            this.Name = "AdiocionarFeedbacks";
            this.Text = "AdiocionarFeedbacks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bnt_Adcionar;
    }
}