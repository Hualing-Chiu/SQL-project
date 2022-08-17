namespace DBMS_project
{
    partial class UpdateHospital
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
            this.label3 = new System.Windows.Forms.Label();
            this.hidbox = new System.Windows.Forms.TextBox();
            this.locationbox = new System.Windows.Forms.TextBox();
            this.namebox = new System.Windows.Forms.TextBox();
            this.updatehospitalview = new System.Windows.Forms.DataGridView();
            this.updatebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.updatehospitalview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(32, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "HNO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(29, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "name";
            // 
            // hidbox
            // 
            this.hidbox.Location = new System.Drawing.Point(100, 43);
            this.hidbox.Name = "hidbox";
            this.hidbox.Size = new System.Drawing.Size(100, 25);
            this.hidbox.TabIndex = 4;
            // 
            // locationbox
            // 
            this.locationbox.Location = new System.Drawing.Point(100, 114);
            this.locationbox.Name = "locationbox";
            this.locationbox.Size = new System.Drawing.Size(100, 25);
            this.locationbox.TabIndex = 5;
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(100, 186);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(100, 25);
            this.namebox.TabIndex = 6;
            // 
            // updatehospitalview
            // 
            this.updatehospitalview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.updatehospitalview.Location = new System.Drawing.Point(214, 11);
            this.updatehospitalview.Name = "updatehospitalview";
            this.updatehospitalview.RowHeadersVisible = false;
            this.updatehospitalview.RowTemplate.Height = 27;
            this.updatehospitalview.Size = new System.Drawing.Size(477, 291);
            this.updatehospitalview.TabIndex = 7;
            this.updatehospitalview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.updatehospitalview_CellContentClick);
            // 
            // updatebutton
            // 
            this.updatebutton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.updatebutton.Location = new System.Drawing.Point(125, 241);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(75, 29);
            this.updatebutton.TabIndex = 8;
            this.updatebutton.Text = "更新";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // UpdateHospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 314);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.updatehospitalview);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.locationbox);
            this.Controls.Add(this.hidbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateHospital";
            this.Text = "UpdateHospital";
            this.Load += new System.EventHandler(this.UpdateHospital_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updatehospitalview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hidbox;
        private System.Windows.Forms.TextBox locationbox;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.DataGridView updatehospitalview;
        private System.Windows.Forms.Button updatebutton;
    }
}