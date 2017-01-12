namespace Multithreading
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
            this.cmdGetWeb = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.cmdGetWebAsync = new System.Windows.Forms.Button();
            this.lblWork = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdGetWeb
            // 
            this.cmdGetWeb.Location = new System.Drawing.Point(578, 12);
            this.cmdGetWeb.Name = "cmdGetWeb";
            this.cmdGetWeb.Size = new System.Drawing.Size(106, 23);
            this.cmdGetWeb.TabIndex = 0;
            this.cmdGetWeb.Text = "GetWeb";
            this.cmdGetWeb.UseVisualStyleBackColor = true;
            this.cmdGetWeb.Click += new System.EventHandler(this.cmdGetWeb_Click);
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(12, 12);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(539, 284);
            this.txtContent.TabIndex = 1;
            // 
            // cmdGetWebAsync
            // 
            this.cmdGetWebAsync.Location = new System.Drawing.Point(578, 57);
            this.cmdGetWebAsync.Name = "cmdGetWebAsync";
            this.cmdGetWebAsync.Size = new System.Drawing.Size(106, 23);
            this.cmdGetWebAsync.TabIndex = 2;
            this.cmdGetWebAsync.Text = "GetWeb Async";
            this.cmdGetWebAsync.UseVisualStyleBackColor = true;
            this.cmdGetWebAsync.Click += new System.EventHandler(this.cmdGetWebAsync_Click);
            // 
            // lblWork
            // 
            this.lblWork.AutoSize = true;
            this.lblWork.Location = new System.Drawing.Point(578, 135);
            this.lblWork.Name = "lblWork";
            this.lblWork.Size = new System.Drawing.Size(44, 13);
            this.lblWork.TabIndex = 3;
            this.lblWork.Text = "NoData";
            this.lblWork.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 308);
            this.Controls.Add(this.lblWork);
            this.Controls.Add(this.cmdGetWebAsync);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.cmdGetWeb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdGetWeb;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button cmdGetWebAsync;
        private System.Windows.Forms.Label lblWork;
    }
}

