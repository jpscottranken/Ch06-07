
namespace Ch07MPGGUI
{
    partial class frmMilesPerGallon
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtMilesDriven = new System.Windows.Forms.TextBox();
            this.txtGallonsUsed = new System.Windows.Forms.TextBox();
            this.txtMPG = new System.Windows.Forms.TextBox();
            this.lblMilesDriven = new System.Windows.Forms.Label();
            this.lblGallonsUsed = new System.Windows.Forms.Label();
            this.lblMPG = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(182, 413);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(189, 72);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(445, 413);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(189, 72);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(701, 413);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(189, 72);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtMilesDriven
            // 
            this.txtMilesDriven.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMilesDriven.Location = new System.Drawing.Point(348, 56);
            this.txtMilesDriven.Name = "txtMilesDriven";
            this.txtMilesDriven.Size = new System.Drawing.Size(588, 38);
            this.txtMilesDriven.TabIndex = 0;
            this.txtMilesDriven.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGallonsUsed
            // 
            this.txtGallonsUsed.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGallonsUsed.Location = new System.Drawing.Point(348, 168);
            this.txtGallonsUsed.Name = "txtGallonsUsed";
            this.txtGallonsUsed.Size = new System.Drawing.Size(588, 38);
            this.txtGallonsUsed.TabIndex = 1;
            this.txtGallonsUsed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMPG
            // 
            this.txtMPG.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMPG.Location = new System.Drawing.Point(348, 276);
            this.txtMPG.Name = "txtMPG";
            this.txtMPG.ReadOnly = true;
            this.txtMPG.Size = new System.Drawing.Size(588, 38);
            this.txtMPG.TabIndex = 5;
            this.txtMPG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMilesDriven
            // 
            this.lblMilesDriven.BackColor = System.Drawing.Color.Lime;
            this.lblMilesDriven.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMilesDriven.Location = new System.Drawing.Point(85, 53);
            this.lblMilesDriven.Name = "lblMilesDriven";
            this.lblMilesDriven.Size = new System.Drawing.Size(223, 41);
            this.lblMilesDriven.TabIndex = 6;
            this.lblMilesDriven.Text = "Miles Driven:";
            // 
            // lblGallonsUsed
            // 
            this.lblGallonsUsed.BackColor = System.Drawing.Color.Lime;
            this.lblGallonsUsed.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGallonsUsed.Location = new System.Drawing.Point(85, 168);
            this.lblGallonsUsed.Name = "lblGallonsUsed";
            this.lblGallonsUsed.Size = new System.Drawing.Size(223, 41);
            this.lblGallonsUsed.TabIndex = 7;
            this.lblGallonsUsed.Text = "Gallons Used:";
            // 
            // lblMPG
            // 
            this.lblMPG.BackColor = System.Drawing.Color.Lime;
            this.lblMPG.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMPG.Location = new System.Drawing.Point(85, 276);
            this.lblMPG.Name = "lblMPG";
            this.lblMPG.Size = new System.Drawing.Size(223, 38);
            this.lblMPG.TabIndex = 8;
            this.lblMPG.Text = "Miles Per Gallon:";
            // 
            // frmMilesPerGallon
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(1102, 544);
            this.Controls.Add(this.lblMPG);
            this.Controls.Add(this.lblGallonsUsed);
            this.Controls.Add(this.lblMilesDriven);
            this.Controls.Add(this.txtMPG);
            this.Controls.Add(this.txtGallonsUsed);
            this.Controls.Add(this.txtMilesDriven);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Name = "frmMilesPerGallon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtMilesDriven;
        private System.Windows.Forms.TextBox txtGallonsUsed;
        private System.Windows.Forms.TextBox txtMPG;
        private System.Windows.Forms.Label lblMilesDriven;
        private System.Windows.Forms.Label lblGallonsUsed;
        private System.Windows.Forms.Label lblMPG;
    }
}

