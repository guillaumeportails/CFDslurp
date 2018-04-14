namespace CFDslurp
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
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.textBoxURL = new System.Windows.Forms.TextBox ();
            this.button1 = new System.Windows.Forms.Button ();
            this.webBrowser = new System.Windows.Forms.WebBrowser ();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer ();
            this.button4 = new System.Windows.Forms.Button ();
            this.button3 = new System.Windows.Forms.Button ();
            this.button2 = new System.Windows.Forms.Button ();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit ();
            this.splitContainer1.Panel1.SuspendLayout ();
            this.splitContainer1.Panel2.SuspendLayout ();
            this.splitContainer1.SuspendLayout ();
            this.SuspendLayout ();
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point (8, 10);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size (410, 20);
            this.textBoxURL.TabIndex = 0;
            this.textBoxURL.Text = "http://parapente.ffvl.fr/cfd/liste/2010?page=";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point (505, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size (75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add IGC";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler (this.button1_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point (0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size (20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size (755, 481);
            this.webBrowser.TabIndex = 2;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler (this.webBrowser_DocumentCompleted);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point (0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add (this.button4);
            this.splitContainer1.Panel1.Controls.Add (this.button3);
            this.splitContainer1.Panel1.Controls.Add (this.button2);
            this.splitContainer1.Panel1.Controls.Add (this.textBoxURL);
            this.splitContainer1.Panel1.Controls.Add (this.button1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add (this.webBrowser);
            this.splitContainer1.Size = new System.Drawing.Size (755, 533);
            this.splitContainer1.SplitterDistance = 48;
            this.splitContainer1.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point (668, 8);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size (75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler (this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point (586, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size (75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Get IGC";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler (this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point (424, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size (75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "GOTO";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler (this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (755, 533);
            this.Controls.Add (this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout (false);
            this.splitContainer1.Panel1.PerformLayout ();
            this.splitContainer1.Panel2.ResumeLayout (false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit ();
            this.splitContainer1.ResumeLayout (false);
            this.ResumeLayout (false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

