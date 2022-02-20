namespace FF14
{
    partial class FF14MW
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
            this.Items = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Arms_Classes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Levels = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Items
            // 
            this.Items.FormattingEnabled = true;
            this.Items.Items.AddRange(new object[] {
            "Arms"});
            this.Items.Location = new System.Drawing.Point(12, 46);
            this.Items.Name = "Items";
            this.Items.Size = new System.Drawing.Size(121, 23);
            this.Items.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Items";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Arms_Classes
            // 
            this.Arms_Classes.FormattingEnabled = true;
            this.Arms_Classes.Items.AddRange(new object[] {
            "Gladiator"});
            this.Arms_Classes.Location = new System.Drawing.Point(159, 46);
            this.Arms_Classes.Name = "Arms_Classes";
            this.Arms_Classes.Size = new System.Drawing.Size(121, 23);
            this.Arms_Classes.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Arms Classes";
            // 
            // Levels
            // 
            this.Levels.FormattingEnabled = true;
            this.Levels.Items.AddRange(new object[] {
            "1-10"});
            this.Levels.Location = new System.Drawing.Point(303, 46);
            this.Levels.Name = "Levels";
            this.Levels.Size = new System.Drawing.Size(121, 23);
            this.Levels.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Levels";
            // 
            // FF14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Levels);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Arms_Classes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Items);
            this.Name = "FF14";
            this.Text = "FF14";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Button button1;
        public ComboBox Items;
        private ComboBox Arms_Classes;
        private Label label2;
        private ComboBox Levels;
        private Label label3;
    }
}