namespace App_511_Weather
{
    partial class WeatherItemControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.dataPanel1 = new App_511_Weather.DataPanel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelValue = new System.Windows.Forms.Label();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.dataPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // dataPanel1
            // 
            this.dataPanel1.BackColor = System.Drawing.Color.Transparent;
            this.dataPanel1.Controls.Add(this.pictureBoxIcon);
            this.dataPanel1.Controls.Add(this.labelValue);
            this.dataPanel1.Controls.Add(this.labelTitle);
            this.dataPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPanel1.Location = new System.Drawing.Point(0, 0);
            this.dataPanel1.Name = "dataPanel1";
            this.dataPanel1.Size = new System.Drawing.Size(130, 80);
            this.dataPanel1.TabIndex = 0;
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Location = new System.Drawing.Point(12, 20);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcon.TabIndex = 2;
            this.pictureBoxIcon.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelTitle.Location = new System.Drawing.Point(58, 15);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(40, 20);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title";
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelValue.Location = new System.Drawing.Point(58, 40);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(50, 23);
            this.labelValue.TabIndex = 1;
            this.labelValue.Text = "Value";
            // 
            // WeatherItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.dataPanel1);
            this.Name = "WeatherItemControl";
            this.Size = new System.Drawing.Size(130, 80);
            this.dataPanel1.ResumeLayout(false);
            this.dataPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private App_511_Weather.DataPanel dataPanel1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
    }
}