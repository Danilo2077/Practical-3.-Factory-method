namespace Practical_3.Factory_method
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
            this.ButtonCylinder = new System.Windows.Forms.Button();
            this.ButtonPyramid = new System.Windows.Forms.Button();
            this.ButtonCube = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonCylinder
            // 
            this.ButtonCylinder.Location = new System.Drawing.Point(266, 230);
            this.ButtonCylinder.Name = "ButtonCylinder";
            this.ButtonCylinder.Size = new System.Drawing.Size(75, 23);
            this.ButtonCylinder.TabIndex = 0;
            this.ButtonCylinder.Text = "Циліндр";
            this.ButtonCylinder.UseVisualStyleBackColor = true;
            this.ButtonCylinder.Click += new System.EventHandler(this.ButtonCylinder_Click);
            // 
            // ButtonPyramid
            // 
            this.ButtonPyramid.Location = new System.Drawing.Point(392, 230);
            this.ButtonPyramid.Name = "ButtonPyramid";
            this.ButtonPyramid.Size = new System.Drawing.Size(75, 23);
            this.ButtonPyramid.TabIndex = 1;
            this.ButtonPyramid.Text = "Піраміда";
            this.ButtonPyramid.UseVisualStyleBackColor = true;
            this.ButtonPyramid.Click += new System.EventHandler(this.ButtonPyramid_Click);
            // 
            // ButtonCube
            // 
            this.ButtonCube.Location = new System.Drawing.Point(151, 230);
            this.ButtonCube.Name = "ButtonCube";
            this.ButtonCube.Size = new System.Drawing.Size(75, 23);
            this.ButtonCube.TabIndex = 2;
            this.ButtonCube.Text = "Куб";
            this.ButtonCube.UseVisualStyleBackColor = true;
            this.ButtonCube.Click += new System.EventHandler(this.ButtonCube_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 335);
            this.Controls.Add(this.ButtonCube);
            this.Controls.Add(this.ButtonPyramid);
            this.Controls.Add(this.ButtonCylinder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonCylinder;
        private System.Windows.Forms.Button ButtonPyramid;
        private System.Windows.Forms.Button ButtonCube;
    }
}

