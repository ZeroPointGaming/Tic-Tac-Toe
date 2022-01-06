namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.a1 = new System.Windows.Forms.Button();
            this.a2 = new System.Windows.Forms.Button();
            this.a3 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.c3 = new System.Windows.Forms.Button();
            this.c2 = new System.Windows.Forms.Button();
            this.c1 = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // a1
            // 
            this.a1.Location = new System.Drawing.Point(12, 12);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(64, 64);
            this.a1.TabIndex = 0;
            this.a1.UseVisualStyleBackColor = true;
            this.a1.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // a2
            // 
            this.a2.Location = new System.Drawing.Point(82, 12);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(64, 64);
            this.a2.TabIndex = 1;
            this.a2.UseVisualStyleBackColor = true;
            this.a2.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // a3
            // 
            this.a3.Location = new System.Drawing.Point(152, 12);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(64, 64);
            this.a3.TabIndex = 2;
            this.a3.UseVisualStyleBackColor = true;
            this.a3.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(152, 82);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(64, 64);
            this.b3.TabIndex = 5;
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(82, 82);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(64, 64);
            this.b2.TabIndex = 4;
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(12, 82);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(64, 64);
            this.b1.TabIndex = 3;
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // c3
            // 
            this.c3.Location = new System.Drawing.Point(152, 152);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(64, 64);
            this.c3.TabIndex = 8;
            this.c3.UseVisualStyleBackColor = true;
            this.c3.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // c2
            // 
            this.c2.Location = new System.Drawing.Point(82, 152);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(64, 64);
            this.c2.TabIndex = 7;
            this.c2.UseVisualStyleBackColor = true;
            this.c2.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // c1
            // 
            this.c1.Location = new System.Drawing.Point(12, 152);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(64, 64);
            this.c1.TabIndex = 6;
            this.c1.UseVisualStyleBackColor = true;
            this.c1.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(12, 222);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 33);
            this.btnNew.TabIndex = 9;
            this.btnNew.Text = "New Game";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(140, 222);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 33);
            this.btnAbout.TabIndex = 10;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 264);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.a1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(243, 303);
            this.MinimumSize = new System.Drawing.Size(243, 303);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button a1;
        private System.Windows.Forms.Button a2;
        private System.Windows.Forms.Button a3;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button c3;
        private System.Windows.Forms.Button c2;
        private System.Windows.Forms.Button c1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnAbout;
    }
}

