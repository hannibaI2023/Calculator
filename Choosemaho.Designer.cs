
namespace calculator_ver_2
{
    partial class Choosemaho
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
            this.quadra = new System.Windows.Forms.Button();
            this.Multi2 = new System.Windows.Forms.Button();
            this.Multi3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // quadra
            // 
            this.quadra.BackColor = System.Drawing.Color.Pink;
            this.quadra.ForeColor = System.Drawing.Color.Crimson;
            this.quadra.Location = new System.Drawing.Point(16, 54);
            this.quadra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quadra.Name = "quadra";
            this.quadra.Size = new System.Drawing.Size(332, 42);
            this.quadra.TabIndex = 0;
            this.quadra.Text = "aX^2 + bX + c = 0";
            this.quadra.UseVisualStyleBackColor = false;
            this.quadra.Click += new System.EventHandler(this.quadra_Click);
            // 
            // Multi2
            // 
            this.Multi2.BackColor = System.Drawing.Color.Pink;
            this.Multi2.ForeColor = System.Drawing.Color.Crimson;
            this.Multi2.Location = new System.Drawing.Point(16, 103);
            this.Multi2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Multi2.Name = "Multi2";
            this.Multi2.Size = new System.Drawing.Size(332, 42);
            this.Multi2.TabIndex = 1;
            this.Multi2.Text = "anX + bnY = cn";
            this.Multi2.UseVisualStyleBackColor = false;
            this.Multi2.Click += new System.EventHandler(this.Multi2_Click);
            // 
            // Multi3
            // 
            this.Multi3.BackColor = System.Drawing.Color.Pink;
            this.Multi3.ForeColor = System.Drawing.Color.Crimson;
            this.Multi3.Location = new System.Drawing.Point(16, 153);
            this.Multi3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Multi3.Name = "Multi3";
            this.Multi3.Size = new System.Drawing.Size(332, 42);
            this.Multi3.TabIndex = 2;
            this.Multi3.Text = "anX + bnY + cnZ = dn";
            this.Multi3.UseVisualStyleBackColor = false;
            this.Multi3.Click += new System.EventHandler(this.Multi3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "CHOOSE YOUR MAHO";
            // 
            // Choosemaho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(359, 213);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Multi3);
            this.Controls.Add(this.Multi2);
            this.Controls.Add(this.quadra);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Choosemaho";
            this.Text = "Equation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button quadra;
        private System.Windows.Forms.Button Multi2;
        private System.Windows.Forms.Button Multi3;
        private System.Windows.Forms.Label label1;
    }
}