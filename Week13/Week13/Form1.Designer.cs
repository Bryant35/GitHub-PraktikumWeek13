
namespace Week13
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
            this.labelInput = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonProcess = new System.Windows.Forms.Button();
            this.labelTampilan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(25, 13);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(63, 13);
            this.labelInput.TabIndex = 0;
            this.labelInput.Text = "Input Data :";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(28, 41);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(429, 20);
            this.textBoxInput.TabIndex = 1;
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            // 
            // buttonProcess
            // 
            this.buttonProcess.Location = new System.Drawing.Point(28, 86);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(137, 50);
            this.buttonProcess.TabIndex = 2;
            this.buttonProcess.Text = "Proses";
            this.buttonProcess.UseVisualStyleBackColor = true;
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);
            // 
            // labelTampilan
            // 
            this.labelTampilan.AutoSize = true;
            this.labelTampilan.Location = new System.Drawing.Point(28, 249);
            this.labelTampilan.Name = "labelTampilan";
            this.labelTampilan.Size = new System.Drawing.Size(50, 13);
            this.labelTampilan.TabIndex = 3;
            this.labelTampilan.Text = "[EMPTY]";
            this.labelTampilan.TextChanged += new System.EventHandler(this.buttonProcess_Click);
            this.labelTampilan.Click += new System.EventHandler(this.labelTampilan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTampilan);
            this.Controls.Add(this.buttonProcess);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.labelInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonProcess;
        private System.Windows.Forms.Label labelTampilan;
    }
}

