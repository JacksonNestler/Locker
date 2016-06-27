namespace Locker
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
            this.mainBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.boxOne = new System.Windows.Forms.TextBox();
            this.boxTwo = new System.Windows.Forms.TextBox();
            this.boxThree = new System.Windows.Forms.TextBox();
            this.boxFour = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mainBox
            // 
            this.mainBox.Location = new System.Drawing.Point(87, 45);
            this.mainBox.Name = "mainBox";
            this.mainBox.Size = new System.Drawing.Size(475, 133);
            this.mainBox.TabIndex = 0;
            this.mainBox.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(511, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Check Key";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // boxOne
            // 
            this.boxOne.Location = new System.Drawing.Point(87, 201);
            this.boxOne.Name = "boxOne";
            this.boxOne.Size = new System.Drawing.Size(100, 20);
            this.boxOne.TabIndex = 2;
            // 
            // boxTwo
            // 
            this.boxTwo.Location = new System.Drawing.Point(193, 201);
            this.boxTwo.Name = "boxTwo";
            this.boxTwo.Size = new System.Drawing.Size(100, 20);
            this.boxTwo.TabIndex = 3;
            // 
            // boxThree
            // 
            this.boxThree.Location = new System.Drawing.Point(299, 201);
            this.boxThree.Name = "boxThree";
            this.boxThree.Size = new System.Drawing.Size(100, 20);
            this.boxThree.TabIndex = 4;
            // 
            // boxFour
            // 
            this.boxFour.Location = new System.Drawing.Point(405, 201);
            this.boxFour.Name = "boxFour";
            this.boxFour.Size = new System.Drawing.Size(100, 20);
            this.boxFour.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 243);
            this.Controls.Add(this.boxFour);
            this.Controls.Add(this.boxThree);
            this.Controls.Add(this.boxTwo);
            this.Controls.Add(this.boxOne);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mainBox);
            this.Name = "Form1";
            this.Text = "Locked";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox mainBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox boxOne;
        private System.Windows.Forms.TextBox boxTwo;
        private System.Windows.Forms.TextBox boxThree;
        private System.Windows.Forms.TextBox boxFour;
    }
}

