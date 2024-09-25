namespace _03_WF_DinamikButon
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
            btnÜret = new Button();
            SuspendLayout();
            // 
            // btnÜret
            // 
            btnÜret.Location = new Point(367, 300);
            btnÜret.Name = "btnÜret";
            btnÜret.Size = new Size(111, 46);
            btnÜret.TabIndex = 0;
            btnÜret.Text = "Yeni Buton Üret";
            btnÜret.UseVisualStyleBackColor = true;
            btnÜret.Click += btnÜret_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnÜret);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnÜret;
    }
}
