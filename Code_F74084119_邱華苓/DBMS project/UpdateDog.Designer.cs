namespace DBMS_project
{
    partial class UpdateDog
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.didbox = new System.Windows.Forms.TextBox();
            this.typebox = new System.Windows.Forms.TextBox();
            this.sexbox = new System.Windows.Forms.TextBox();
            this.sidbox = new System.Windows.Forms.TextBox();
            this.assnbox = new System.Windows.Forms.TextBox();
            this.updatebutton = new System.Windows.Forms.Button();
            this.updatedogview = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.hidbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.updatedogview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(29, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "DID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(24, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(29, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "sex";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(23, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "SNO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(14, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "ASSN";
            // 
            // didbox
            // 
            this.didbox.Location = new System.Drawing.Point(85, 14);
            this.didbox.Name = "didbox";
            this.didbox.Size = new System.Drawing.Size(100, 25);
            this.didbox.TabIndex = 6;
            // 
            // typebox
            // 
            this.typebox.Location = new System.Drawing.Point(85, 55);
            this.typebox.Name = "typebox";
            this.typebox.Size = new System.Drawing.Size(100, 25);
            this.typebox.TabIndex = 7;
            // 
            // sexbox
            // 
            this.sexbox.Location = new System.Drawing.Point(85, 101);
            this.sexbox.Name = "sexbox";
            this.sexbox.Size = new System.Drawing.Size(100, 25);
            this.sexbox.TabIndex = 8;
            // 
            // sidbox
            // 
            this.sidbox.Location = new System.Drawing.Point(85, 145);
            this.sidbox.Name = "sidbox";
            this.sidbox.Size = new System.Drawing.Size(100, 25);
            this.sidbox.TabIndex = 9;
            // 
            // assnbox
            // 
            this.assnbox.Location = new System.Drawing.Point(85, 190);
            this.assnbox.Name = "assnbox";
            this.assnbox.Size = new System.Drawing.Size(100, 25);
            this.assnbox.TabIndex = 10;
            // 
            // updatebutton
            // 
            this.updatebutton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.updatebutton.Location = new System.Drawing.Point(110, 273);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(75, 29);
            this.updatebutton.TabIndex = 11;
            this.updatebutton.Text = "更新";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // updatedogview
            // 
            this.updatedogview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.updatedogview.Location = new System.Drawing.Point(214, 12);
            this.updatedogview.Name = "updatedogview";
            this.updatedogview.RowHeadersVisible = false;
            this.updatedogview.RowTemplate.Height = 27;
            this.updatedogview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.updatedogview.Size = new System.Drawing.Size(477, 291);
            this.updatedogview.TabIndex = 12;
            this.updatedogview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.updatedogview_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(20, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "HNO";
            // 
            // hidbox
            // 
            this.hidbox.Location = new System.Drawing.Point(85, 233);
            this.hidbox.Name = "hidbox";
            this.hidbox.Size = new System.Drawing.Size(100, 25);
            this.hidbox.TabIndex = 14;
            // 
            // UpdateDog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 314);
            this.Controls.Add(this.hidbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.updatedogview);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.assnbox);
            this.Controls.Add(this.sidbox);
            this.Controls.Add(this.sexbox);
            this.Controls.Add(this.typebox);
            this.Controls.Add(this.didbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateDog";
            this.Text = "UpdateDog";
            this.Load += new System.EventHandler(this.UpdateDog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updatedogview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox didbox;
        private System.Windows.Forms.TextBox typebox;
        private System.Windows.Forms.TextBox sexbox;
        private System.Windows.Forms.TextBox sidbox;
        private System.Windows.Forms.TextBox assnbox;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.DataGridView updatedogview;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox hidbox;
    }
}