namespace DBMS_project
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.querybutton2 = new System.Windows.Forms.Button();
            this.mysqlbutton = new System.Windows.Forms.Button();
            this.resultbox = new System.Windows.Forms.DataGridView();
            this.selectbox = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.frombox = new System.Windows.Forms.CheckedListBox();
            this.wheretextbox = new System.Windows.Forms.RichTextBox();
            this.querytoolbox = new System.Windows.Forms.ComboBox();
            this.tablecombobox = new System.Windows.Forms.ComboBox();
            this.insertbutton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.resultbox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "資料庫系統\r\nF74084119";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(406, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "結果";
            // 
            // querybutton2
            // 
            this.querybutton2.Location = new System.Drawing.Point(647, 236);
            this.querybutton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.querybutton2.Name = "querybutton2";
            this.querybutton2.Size = new System.Drawing.Size(92, 33);
            this.querybutton2.TabIndex = 3;
            this.querybutton2.Text = "查詢";
            this.querybutton2.UseVisualStyleBackColor = true;
            this.querybutton2.Click += new System.EventHandler(this.querybutton2_Click);
            // 
            // mysqlbutton
            // 
            this.mysqlbutton.Location = new System.Drawing.Point(6, 314);
            this.mysqlbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mysqlbutton.Name = "mysqlbutton";
            this.mysqlbutton.Size = new System.Drawing.Size(125, 32);
            this.mysqlbutton.TabIndex = 4;
            this.mysqlbutton.Text = "Mysql";
            this.mysqlbutton.UseVisualStyleBackColor = true;
            this.mysqlbutton.Click += new System.EventHandler(this.mysqlbutton_Click);
            // 
            // resultbox
            // 
            this.resultbox.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.resultbox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultbox.Location = new System.Drawing.Point(143, 314);
            this.resultbox.Name = "resultbox";
            this.resultbox.RowHeadersVisible = false;
            this.resultbox.RowTemplate.Height = 27;
            this.resultbox.Size = new System.Drawing.Size(596, 248);
            this.resultbox.TabIndex = 5;
            // 
            // selectbox
            // 
            this.selectbox.FormattingEnabled = true;
            this.selectbox.Items.AddRange(new object[] {
            "ADOPTER.SSN",
            "ADOPTER.name",
            "ADOPTER.sex",
            "ADOPTER.age",
            "DOG.DID",
            "DOG.type",
            "DOG.sex",
            "DOG.SNO",
            "DOG.ASSN",
            "DOG.HNO",
            "SHELTER.SNO",
            "SHELTER.location",
            "SHELTER.volunteer_num",
            "HOSPITAL.HNO",
            "HOSPITAL.location",
            "HOSPITAL.name",
            "DEPENDENT.SSN",
            "DEPENDENT.name",
            "DEPENDENT.age",
            "DEPENDENT.sex",
            "DEPENDENT.ASSN",
            "COUNT(*)",
            "SUM(ADOPTER.age)",
            "SUM(DEPENDENT.age)",
            "SUM(SHELTER.volunteer_num)",
            "MAX(ADOPTER.age)",
            "MAX(DEPENDENT.age)",
            "MAX(SHELTER.volunteer_num)",
            "MIN(ADOPTER.age)",
            "MIN(DEPENDENT.age)",
            "MIN(SHELTER.volunteer_num)",
            "AVG(ADOPTER.age)",
            "AVG(DEPENDENT.age)",
            "AVG(SHELTER.volunteer_num)"});
            this.selectbox.Location = new System.Drawing.Point(143, 115);
            this.selectbox.Name = "selectbox";
            this.selectbox.ScrollAlwaysVisible = true;
            this.selectbox.Size = new System.Drawing.Size(174, 158);
            this.selectbox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(184, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "SELECT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(353, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "FROM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(511, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "WHERE";
            // 
            // frombox
            // 
            this.frombox.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.frombox.FormattingEnabled = true;
            this.frombox.Items.AddRange(new object[] {
            "ADOPTER",
            "DOG",
            "SHELTER",
            "HOSPITAL",
            "DEPENDENT"});
            this.frombox.Location = new System.Drawing.Point(323, 115);
            this.frombox.Name = "frombox";
            this.frombox.Size = new System.Drawing.Size(135, 154);
            this.frombox.TabIndex = 10;
            // 
            // wheretextbox
            // 
            this.wheretextbox.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.wheretextbox.Location = new System.Drawing.Point(469, 111);
            this.wheretextbox.Name = "wheretextbox";
            this.wheretextbox.Size = new System.Drawing.Size(172, 158);
            this.wheretextbox.TabIndex = 11;
            this.wheretextbox.Text = "";
            // 
            // querytoolbox
            // 
            this.querytoolbox.FormattingEnabled = true;
            this.querytoolbox.Items.AddRange(new object[] {
            "SELECT-FROM-WHERE",
            "IN",
            "NOT IN",
            "EXISTS",
            "NOT EXISTS"});
            this.querytoolbox.Location = new System.Drawing.Point(156, 47);
            this.querytoolbox.Name = "querytoolbox";
            this.querytoolbox.Size = new System.Drawing.Size(475, 27);
            this.querytoolbox.TabIndex = 12;
            // 
            // tablecombobox
            // 
            this.tablecombobox.FormattingEnabled = true;
            this.tablecombobox.Items.AddRange(new object[] {
            "ADOPTER",
            "DOG",
            "SHELTER",
            "HOSPITAL",
            "DEPENDENT"});
            this.tablecombobox.Location = new System.Drawing.Point(6, 101);
            this.tablecombobox.Name = "tablecombobox";
            this.tablecombobox.Size = new System.Drawing.Size(125, 27);
            this.tablecombobox.TabIndex = 13;
            // 
            // insertbutton
            // 
            this.insertbutton.Location = new System.Drawing.Point(6, 145);
            this.insertbutton.Name = "insertbutton";
            this.insertbutton.Size = new System.Drawing.Size(125, 29);
            this.insertbutton.TabIndex = 14;
            this.insertbutton.Text = "Insert";
            this.insertbutton.UseVisualStyleBackColor = true;
            this.insertbutton.Click += new System.EventHandler(this.insertbutton_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.Location = new System.Drawing.Point(6, 244);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(125, 29);
            this.updatebutton.TabIndex = 15;
            this.updatebutton.Text = "Update";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(6, 192);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(125, 29);
            this.deletebutton.TabIndex = 16;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(316, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "SQL Function";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(33, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Table";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 574);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.insertbutton);
            this.Controls.Add(this.tablecombobox);
            this.Controls.Add(this.querytoolbox);
            this.Controls.Add(this.wheretextbox);
            this.Controls.Add(this.frombox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectbox);
            this.Controls.Add(this.resultbox);
            this.Controls.Add(this.mysqlbutton);
            this.Controls.Add(this.querybutton2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.resultbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button querybutton2;
        private System.Windows.Forms.Button mysqlbutton;
        private System.Windows.Forms.DataGridView resultbox;
        private System.Windows.Forms.CheckedListBox selectbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox frombox;
        private System.Windows.Forms.RichTextBox wheretextbox;
        private System.Windows.Forms.ComboBox querytoolbox;
        private System.Windows.Forms.ComboBox tablecombobox;
        private System.Windows.Forms.Button insertbutton;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

