namespace WFA_feladat7
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
            tbdarab = new TextBox();
            btndob = new Button();
            lblresult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(1, 66);
            label1.Name = "label1";
            label1.Size = new Size(144, 23);
            label1.TabIndex = 0;
            label1.Text = "Hány kockadobást kérsz?";
            // 
            // tbdarab
            // 
            tbdarab.Location = new Point(162, 66);
            tbdarab.Name = "tbdarab";
            tbdarab.Size = new Size(100, 23);
            tbdarab.TabIndex = 1;
            // 
            // btndob
            // 
            btndob.Location = new Point(102, 283);
            btndob.Name = "btndob";
            btndob.Size = new Size(75, 23);
            btndob.TabIndex = 4;
            btndob.Text = "dobás";
            btndob.UseVisualStyleBackColor = true;
            // 
            // lblresult
            // 
            lblresult.BackColor = Color.White;
            lblresult.Location = new Point(1, 92);
            lblresult.Name = "lblresult";
            lblresult.Size = new Size(259, 188);
            lblresult.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(272, 326);
            Controls.Add(btndob);
            Controls.Add(tbdarab);
            Controls.Add(lblresult);
            Controls.Add(label1);
            Name = "Form1";
            Text = "kockadobások";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbdarab;
        private Button btndob;
        private Label lblresult;
    }
}
