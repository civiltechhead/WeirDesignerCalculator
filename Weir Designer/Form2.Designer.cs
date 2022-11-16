
namespace Weir_Designer
{
    partial class Form2
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
            this.results = new System.Windows.Forms.RichTextBox();
            this.ok_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // results
            // 
            this.results.Enabled = false;
            this.results.Location = new System.Drawing.Point(12, 12);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(935, 436);
            this.results.TabIndex = 0;
            this.results.Text = "";
            // 
            // ok_btn
            // 
            this.ok_btn.Location = new System.Drawing.Point(12, 454);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(202, 52);
            this.ok_btn.TabIndex = 1;
            this.ok_btn.Text = "Okay";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(745, 454);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(202, 52);
            this.save_btn.TabIndex = 2;
            this.save_btn.Text = "Save to text";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 518);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.results);
            this.Name = "Form2";
            this.Text = "Results";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox results;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Button save_btn;
    }
}