
namespace ServerConfigForm_P5_20190140005
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
            this.buttonOn = new System.Windows.Forms.Button();
            this.buttonOff = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelKet = new System.Windows.Forms.Label();
            this.labelOnorOff = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOn
            // 
            this.buttonOn.Location = new System.Drawing.Point(128, 265);
            this.buttonOn.Name = "buttonOn";
            this.buttonOn.Size = new System.Drawing.Size(75, 23);
            this.buttonOn.TabIndex = 0;
            this.buttonOn.Text = "ON";
            this.buttonOn.UseVisualStyleBackColor = true;
            this.buttonOn.Click += new System.EventHandler(this.buttonOn_Click);
            // 
            // buttonOff
            // 
            this.buttonOff.Location = new System.Drawing.Point(290, 265);
            this.buttonOff.Name = "buttonOff";
            this.buttonOff.Size = new System.Drawing.Size(75, 23);
            this.buttonOff.TabIndex = 1;
            this.buttonOff.Text = "OFF";
            this.buttonOff.UseVisualStyleBackColor = true;
            this.buttonOff.Click += new System.EventHandler(this.buttonOff_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelKet
            // 
            this.labelKet.AutoSize = true;
            this.labelKet.Location = new System.Drawing.Point(214, 70);
            this.labelKet.Name = "labelKet";
            this.labelKet.Size = new System.Drawing.Size(0, 17);
            this.labelKet.TabIndex = 3;
            // 
            // labelOnorOff
            // 
            this.labelOnorOff.AutoSize = true;
            this.labelOnorOff.Location = new System.Drawing.Point(214, 111);
            this.labelOnorOff.Name = "labelOnorOff";
            this.labelOnorOff.Size = new System.Drawing.Size(0, 17);
            this.labelOnorOff.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 450);
            this.Controls.Add(this.labelOnorOff);
            this.Controls.Add(this.labelKet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOff);
            this.Controls.Add(this.buttonOn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOn;
        private System.Windows.Forms.Button buttonOff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelKet;
        private System.Windows.Forms.Label labelOnorOff;
    }
}

