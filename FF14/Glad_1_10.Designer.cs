namespace FF14
{
    partial class Glad_1_10
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
            this.arms = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Findbtn = new System.Windows.Forms.Button();
            this.Homebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // arms
            // 
            this.arms.FormattingEnabled = true;
            this.arms.Items.AddRange(new object[] {
            "Ultimum"});
            this.arms.Location = new System.Drawing.Point(243, 90);
            this.arms.Name = "arms";
            this.arms.Size = new System.Drawing.Size(121, 23);
            this.arms.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pick from List";
            // 
            // Findbtn
            // 
            this.Findbtn.Location = new System.Drawing.Point(240, 131);
            this.Findbtn.Name = "Findbtn";
            this.Findbtn.Size = new System.Drawing.Size(124, 23);
            this.Findbtn.TabIndex = 2;
            this.Findbtn.Text = "Find Weapon";
            this.Findbtn.UseVisualStyleBackColor = true;
            this.Findbtn.Click += new System.EventHandler(this.Findbtn_Click);
            // 
            // Homebtn
            // 
            this.Homebtn.Location = new System.Drawing.Point(263, 175);
            this.Homebtn.Name = "Homebtn";
            this.Homebtn.Size = new System.Drawing.Size(75, 23);
            this.Homebtn.TabIndex = 3;
            this.Homebtn.Text = "Home";
            this.Homebtn.UseVisualStyleBackColor = true;
            this.Homebtn.Click += new System.EventHandler(this.Homebtn_Click);
            // 
            // Glad_1_10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Homebtn);
            this.Controls.Add(this.Findbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.arms);
            this.Name = "Glad_1_10";
            this.Text = "Glad_1_10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox arms;
        private Label label1;
        private Button Findbtn;
        private Button Homebtn;
    }
}