namespace Pstemmer
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
            this.modelFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxInput_directory = new System.Windows.Forms.TextBox();
            this.textBoxOutput_directory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_browse_in = new System.Windows.Forms.Button();
            this.button_browse_out = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input directory";
            // 
            // textBoxInput_directory
            // 
            this.textBoxInput_directory.Location = new System.Drawing.Point(88, 100);
            this.textBoxInput_directory.Name = "textBoxInput_directory";
            this.textBoxInput_directory.Size = new System.Drawing.Size(356, 33);
            this.textBoxInput_directory.TabIndex = 1;
            this.textBoxInput_directory.Text = "C:\\Pstemmer\\Input";
            // 
            // textBoxOutput_directory
            // 
            this.textBoxOutput_directory.Location = new System.Drawing.Point(638, 89);
            this.textBoxOutput_directory.Name = "textBoxOutput_directory";
            this.textBoxOutput_directory.Size = new System.Drawing.Size(356, 33);
            this.textBoxOutput_directory.TabIndex = 3;
            this.textBoxOutput_directory.Text = "C:\\Pstemmer\\Output";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(633, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Output directory";
            // 
            // button_browse_in
            // 
            this.button_browse_in.Location = new System.Drawing.Point(450, 97);
            this.button_browse_in.Name = "button_browse_in";
            this.button_browse_in.Size = new System.Drawing.Size(49, 37);
            this.button_browse_in.TabIndex = 4;
            this.button_browse_in.Text = "...";
            this.button_browse_in.UseVisualStyleBackColor = true;
            this.button_browse_in.Click += new System.EventHandler(this.button_browse_in_Click);
            // 
            // button_browse_out
            // 
            this.button_browse_out.Location = new System.Drawing.Point(1000, 86);
            this.button_browse_out.Name = "button_browse_out";
            this.button_browse_out.Size = new System.Drawing.Size(49, 37);
            this.button_browse_out.TabIndex = 5;
            this.button_browse_out.Text = "...";
            this.button_browse_out.UseVisualStyleBackColor = true;
            this.button_browse_out.Click += new System.EventHandler(this.button_browse_out_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(471, 213);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(247, 60);
            this.btnRun.TabIndex = 6;
            this.btnRun.Text = "RUN";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(65, 305);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(952, 54);
            this.progressBar1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 386);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.button_browse_out);
            this.Controls.Add(this.button_browse_in);
            this.Controls.Add(this.textBoxOutput_directory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxInput_directory);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pstemmer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog modelFolderDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxInput_directory;
        private System.Windows.Forms.TextBox textBoxOutput_directory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_browse_in;
        private System.Windows.Forms.Button button_browse_out;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

