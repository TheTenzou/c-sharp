
namespace Task3
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxZ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxW = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonLine = new System.Windows.Forms.Button();
            this.buttonRec = new System.Windows.Forms.Button();
            this.buttonElips = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(657, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "X=";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(688, 10);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 22);
            this.textBoxX.TabIndex = 1;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(688, 38);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(100, 22);
            this.textBoxY.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(657, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y=";
            // 
            // textBoxZ
            // 
            this.textBoxZ.Location = new System.Drawing.Point(688, 66);
            this.textBoxZ.Name = "textBoxZ";
            this.textBoxZ.Size = new System.Drawing.Size(100, 22);
            this.textBoxZ.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(657, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Z=";
            // 
            // textBoxW
            // 
            this.textBoxW.Location = new System.Drawing.Point(688, 94);
            this.textBoxW.Name = "textBoxW";
            this.textBoxW.Size = new System.Drawing.Size(100, 22);
            this.textBoxW.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(657, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "W=";
            // 
            // buttonLine
            // 
            this.buttonLine.Location = new System.Drawing.Point(688, 122);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(100, 23);
            this.buttonLine.TabIndex = 8;
            this.buttonLine.Text = "Line";
            this.buttonLine.UseVisualStyleBackColor = true;
            this.buttonLine.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // buttonRec
            // 
            this.buttonRec.Location = new System.Drawing.Point(688, 151);
            this.buttonRec.Name = "buttonRec";
            this.buttonRec.Size = new System.Drawing.Size(100, 23);
            this.buttonRec.TabIndex = 9;
            this.buttonRec.Text = "Rec";
            this.buttonRec.UseVisualStyleBackColor = true;
            this.buttonRec.Click += new System.EventHandler(this.buttonRec_Click);
            // 
            // buttonElips
            // 
            this.buttonElips.Location = new System.Drawing.Point(688, 180);
            this.buttonElips.Name = "buttonElips";
            this.buttonElips.Size = new System.Drawing.Size(100, 23);
            this.buttonElips.TabIndex = 10;
            this.buttonElips.Text = "Elips";
            this.buttonElips.UseVisualStyleBackColor = true;
            this.buttonElips.Click += new System.EventHandler(this.buttonElips_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonElips);
            this.Controls.Add(this.buttonRec);
            this.Controls.Add(this.buttonLine);
            this.Controls.Add(this.textBoxW);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxZ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Task3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxZ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxW;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonLine;
        private System.Windows.Forms.Button buttonRec;
        private System.Windows.Forms.Button buttonElips;
    }
}

