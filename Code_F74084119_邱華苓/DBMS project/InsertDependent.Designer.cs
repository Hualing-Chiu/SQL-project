namespace DBMS_project
{
    partial class InsertDependent
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
            this.ssnbox = new System.Windows.Forms.TextBox();
            this.namebox = new System.Windows.Forms.TextBox();
            this.agebox = new System.Windows.Forms.TextBox();
            this.sexbox = new System.Windows.Forms.TextBox();
            this.assnbox = new System.Windows.Forms.TextBox();
            this.insertdependentview = new System.Windows.Forms.DataGridView();
            this.insertbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.insertdependentview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(35, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "SSN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(24, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(38, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(35, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "sex";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(23, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "ASSN";
            // 
            // ssnbox
            // 
            this.ssnbox.Location = new System.Drawing.Point(93, 27);
            this.ssnbox.Name = "ssnbox";
            this.ssnbox.Size = new System.Drawing.Size(100, 25);
            this.ssnbox.TabIndex = 5;
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(93, 79);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(100, 25);
            this.namebox.TabIndex = 6;
            // 
            // agebox
            // 
            this.agebox.Location = new System.Drawing.Point(93, 129);
            this.agebox.Name = "agebox";
            this.agebox.Size = new System.Drawing.Size(100, 25);
            this.agebox.TabIndex = 7;
            // 
            // sexbox
            // 
            this.sexbox.Location = new System.Drawing.Point(93, 180);
            this.sexbox.Name = "sexbox";
            this.sexbox.Size = new System.Drawing.Size(100, 25);
            this.sexbox.TabIndex = 8;
            // 
            // assnbox
            // 
            this.assnbox.Location = new System.Drawing.Point(93, 231);
            this.assnbox.Name = "assnbox";
            this.assnbox.Size = new System.Drawing.Size(100, 25);
            this.assnbox.TabIndex = 9;
            // 
            // insertdependentview
            // 
            this.insertdependentview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.insertdependentview.Location = new System.Drawing.Point(214, 12);
            this.insertdependentview.Name = "insertdependentview";
            this.insertdependentview.RowHeadersVisible = false;
            this.insertdependentview.RowTemplate.Height = 27;
            this.insertdependentview.Size = new System.Drawing.Size(477, 291);
            this.insertdependentview.TabIndex = 10;
            // 
            // insertbutton
            // 
            this.insertbutton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.insertbutton.Location = new System.Drawing.Point(120, 274);
            this.insertbutton.Name = "insertbutton";
            this.insertbutton.Size = new System.Drawing.Size(75, 29);
            this.insertbutton.TabIndex = 11;
            this.insertbutton.Text = "添加";
            this.insertbutton.UseVisualStyleBackColor = true;
            this.insertbutton.Click += new System.EventHandler(this.insertbutton_Click);
            // 
            // InsertDependent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 314);
            this.Controls.Add(this.insertbutton);
            this.Controls.Add(this.insertdependentview);
            this.Controls.Add(this.assnbox);
            this.Controls.Add(this.sexbox);
            this.Controls.Add(this.agebox);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.ssnbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InsertDependent";
            this.Text = "InsertDependent";
            this.Load += new System.EventHandler(this.InsertDependent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.insertdependentview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ssnbox;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox agebox;
        private System.Windows.Forms.TextBox sexbox;
        private System.Windows.Forms.TextBox assnbox;
        private System.Windows.Forms.DataGridView insertdependentview;
        private System.Windows.Forms.Button insertbutton;
    }
}