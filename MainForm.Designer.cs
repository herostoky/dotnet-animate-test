
namespace animate_test
{
    partial class MainForm
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
            this.plane = new System.Windows.Forms.Button();
            this.moveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // plane
            // 
            this.plane.BackColor = System.Drawing.Color.Maroon;
            this.plane.FlatAppearance.BorderSize = 0;
            this.plane.Location = new System.Drawing.Point(30, 23);
            this.plane.Name = "plane";
            this.plane.Size = new System.Drawing.Size(75, 23);
            this.plane.TabIndex = 0;
            this.plane.UseVisualStyleBackColor = false;
            // 
            // moveButton
            // 
            this.moveButton.Location = new System.Drawing.Point(483, 95);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(75, 23);
            this.moveButton.TabIndex = 1;
            this.moveButton.Text = "Move";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Click += new System.EventHandler(this.moveButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.moveButton);
            this.Controls.Add(this.plane);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button plane;
        private System.Windows.Forms.Button moveButton;
    }
}

