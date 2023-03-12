namespace Files_Organizer
{
    partial class Home
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
            this.browseBtn = new System.Windows.Forms.Button();
            this.applyBtn = new System.Windows.Forms.Button();
            this.dirName = new System.Windows.Forms.Label();
            this.dir = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.label1.Location = new System.Drawing.Point(69, 56);
=======
            this.label1.Location = new System.Drawing.Point(96, 194);
>>>>>>> e803ebf224a1352cc4bb92f8d88cc1a7fc982755
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Organizer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select the folder you want to organize:";
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(337, 268);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(75, 23);
            this.browseBtn.TabIndex = 2;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(168, 344);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(109, 33);
            this.applyBtn.TabIndex = 3;
            this.applyBtn.Text = "Apply ";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // dirName
            // 
            this.dirName.AutoSize = true;
            this.dirName.Location = new System.Drawing.Point(155, 307);
            this.dirName.Name = "dirName";
            this.dirName.Size = new System.Drawing.Size(111, 13);
            this.dirName.TabIndex = 4;
            this.dirName.Text = "No Directory Selected";
            this.dirName.Visible = false;
            // 
            // dir
            // 
            this.dir.AutoSize = true;
            this.dir.Location = new System.Drawing.Point(104, 307);
            this.dir.Name = "dir";
            this.dir.Size = new System.Drawing.Size(52, 13);
            this.dir.TabIndex = 5;
            this.dir.Text = "Directory:";
            this.dir.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Alternates Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Created by: Developer Waleed";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(412, 357);
            this.Controls.Add(this.label3);
=======
            this.ClientSize = new System.Drawing.Size(442, 564);
>>>>>>> e803ebf224a1352cc4bb92f8d88cc1a7fc982755
            this.Controls.Add(this.dir);
            this.Controls.Add(this.dirName);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Label dirName;
        private System.Windows.Forms.Label dir;
        private System.Windows.Forms.Label label3;
    }
}

