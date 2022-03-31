namespace TheUnfortunateEvents
{
    partial class form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.outputLabel = new System.Windows.Forms.Label();
            this.option1Button = new System.Windows.Forms.Button();
            this.option2Button = new System.Windows.Forms.Button();
            this.option3Button = new System.Windows.Forms.Button();
            this.option1Label = new System.Windows.Forms.Label();
            this.option2Label = new System.Windows.Forms.Label();
            this.option3Label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.Snow;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(49, 9);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(696, 119);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "label1";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // option1Button
            // 
            this.option1Button.Location = new System.Drawing.Point(49, 370);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(59, 53);
            this.option1Button.TabIndex = 1;
            this.option1Button.Text = "option 1";
            this.option1Button.UseVisualStyleBackColor = true;
            this.option1Button.Click += new System.EventHandler(this.option1Button_Click);
            // 
            // option2Button
            // 
            this.option2Button.Location = new System.Drawing.Point(283, 370);
            this.option2Button.Name = "option2Button";
            this.option2Button.Size = new System.Drawing.Size(59, 53);
            this.option2Button.TabIndex = 2;
            this.option2Button.Text = "option 2";
            this.option2Button.UseVisualStyleBackColor = true;
            this.option2Button.Click += new System.EventHandler(this.option2Button_Click);
            // 
            // option3Button
            // 
            this.option3Button.Location = new System.Drawing.Point(517, 370);
            this.option3Button.Name = "option3Button";
            this.option3Button.Size = new System.Drawing.Size(59, 53);
            this.option3Button.TabIndex = 3;
            this.option3Button.Text = "option 3";
            this.option3Button.UseVisualStyleBackColor = true;
            this.option3Button.Click += new System.EventHandler(this.option3Button_Click);
            // 
            // option1Label
            // 
            this.option1Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.option1Label.Location = new System.Drawing.Point(114, 370);
            this.option1Label.Name = "option1Label";
            this.option1Label.Size = new System.Drawing.Size(163, 53);
            this.option1Label.TabIndex = 4;
            this.option1Label.Text = "label1";
            this.option1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // option2Label
            // 
            this.option2Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.option2Label.Location = new System.Drawing.Point(348, 370);
            this.option2Label.Name = "option2Label";
            this.option2Label.Size = new System.Drawing.Size(163, 53);
            this.option2Label.TabIndex = 5;
            this.option2Label.Text = "label2";
            this.option2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // option3Label
            // 
            this.option3Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.option3Label.Location = new System.Drawing.Point(582, 370);
            this.option3Label.Name = "option3Label";
            this.option3Label.Size = new System.Drawing.Size(163, 53);
            this.option3Label.TabIndex = 6;
            this.option3Label.Text = "label3";
            this.option3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(186, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(415, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.option3Label);
            this.Controls.Add(this.option2Label);
            this.Controls.Add(this.option1Label);
            this.Controls.Add(this.option3Button);
            this.Controls.Add(this.option2Button);
            this.Controls.Add(this.option1Button);
            this.Controls.Add(this.outputLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form1";
            this.Text = "The Unfortunate Events";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button option1Button;
        private System.Windows.Forms.Button option2Button;
        private System.Windows.Forms.Button option3Button;
        private System.Windows.Forms.Label option1Label;
        private System.Windows.Forms.Label option2Label;
        private System.Windows.Forms.Label option3Label;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

