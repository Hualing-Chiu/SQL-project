namespace DBMS_project
{
    partial class DeleteHospital
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
            this.deletehospitalview = new System.Windows.Forms.DataGridView();
            this.deletebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.deletehospitalview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(29, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "HNO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(15, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(24, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "name";
            // 
            // hidbox
            // 
            this.hidbox.Location = new System.Drawing.Point(103, 38);
            this.hidbox.Name = "hidbox";
            this.hidbox.Size = new System.Drawing.Size(100, 25);
            this.hidbox.TabIndex = 3;
            // 
            // locationbox
            // 
            this.locationbox.Location = new System.Drawing.Point(103, 107);
            this.locationbox.Name = "locationbox";
            this.locationbox.Size = new System.Drawing.Size(100, 25);
            this.locationbox.TabIndex = 4;
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(103, 180);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(100, 25);
            this.namebox.TabIndex = 5;
            // 
            // deletehospitalview
            // 
            this.deletehospitalview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deletehospitalview.Location = new System.Drawing.Point(219, 11);
            this.deletehospitalview.Name = "deletehospitalview";
            this.deletehospitalview.RowHeadersVisible = false;
            this.deletehospitalview.RowTemplate.Height = 27;
            this.deletehospitalview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.deletehospitalview.Size = new System.Drawing.Size(477, 291);
            this.deletehospitalview.TabIndex = 6;
            this.deletehospitalview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.deletehospitalview_CellContentClick);
            // 
            // deletebutton
            // 
            this.deletebutton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.deletebutton.Location = new System.Drawing.Point(128, 238);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(75, 29);
            this.deletebutton.TabIndex = 7;
            this.deletebutton.Text = "刪除";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // DeleteHospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 314);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.deletehospitalview);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.locationbox);
            this.Controls.Add(this.hidbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DeleteHospital";
            this.Text = "DeleteHospital";
            this.Load += new System.EventHandler(this.DeleteHospital_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deletehospitalview)).EndInit();
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
        private System.Windows.Forms.DataGridView deletehospitalview;
        private System.Windows.Forms.Button deletebutton;
    }
}