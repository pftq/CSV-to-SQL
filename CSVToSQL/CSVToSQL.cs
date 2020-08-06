using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace CSVToSQL
{
    public partial class CSVToSQL : Form
    {
        private string[] files;

        public CSVToSQL()
        {
            InitializeComponent();
            ct.Text = "";
            csv.Text = Properties.Settings.Default.csv;
            server.Text = Properties.Settings.Default.server;
            db.Text = Properties.Settings.Default.db;
            table.Text = Properties.Settings.Default.table;
        }

        private void browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Multiselect = true;
            if (o.ShowDialog() == DialogResult.OK)
            {
                files = o.FileNames;
                csv.Text = files.First();
            }
            Properties.Settings.Default.Save();
        }

        private void server_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void db_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void table_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            int i = 0;
            try
            {
                using (SqlConnection con = new SqlConnection("Server=" + server.Text + ";Database=" + db.Text + ";Trusted_Connection=True;"))
                {
                    con.Open();
                    string q = "";
                    
                    foreach (string f in files)
                    {

                        csv.Text = f;
                        Application.DoEvents();
                        List<string> headers = new List<string>();
                        DataTable t = new System.Data.DataTable();
                        i=0;
                        using (StreamReader sr = new StreamReader(f))
                        {
                            
                            String line;
                            while ((line = sr.ReadLine()) != null)
                            {
                                i++;
                                ct.Text = "Row " + i;
                                if(i%100==0) Application.DoEvents();

                                string[] cells = line.Split(',').Select(x=>x.Replace("NaN", "0")).ToArray();
                                if (headers.Count == 0)
                                {
                                    foreach (string c in cells)
                                    {
                                        headers.Add(c);
                                        t.Columns.Add(c);
                                    }
                                }
                                else
                                {
                                    q = "INSERT INTO " + table.Text + " (" + string.Join(",", headers) + ") VALUES('" + string.Join("','", cells) + "')";
                                    //(new SqlCommand(q, con)).ExecuteNonQuery();
                                    t.Rows.Add(cells.ToArray<object>());
                                }
                                if (t.Rows.Count >= 100000)
                                {
                                    Application.DoEvents();
                                    using (SqlBulkCopy s = new SqlBulkCopy(con))
                                    {
                                        s.DestinationTableName = table.Text;
                                        s.BulkCopyTimeout = 3600;
                                        s.WriteToServer(t);
                                    }
                                    t.Rows.Clear();
                                }
                            }
                        }
                        if (t.Rows.Count > 0)
                        {
                            Application.DoEvents();
                            using (SqlBulkCopy s = new SqlBulkCopy(con))
                            {
                                s.DestinationTableName = table.Text;
                                s.BulkCopyTimeout = 1200;
                                s.WriteToServer(t);
                            }
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Line "+i+": "+ex.ToString());
            }
            ct.Text = "";
        }
    }
}
