namespace DBMS_project
{
    partial class InsertShelter
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
            this.insertshelterview = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.insertshelterview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(35, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "SNO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(21, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(12, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "volunteer_num";
            // 
            // sidbox
            // 
            this.sidbox.Location = new System.Drawing.Point(155, 38);
            this.sidbox.Name = "sidbox";
            this.sidbox.Size = new System.Drawing.Size(100, 25);
            this.sidbox.TabIndex = 3;
            // 
            // locationbox
            // 
            this.locationbox.Location = new System.Drawing.Point(155, 112);
            this.locationbox.Name = "locationbox";
            this.locationbox.Size = new System.Drawing.Size(100, 25);
            this.locationbox.TabIndex = 4;
            // 
            // vnumbox
            // 
            this.vnumbox.Location = new System.Drawing.Point(155, 190);
            this.vnumbox.Name = "vnumbox";
            this.vnumbox.Size = new System.Drawing.Size(100, 25);
            this.vnumbox.TabIndex = 5;
            // 
            // insertshelterview
            // 
            this.insertshelterview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.insertshelterview.Location = new System.Drawing.Point(261, 11);
            this.insertshelterview.Name = "insertshelterview";
            this.insertshelterview.RowHeadersVisible = false;
            this.insertshelterview.RowTemplate.Height = 27;
            this.insertshelterview.Size = new System.Drawing.Size(430, 291);
            this.insertshelterview.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(180, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InsertShelter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 314);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.insertshelterview);
            this.Controls.Add(this.vnumbox);
            this.Controls.Add(this.locationbox);
            this.Controls.Add(this.sidbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InsertShelter";
            this.Text = "InsertShelter";
            this.Load += new System.EventHandler(this.InsertShelter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.insertshelterview)).EndInit();
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
        private System.Windows.Forms.DataGridView insertshelterview;
        private System.Windows.Forms.Button button1;
    }
}