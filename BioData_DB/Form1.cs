using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BioData_DB
{
	public partial class Form1 : Form
	{
		SqlCommand cmd;
		SqlConnection con;
		SqlDataAdapter da;

		public Form1()
		{
			InitializeComponent();
			textBox3.Enabled = false;
			Class1.Height(comboBox1);
			Class1.BloodGroup(comboBox2);
			Class1.City(comboBox3);
			Class1.Qualification(comboBox4);

			con = new SqlConnection(Class1.ConnectionString());
			con.Open();

			da = new SqlDataAdapter("SELECT * FROM BioData_Table", con);
			DataTable dt = new DataTable();

			dt.Columns.Add("ID", typeof(int));
			dt.Columns.Add("Name", typeof(String));
			dt.Columns.Add("DOB", typeof(DateTime));
			dt.Columns.Add("Height", typeof(String));
			dt.Columns.Add("BloodGroup", typeof(String));
			dt.Columns.Add("Qualification", typeof(String));
			dt.Columns.Add("City", typeof(String));
			dt.Columns.Add("PostralCode", typeof(int));
			dt.Columns.Add("Gender", typeof(String));
			
			da.Fill(dt);
			dataGridView1.DataSource = dt;
			dataGridView1.MultiSelect = false;
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

			da = new SqlDataAdapter("SELECT ISNULL(MAX(CAST(id AS INT)),0) + 1 FROM BioData_Table", con);
			DataTable dta = new DataTable();
			da.Fill(dta);
			textBox3.Text = dta.Rows[0][0].ToString();

			con.Close();
		}

		private bool isValid()
		{
			if (textBox1.Text.Trim() == string.Empty)
			{
				MessageBox.Show("Name is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
				textBox1.Focus();
				return false;
			}

			DateTime currentDate = DateTime.Now;
			var getDate = dateTimePicker1.Value.Day.ToString() + "/" + dateTimePicker1.Value.Month.ToString() + "/" + dateTimePicker1.Value.Year.ToString();
			DateTime dob = DateTime.Parse(getDate);
			DateTime getOnlyDate = dob.Date;

			int value = DateTime.Compare(currentDate, getOnlyDate);
			var a = (currentDate - getOnlyDate).Days;
			
			if (a < 10) 
			{
				MessageBox.Show("Birthdate is less current date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
				dateTimePicker1.Focus();
				return false;
			}

			if (comboBox1.SelectedItem == null)
			{
				MessageBox.Show("Height is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
				comboBox1.Focus();
				return false;
			}

			if (comboBox2.SelectedItem == null)
			{
				MessageBox.Show("Bloodgroup is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
				comboBox2.Focus();
				return false;
			}

			if (comboBox4.SelectedItem == null)
			{
				MessageBox.Show("Qualification is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
				comboBox4.Focus();
				return false;
			}

			if (comboBox3.SelectedItem == null)
			{
				MessageBox.Show("City is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
				comboBox4.Focus();
				return false;
			}

			if (textBox2.Text == "")
			{
				MessageBox.Show("Postral Code is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
				textBox2.Focus();
				return false;
			}

			if (!(radioButton1.Checked || radioButton2.Checked))
			{
				MessageBox.Show("Gender is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			return true;
		}

		[Obsolete]
		private void Button1_Click(object sender, EventArgs e)
		{
			if (Class1.isValid(textBox1, dateTimePicker1, comboBox1, comboBox2, comboBox4, comboBox3, textBox2, radioButton1, radioButton2))
			{
				con = new SqlConnection(Class1.ConnectionString());
				con.Open();
				cmd = new SqlCommand("INSERT INTO BioData_Table (id,name,dob,height,bloodgroup,qualification,city,postralcode,gender) VALUES (@id,@name,@dob,@height,@bloodgroup,@qualification,@city,@postralcode,@gender)", con);

				String id = textBox3.Text;
				String name = textBox1.Text;

				var getDate = dateTimePicker1.Value.Day.ToString() + "/" + dateTimePicker1.Value.Month.ToString() + "/" + dateTimePicker1.Value.Year.ToString();
				DateTime dob = DateTime.Parse(getDate);
				DateTime getOnlyDate = dob.Date;
				
				String height = comboBox1.SelectedItem.ToString();
				String bloodGroup = comboBox2.SelectedItem.ToString();
				String qualification = comboBox4.SelectedItem.ToString();
				String city = comboBox3.SelectedItem.ToString();
				String postralcode = textBox2.Text;
				String gender = null;
				if (radioButton1.Checked) { gender = "Male"; }
				else if (radioButton2.Checked) { gender = "Female"; }

				cmd.Parameters.Add("@id",id);
				cmd.Parameters.Add("@name", name);
				cmd.Parameters.Add("@dob", getOnlyDate);
				cmd.Parameters.Add("@height", height);
				cmd.Parameters.Add("@bloodgroup", bloodGroup);
				cmd.Parameters.Add("@qualification", qualification);
				cmd.Parameters.Add("@city", city);
				cmd.Parameters.Add("@postralcode", postralcode);
				cmd.Parameters.Add("@gender", gender);
				cmd.ExecuteNonQuery();

				da = new SqlDataAdapter("SELECT * FROM BioData_Table", con);
				DataTable dt = new DataTable();
				da.Fill(dt);
				dataGridView1.DataSource = dt;

				textBox1.Text = "";
				dateTimePicker1.Value = DateTime.Now;

				comboBox1.SelectedItem = null;
				comboBox2.SelectedItem = null;
				comboBox4.SelectedItem = null;
				comboBox3.SelectedItem = null;
				textBox2.Text = "";

				radioButton1.Checked = false;
				radioButton2.Checked = false;

				da = new SqlDataAdapter("SELECT ISNULL(MAX(CAST(id AS INT)),0) + 1 FROM BioData_Table", con);
				DataTable dta = new DataTable();
				da.Fill(dta);
				textBox3.Text = dta.Rows[0][0].ToString();
				con.Close();
			}
		}

		private void ToolStripTextBox1_TextChanged(object sender, EventArgs e)
		{
			con = new SqlConnection(Class1.ConnectionString());
			con.Open();
			cmd = new SqlCommand("SELECT * FROM BioData_Table WHERE (name LIKE '%" + toolStripTextBox1.Text + "%')", con);
			da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dataGridView1.DataSource = dt;
			con.Close();
		}

		private void ToolStripButton3_Click(object sender, EventArgs e)
		{
			tabControl1.SelectedTab = tabPage1;
		}

		private void ToolStripButton1_Click(object sender, EventArgs e)
		{
			int rowIndex = dataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected);
			Console.WriteLine(rowIndex);
			SqlDataReader dataReader;
			try
			{
				if (rowIndex != -1)
				{
					int id = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["id"].Value);
					string query = "DELETE FROM BioData_Table WHERE id='" + id + "';";
					con = new SqlConnection(Class1.ConnectionString());
					cmd = new SqlCommand(query, con);
					con.Open();
					dataReader = cmd.ExecuteReader();
					MessageBox.Show("Row Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
					while (dataReader.Read()) { }
					con.Close();

					con = new SqlConnection(Class1.ConnectionString());
					con.Open();
					da = new SqlDataAdapter("SELECT * FROM BioData_Table", con);
					DataTable dt = new DataTable();
					da.Fill(dt);
					dataGridView1.DataSource = dt;
					dataGridView1.MultiSelect = false;
					dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
					dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
					con.Close();
				}
				else
				{
					MessageBox.Show("Please Select Row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Console.WriteLine(ex.Message);
			}
		}

		private void ToolStripButton2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ToolStripButton4_Click(object sender, EventArgs e)
		{
			Form2 form2 = new Form2();
			form2.textBox3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
			form2.textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
			form2.dateTimePicker1.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());

			
			form2.comboBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
			form2.comboBox2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
			form2.comboBox4.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
			form2.comboBox3.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
			form2.textBox2.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
			if (dataGridView1.CurrentRow.Cells[8].Value.ToString() == "Male")
			{
				form2.radioButton1.Checked = true;
			}
			else
			{
				form2.radioButton2.Checked = true;
			}

			form2.ShowDialog();
		}

		private void ToolStripButton5_Click(object sender, EventArgs e)
		{
			con = new SqlConnection(Class1.ConnectionString());
			con.Open();
			da = new SqlDataAdapter("SELECT * FROM BioData_Table", con);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dataGridView1.DataSource = dt;
			con.Close();
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			da = new SqlDataAdapter("SELECT ISNULL(MAX(CAST(id AS INT)),0) + 1 FROM BioData_Table", con);
			DataTable dta = new DataTable();
			da.Fill(dta);
			textBox3.Text = dta.Rows[0][0].ToString();
		}

		private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
		{
			Char chr = e.KeyChar;
			if (!Char.IsDigit(chr) && chr != 8)
			{
				e.Handled = true;
				MessageBox.Show("Enter only numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			Char chr = e.KeyChar;
			if (!(Char.IsLetter(chr)) && chr != 8 && !(Char.IsWhiteSpace(chr)))
			{
				e.Handled = true;
				MessageBox.Show("Enter only characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}