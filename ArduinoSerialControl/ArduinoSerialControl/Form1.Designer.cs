namespace ArduinoSerialControl
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
            this.btnLEDOn = new System.Windows.Forms.Button();
            this.btnLEDOff = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLEDOn
            // 
            this.btnLEDOn.Location = new System.Drawing.Point(78, 70);
            this.btnLEDOn.Name = "btnLEDOn";
            this.btnLEDOn.Size = new System.Drawing.Size(179, 94);
            this.btnLEDOn.TabIndex = 0;
            this.btnLEDOn.Text = "button1";
            this.btnLEDOn.UseVisualStyleBackColor = true;
            this.btnLEDOn.Click += new System.EventHandler(this.btnLEDOn_Click);
            // 
            // btnLEDOff
            // 
            this.btnLEDOff.Location = new System.Drawing.Point(330, 73);
            this.btnLEDOff.Name = "btnLEDOff";
            this.btnLEDOff.Size = new System.Drawing.Size(189, 88);
            this.btnLEDOff.TabIndex = 1;
            this.btnLEDOff.Text = "button2";
            this.btnLEDOff.UseVisualStyleBackColor = true;
            this.btnLEDOff.Click += new System.EventHandler(this.btnLEDOff_Click_1);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(79, 188);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(439, 105);
            this.txtOutput.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnLEDOff);
            this.Controls.Add(this.btnLEDOn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLEDOn;
        private System.Windows.Forms.Button btnLEDOff;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

