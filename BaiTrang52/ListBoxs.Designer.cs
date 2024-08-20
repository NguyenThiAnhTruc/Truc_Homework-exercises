namespace BaiTrang52
{
    partial class ListBoxs
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDanhsach = new System.Windows.Forms.ListBox();
            this.lbDanhsachchon = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách sinh viên lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(437, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh sách sinh viên tham gia bóng đá";
            // 
            // lbDanhsach
            // 
            this.lbDanhsach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbDanhsach.FormattingEnabled = true;
            this.lbDanhsach.ItemHeight = 20;
            this.lbDanhsach.Items.AddRange(new object[] {
            "Pham Vu Ngoc Ha",
            "Hoang Van Hung",
            "Le Thi Van",
            "Nguyen Thi Thu",
            "Le Van Quoc",
            "Le Van Phuoc",
            "Truong Van Dung"});
            this.lbDanhsach.Location = new System.Drawing.Point(12, 91);
            this.lbDanhsach.Name = "lbDanhsach";
            this.lbDanhsach.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbDanhsach.Size = new System.Drawing.Size(309, 324);
            this.lbDanhsach.TabIndex = 2;
            // 
            // lbDanhsachchon
            // 
            this.lbDanhsachchon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbDanhsachchon.FormattingEnabled = true;
            this.lbDanhsachchon.ItemHeight = 20;
            this.lbDanhsachchon.Location = new System.Drawing.Point(452, 92);
            this.lbDanhsachchon.Name = "lbDanhsachchon";
            this.lbDanhsachchon.Size = new System.Drawing.Size(337, 324);
            this.lbDanhsachchon.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAdd.Location = new System.Drawing.Point(342, 158);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 35);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Chọn";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRemove.Location = new System.Drawing.Point(342, 245);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(78, 35);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // ListBoxs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbDanhsachchon);
            this.Controls.Add(this.lbDanhsach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ListBoxs";
            this.Text = "ListBoxs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbDanhsach;
        private System.Windows.Forms.ListBox lbDanhsachchon;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
    }
}

