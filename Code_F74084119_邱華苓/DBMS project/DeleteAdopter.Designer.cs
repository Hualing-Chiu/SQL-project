namespace DBMS_project
{
    partial class DeleteAdopter
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
            this.deleteadopterview = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ssnbox = new System.Windows.Forms.TextBox();
            this.namebox = new System.Windows.Forms.TextBox();
            this.sexbox = new System.Windows.Forms.TextBox();
            this.agebox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.deleteadopterview)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteadopterview
            // 
            this.deleteadopterview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deleteadopterview.Location = new System.Drawing.Point(214, 12);
            this.deleteadopterview.Name = "deleteadopterview";
            this.deleteadopterview.RowHeadersVisible = false;
            this.deleteadopterview.RowTemplate.Height = 27;
            this.deleteadopterview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.deleteadopterview.Size = new System.Drawing.Size(477, 291);
            this.deleteadopterview.TabIndex = 0;
            this.deleteadopterview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.deleteadopterview_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(98, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "刪除";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "SSN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(23, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "sex";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(23, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "age";
            // 
            // ssnbox
            // 
            this.ssnbox.Location = new System.Drawing.Point(73, 29);
            this.ssnbox.Name = "ssnbox";
            this.ssnbox.Size = new System.Drawing.Size(100, 25);
            this.ssnbox.TabIndex = 6;
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(73, 84);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(100, 25);
            this.namebox.TabIndex = 7;
            // 
            // sexbox
            // 
            this.sexbox.Location = new System.Drawing.Point(73, 146);
            this.sexbox.Name = "sexbox";
            this.sexbox.Size = new System.Drawing.Size(100, 25);
            this.sexbox.TabIndex = 8;
            // 
            // agebox
            // 
            this.agebox.Location = new System.Drawing.Point(73, 209);
            this.agebox.Name = "agebox";
            this.agebox.Size = new System.Drawing.Size(100, 25);
            this.agebox.TabIndex = 9;
            // 
            // DeleteAdopter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 314);
            this.Controls.Add(this.agebox);
            this.Controls.Add(this.sexbox);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.ssnbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deleteadopterview);
            this.Name = "DeleteAdopter";
            this.Text = "DeleteAdopter";
            this.Load += new System.EventHandler(this.DeleteAdopter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deleteadopterview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView deleteadopterview;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ssnbox;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox sexbox;
        private System.Windows.Forms.TextBox agebox;
    }
}