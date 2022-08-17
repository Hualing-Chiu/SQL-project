namespace DBMS_project
{
    partial class InsertDog
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
            this.button1 = new System.Windows.Forms.Button();
            this.insertdogview = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.hidbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.insertdogview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "DID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(21, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "sex";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(16, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "SNO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(12, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "ASSN";
            // 
            // didbox
            // 
            this.didbox.Location = new System.Drawing.Point(78, 14);
            this.didbox.Name = "didbox";
            this.didbox.Size = new System.Drawing.Size(100, 25);
            this.didbox.TabIndex = 5;
            // 
            // typebox
            // 
            this.typebox.Location = new System.Drawing.Point(78, 57);
            this.typebox.Name = "typebox";
            this.typebox.Size = new System.Drawing.Size(100, 25);
            this.typebox.TabIndex = 6;
            // 
            // sexbox
            // 
            this.sexbox.Location = new System.Drawing.Point(78, 102);
            this.sexbox.Name = "sexbox";
            this.sexbox.Size = new System.Drawing.Size(100, 25);
            this.sexbox.TabIndex = 7;
            // 
            // sidbox
            // 
            this.sidbox.Location = new System.Drawing.Point(78, 151);
            this.sidbox.Name = "sidbox";
            this.sidbox.Size = new System.Drawing.Size(100, 25);
            this.sidbox.TabIndex = 8;
            // 
            // assnbox
            // 
            this.assnbox.Location = new System.Drawing.Point(78, 196);
            this.assnbox.Name = "assnbox";
            this.assnbox.Size = new System.Drawing.Size(100, 25);
            this.assnbox.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(103, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // insertdogview
            // 
            this.insertdogview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.insertdogview.Location = new System.Drawing.Point(214, 12);
            this.insertdogview.Name = "insertdogview";
            this.insertdogview.RowHeadersVisible = false;
            this.insertdogview.RowTemplate.Height = 27;
            this.insertdogview.Size = new System.Drawing.Size(477, 291);
            this.insertdogview.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(16, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "HNO";
            // 
            // hidbox
            // 
            this.hidbox.Location = new System.Drawing.Point(78, 238);
            this.hidbox.Name = "hidbox";
            this.hidbox.Size = new System.Drawing.Size(100, 25);
            this.hidbox.TabIndex = 13;
            // 
            // InsertDog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 314);
            this.Controls.Add(this.hidbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.insertdogview);
            this.Controls.Add(this.button1);
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
            this.Name = "InsertDog";
            this.Text = "InsertDog";
            this.Load += new System.EventHandler(this.InsertDog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.insertdogview)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView insertdogview;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox hidbox;
    }
}