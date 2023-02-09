namespace NuclearControl
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
            this.label2 = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.subLabel1 = new System.Windows.Forms.Label();
            this.titleLabel2 = new System.Windows.Forms.Label();
            this.Nuke1 = new System.Windows.Forms.Label();
            this.Nuke2 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 11);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(360, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 11);
            this.label2.TabIndex = 1;
            this.label2.Text = "GROUNDED";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Red;
            this.titleLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(311, 43);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(106, 16);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Nuclear Control";
            this.titleLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // subLabel1
            // 
            this.subLabel1.BackColor = System.Drawing.Color.Red;
            this.subLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subLabel1.Location = new System.Drawing.Point(173, 121);
            this.subLabel1.Name = "subLabel1";
            this.subLabel1.Size = new System.Drawing.Size(52, 23);
            this.subLabel1.TabIndex = 3;
            this.subLabel1.Text = "Nuke 1";
            // 
            // titleLabel2
            // 
            this.titleLabel2.BackColor = System.Drawing.Color.Red;
            this.titleLabel2.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel2.Location = new System.Drawing.Point(502, 121);
            this.titleLabel2.Name = "titleLabel2";
            this.titleLabel2.Size = new System.Drawing.Size(52, 23);
            this.titleLabel2.TabIndex = 4;
            this.titleLabel2.Text = "Nuke 2";
            // 
            // Nuke1
            // 
            this.Nuke1.BackColor = System.Drawing.Color.Lime;
            this.Nuke1.Location = new System.Drawing.Point(148, 184);
            this.Nuke1.Name = "Nuke1";
            this.Nuke1.Size = new System.Drawing.Size(100, 59);
            this.Nuke1.TabIndex = 5;
            this.Nuke1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Nuke2
            // 
            this.Nuke2.BackColor = System.Drawing.Color.Lime;
            this.Nuke2.Location = new System.Drawing.Point(479, 184);
            this.Nuke2.Name = "Nuke2";
            this.Nuke2.Size = new System.Drawing.Size(100, 59);
            this.Nuke2.TabIndex = 6;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Red;
            this.startButton.Location = new System.Drawing.Point(325, 116);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "LAUNCH";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.Color.White;
            this.statusLabel.Location = new System.Drawing.Point(300, 281);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(54, 11);
            this.statusLabel.TabIndex = 8;
            this.statusLabel.Text = "STATUS:";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(747, 424);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.Nuke2);
            this.Controls.Add(this.Nuke1);
            this.Controls.Add(this.titleLabel2);
            this.Controls.Add(this.subLabel1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "NuclearControl";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label subLabel1;
        private System.Windows.Forms.Label titleLabel2;
        private System.Windows.Forms.Label Nuke1;
        private System.Windows.Forms.Label Nuke2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label statusLabel;
    }
}

