namespace DBMS_project
{
    partial class UpdateShelter
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
            this.updatebutton = new System.Windows.Forms.Button();
            this.updateshelterview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.updateshelterview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(39, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "SNO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(26, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(12, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "volunteer_num";
            // 
            // sidbox
            // 
            this.sidbox.Location = new System.Drawing.Point(155, 34);
            this.sidbox.Name = "sidbox";
            this.sidbox.Size = new System.Drawing.Size(100, 25);
            this.sidbox.TabIndex = 4;
            // 
            // locationbox
            // 
            this.locationbox.Location = new System.Drawing.Point(155, 110);
            this.locationbox.Name = "locationbox";
            this.locationbox.Size = new System.Drawing.Size(100, 25);
            this.locationbox.TabIndex = 5;
            // 
            // vnumbox
            // 
            this.vnumbox.Location = new System.Drawing.Point(155, 181);
            this.vnumbox.Name = "vnumbox";
            this.vnumbox.Size = new System.Drawing.Size(100, 25);
            this.vnumbox.TabIndex = 6;
            // 
            // updatebutton
            // 
            this.updatebutton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.updatebutton.Location = new System.Drawing.Point(168, 236);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(75, 29);
            this.updatebutton.TabIndex = 8;
            this.updatebutton.Text = "更新";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // updateshelterview
            // 
            this.updateshelterview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.updateshelterview.Location = new System.Drawing.Point(261, 12);
            this.updateshelterview.Name = "updateshelterview";
            this.updateshelterview.RowHeadersVisible = false;
            this.updateshelterview.RowTemplate.Height = 27;
            this.updateshelterview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.updateshelterview.Size = new System.Drawing.Size(430, 291);
            this.updateshelterview.TabIndex = 9;
            this.updateshelterview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.updateshelterview_CellContentClick);
            // 
            // UpdateShelter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 314);
            this.Controls.Add(this.updateshelterview);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.vnumbox);
            this.Controls.Add(this.locationbox);
            this.Controls.Add(this.sidbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateShelter";
            this.Text = "UpdateShelter";
            this.Load += new System.EventHandler(this.UpdateShelter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updateshelterview)).EndInit();
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
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.DataGridView updateshelterview;
    }
}