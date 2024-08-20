namespace BaiTrang57
{
    partial class Button
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
            this.btnButton = new System.Windows.Forms.Button();
            this.btnButtonFlat = new System.Windows.Forms.Button();
            this.ckbMauChu = new System.Windows.Forms.CheckBox();
            this.cknMauNen = new System.Windows.Forms.CheckBox();
            this.rdFlat = new System.Windows.Forms.RadioButton();
            this.rdPopup = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnButton
            // 
            this.btnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnButton.ForeColor = System.Drawing.Color.Red;
            this.btnButton.Location = new System.Drawing.Point(116, 75);
            this.btnButton.Name = "btnButton";
            this.btnButton.Size = new System.Drawing.Size(157, 40);
            this.btnButton.TabIndex = 0;
            this.btnButton.Text = "Button";
            this.btnButton.UseVisualStyleBackColor = false;
            // 
            // btnButtonFlat
            // 
            this.btnButtonFlat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnButtonFlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnButtonFlat.Location = new System.Drawing.Point(116, 290);
            this.btnButtonFlat.Name = "btnButtonFlat";
            this.btnButtonFlat.Size = new System.Drawing.Size(157, 41);
            this.btnButtonFlat.TabIndex = 1;
            this.btnButtonFlat.Text = "Button Flat";
            this.btnButtonFlat.UseVisualStyleBackColor = false;
            // 
            // ckbMauChu
            // 
            this.ckbMauChu.AutoSize = true;
            this.ckbMauChu.Checked = true;
            this.ckbMauChu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbMauChu.Location = new System.Drawing.Point(438, 42);
            this.ckbMauChu.Name = "ckbMauChu";
            this.ckbMauChu.Size = new System.Drawing.Size(159, 24);
            this.ckbMauChu.TabIndex = 2;
            this.ckbMauChu.Text = "Thay đổi màu chữ";
            this.ckbMauChu.UseVisualStyleBackColor = true;
            this.ckbMauChu.CheckedChanged += new System.EventHandler(this.ckbMauChu_CheckedChanged);
            // 
            // cknMauNen
            // 
            this.cknMauNen.AutoSize = true;
            this.cknMauNen.Checked = true;
            this.cknMauNen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cknMauNen.Location = new System.Drawing.Point(438, 147);
            this.cknMauNen.Name = "cknMauNen";
            this.cknMauNen.Size = new System.Drawing.Size(160, 24);
            this.cknMauNen.TabIndex = 3;
            this.cknMauNen.Text = "Thay đổi màu nền";
            this.cknMauNen.UseVisualStyleBackColor = true;
            this.cknMauNen.CheckedChanged += new System.EventHandler(this.cknMauNen_CheckedChanged);
            // 
            // rdFlat
            // 
            this.rdFlat.AutoSize = true;
            this.rdFlat.Location = new System.Drawing.Point(447, 239);
            this.rdFlat.Name = "rdFlat";
            this.rdFlat.Size = new System.Drawing.Size(96, 24);
            this.rdFlat.TabIndex = 4;
            this.rdFlat.Text = "Kiểu Flat";
            this.rdFlat.UseVisualStyleBackColor = true;
            this.rdFlat.CheckedChanged += new System.EventHandler(this.rdFlat_CheckedChanged);
            // 
            // rdPopup
            // 
            this.rdPopup.AutoSize = true;
            this.rdPopup.Checked = true;
            this.rdPopup.Location = new System.Drawing.Point(447, 327);
            this.rdPopup.Name = "rdPopup";
            this.rdPopup.Size = new System.Drawing.Size(115, 24);
            this.rdPopup.TabIndex = 5;
            this.rdPopup.TabStop = true;
            this.rdPopup.Text = "Kiểu Popup";
            this.rdPopup.UseVisualStyleBackColor = true;
            // 
            // Button
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdPopup);
            this.Controls.Add(this.rdFlat);
            this.Controls.Add(this.cknMauNen);
            this.Controls.Add(this.ckbMauChu);
            this.Controls.Add(this.btnButtonFlat);
            this.Controls.Add(this.btnButton);
            this.Name = "Button";
            this.Text = "Buttons";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnButton;
        private System.Windows.Forms.Button btnButtonFlat;
        private System.Windows.Forms.CheckBox ckbMauChu;
        private System.Windows.Forms.CheckBox cknMauNen;
        private System.Windows.Forms.RadioButton rdFlat;
        private System.Windows.Forms.RadioButton rdPopup;
    }
}

