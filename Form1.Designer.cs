
namespace HWLesson9
{
    partial class Form1
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
            this.RandomBtn = new System.Windows.Forms.Button();
            this.ResultLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fromNumbertxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toNumbertxtBox = new System.Windows.Forms.TextBox();
            this.zerofyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RandomBtn
            // 
            this.RandomBtn.Location = new System.Drawing.Point(39, 45);
            this.RandomBtn.Name = "RandomBtn";
            this.RandomBtn.Size = new System.Drawing.Size(75, 23);
            this.RandomBtn.TabIndex = 0;
            this.RandomBtn.Text = "Press";
            this.RandomBtn.UseVisualStyleBackColor = true;
            this.RandomBtn.Click += new System.EventHandler(this.RandomBtn_Click);
            // 
            // ResultLbl
            // 
            this.ResultLbl.AutoSize = true;
            this.ResultLbl.Location = new System.Drawing.Point(36, 94);
            this.ResultLbl.Name = "ResultLbl";
            this.ResultLbl.Size = new System.Drawing.Size(0, 13);
            this.ResultLbl.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Generate a random number between";
            // 
            // fromNumbertxtBox
            // 
            this.fromNumbertxtBox.Location = new System.Drawing.Point(225, 13);
            this.fromNumbertxtBox.Name = "fromNumbertxtBox";
            this.fromNumbertxtBox.Size = new System.Drawing.Size(40, 20);
            this.fromNumbertxtBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "and";
            // 
            // toNumbertxtBox
            // 
            this.toNumbertxtBox.Location = new System.Drawing.Point(302, 12);
            this.toNumbertxtBox.Name = "toNumbertxtBox";
            this.toNumbertxtBox.Size = new System.Drawing.Size(39, 20);
            this.toNumbertxtBox.TabIndex = 5;
            // 
            // zerofyBtn
            // 
            this.zerofyBtn.Location = new System.Drawing.Point(135, 45);
            this.zerofyBtn.Name = "zerofyBtn";
            this.zerofyBtn.Size = new System.Drawing.Size(75, 23);
            this.zerofyBtn.TabIndex = 6;
            this.zerofyBtn.Text = "zerofy";
            this.zerofyBtn.UseVisualStyleBackColor = true;
            this.zerofyBtn.Click += new System.EventHandler(this.zerofyBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.zerofyBtn);
            this.Controls.Add(this.toNumbertxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fromNumbertxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultLbl);
            this.Controls.Add(this.RandomBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RandomBtn;
        private System.Windows.Forms.Label ResultLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fromNumbertxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox toNumbertxtBox;
        private System.Windows.Forms.Button zerofyBtn;
    }
}

