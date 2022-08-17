namespace DBMS_project
{
    partial class Mysqlform
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
            this.querytextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.querybutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // querytextbox
            // 
            this.querytextbox.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.querytextbox.Location = new System.Drawing.Point(16, 55);
            this.querytextbox.Multiline = true;
            this.querytextbox.Name = "querytextbox";
            this.querytextbox.Size = new System.Drawing.Size(476, 216);
            this.querytextbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "輸入SQL指令";
            // 
            // querybutton
            // 
            this.querybutton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.querybutton.Location = new System.Drawing.Point(402, 277);
            this.querybutton.Name = "querybutton";
            this.querybutton.Size = new System.Drawing.Size(90, 33);
            this.querybutton.TabIndex = 2;
            this.querybutton.Text = "查詢";
            this.querybutton.UseVisualStyleBackColor = true;
            this.querybutton.Click += new System.EventHandler(this.querybutton_Click);
            // 
            // Mysqlform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 322);
            this.Controls.Add(this.querybutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.querytextbox);
            this.Name = "Mysqlform";
            this.Text = "Mysql";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox querytextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button querybutton;
    }
}