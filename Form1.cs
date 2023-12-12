using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Data;


namespace HRApps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private NpgsqlConnection conn;
        string connstring = "Host=localhost; Port=5434; Username=postgres; Password=postgres; Database=HR";
        //NpgsqlConnection(ConnectionString: connstring);
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tbNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select*from st_insert(:_id_dep,_nama_dep, _id_karyawan, _nama, _id_dep";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_nama", tbNama.Text);
                cmd.Parameters.AddWithValue("_nama_dep", tbDep.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data berhasil diinputkan", "Well done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    btnLoad.PerformClick();
                    tbNama.Text = tbDep.Text = null;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0)
            {
                r = dataGridView.Rows[e.RowIndex];
                tbDep.Text = r.Cells["_nama_dep"].Value.ToString();
                tbNama.Text = r.Cells["_nama"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (r==null)
            {
                MessageBox.Show("mohon pilih baris data yang akan diupdate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                conn.Open();
                sql = @"select*from st_update(:_id_dep,_nama_dep, _id_karyawan, _nama, _id_dep";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_nama", tbNama.Text);
                cmd.Parameters.AddWithValue("_nama_dep", tbDep.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data berhasil diupdate", "Well done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    btnLoad.PerformClick();
                    tbNama.Text = tbDep.Text = null;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
    }
}
