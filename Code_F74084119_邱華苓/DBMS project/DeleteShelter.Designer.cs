namespace DBMS_project
{
    partial class DeleteShelter
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
            this.sidbox = new System.Windows.Forms.TextBox();
            this.locationbox = new System.Windows.Forms.TextBox();
            this.vnumbox = new System.Windows.Forms.TextBox();
            this.deletebutton = new System.Windows.Forms.Button();
            this.deleteshelterview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.deleteshelterview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(44, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "SNO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(32, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(12, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "volunteer_num";
            // 
            // sidbox
            // 
            this.sidbox.Location = new System.Drawing.Point(155, 32);
            this.sidbox.Name = "sidbox";
            this.sidbox.Size = new System.Drawing.Size(100, 25);
            this.sidbox.TabIndex = 3;
            // 
            // locationbox
            // 
            this.locationbox.Location = new System.Drawing.Point(155, 113);
            this.locationbox.Name = "locationbox";
            this.locationbox.Size = new System.Drawing.Size(100, 25);
            this.locationbox.TabIndex = 4;
            // 
            // vnumbox
            // 
            this.vnumbox.Location = new System.Drawing.Point(155, 192);
            this.vnumbox.Name = "vnumbox";
            this.vnumbox.Size = new System.Drawing.Size(100, 25);
            this.vnumbox.TabIndex = 5;
            // 
            // deletebutton
            // 
            this.deletebutton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.deletebutton.Location = new System.Drawing.Point(180, 243);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(75, 29);
            this.deletebutton.TabIndex = 6;
            this.deletebutton.Text = "刪除";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // deleteshelterview
            // 
            this.deleteshelterview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deleteshelterview.Location = new System.Drawing.Point(261, 12);
            this.deleteshelterview.Name = "deleteshelterview";
            this.deleteshelterview.RowHeadersVisible = false;
            this.deleteshelterview.RowTemplate.Height = 27;
            this.deleteshelterview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.deleteshelterview.Size = new System.Drawing.Size(430, 291);
            this.deleteshelterview.TabIndex = 7;
            this.deleteshelterview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.deleteshelterview_CellContentClick);
            // 
            // DeleteShelter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 314);
            this.Controls.Add(this.deleteshelterview);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.vnumbox);
            this.Controls.Add(this.locationbox);
            this.Controls.Add(this.sidbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DeleteShelter";
            this.Text = "DeleteShelter";
            this.Load += new System.EventHandler(this.DeleteShelter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deleteshelterview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sidbox;
        private System.Windows.Forms.TextBox locationbox;
        private System.Windows.Forms.TextBox vnumbox;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.DataGridView deleteshelterview;
    }
}