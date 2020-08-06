namespace CSVToSQL
{
    partial class CSVToSQL
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
            this.browse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.TextBox();
            this.db = new System.Windows.Forms.TextBox();
            this.server = new System.Windows.Forms.TextBox();
            this.csv = new System.Windows.Forms.TextBox();
            this.ct = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CSV(s): ";
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(222, 5);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(75, 23);
            this.browse.TabIndex = 2;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Server:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "DB:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Table:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // table
            // 
            this.table.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::CSVToSQL.Properties.Settings.Default, "table", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.table.Location = new System.Drawing.Point(59, 85);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(238, 20);
            this.table.TabIndex = 7;
            this.table.Text = global::CSVToSQL.Properties.Settings.Default.table;
            this.table.TextChanged += new System.EventHandler(this.table_TextChanged);
            // 
            // db
            // 
            this.db.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::CSVToSQL.Properties.Settings.Default, "db", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.db.Location = new System.Drawing.Point(59, 59);
            this.db.Name = "db";
            this.db.Size = new System.Drawing.Size(238, 20);
            this.db.TabIndex = 5;
            this.db.Text = global::CSVToSQL.Properties.Settings.Default.db;
            this.db.TextChanged += new System.EventHandler(this.db_TextChanged);
            // 
            // server
            // 
            this.server.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::CSVToSQL.Properties.Settings.Default, "server", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.server.Location = new System.Drawing.Point(59, 33);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(238, 20);
            this.server.TabIndex = 3;
            this.server.Text = global::CSVToSQL.Properties.Settings.Default.server;
            this.server.TextChanged += new System.EventHandler(this.server_TextChanged);
            // 
            // csv
            // 
            this.csv.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::CSVToSQL.Properties.Settings.Default, "csv", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.csv.Location = new System.Drawing.Point(59, 7);
            this.csv.Name = "csv";
            this.csv.ReadOnly = true;
            this.csv.Size = new System.Drawing.Size(157, 20);
            this.csv.TabIndex = 0;
            this.csv.Text = global::CSVToSQL.Properties.Settings.Default.csv;
            // 
            // ct
            // 
            this.ct.AutoSize = true;
            this.ct.Location = new System.Drawing.Point(228, 116);
            this.ct.Name = "ct";
            this.ct.Size = new System.Drawing.Size(69, 13);
            this.ct.TabIndex = 10;
            this.ct.Text = "File a, Row b";
            // 
            // CSVToSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 146);
            this.Controls.Add(this.ct);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.table);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.db);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.server);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.csv);
            this.MaximumSize = new System.Drawing.Size(325, 184);
            this.MinimumSize = new System.Drawing.Size(325, 184);
            this.Name = "CSVToSQL";
            this.Text = "CSVToSQL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox csv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox server;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox db;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox table;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ct;
    }
}