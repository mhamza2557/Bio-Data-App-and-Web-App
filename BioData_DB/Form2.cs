using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BioData_DB
{
	public partial class Form2 : Form
	{
		SqlCommand cmd;
		SqlConnection con;

		public Form2()
		{
			InitializeComponent();
			Class1.Height(comboBox1);
			Class1.BloodGroup(comboBox2);
			Class1.City(comboBox3);
			Class1.Qualification(comboBox4);

			textBox3.Enabled = false;
		}


		private void Button1_Click(object sender, EventArgs e)
		{
			if (Class1.isValid(textBox1, dateTimePicker1, comboBox1, comboBox2, comboBox4, comboBox3, textBox2, radioButton1, radioButton2))
			{
				String name = textBox1.Text;

				String getDate = dateTimePicker1.Value.Day.ToString() + "/" + dateTimePicker1.Value.Month.ToString() + "/" + dateTimePicker1.Value.Year.ToString();
				DateTime dob = DateTime.Parse(getDate);
				DateTime getOnlyDate = dob.Date;
				String a = getOnlyDate.Date.ToString("yyyy-MM-dd HH:mm:ss");

				String height = comboBox1.SelectedItem.ToString();
				String bloodGroup = comboBox2.SelectedItem.ToString();
				String qualification = comboBox4.SelectedItem.ToString();
				String city = comboBox3.SelectedItem.ToString();
				String postralcode = textBox2.Text;
				String gender = "Unknown";
				if (radioButton1.Checked) { gender = "Male"; }
				else if (radioButton2.Checked) { gender = "Female"; }

				con = new SqlConnection(Class1.ConnectionString());
				con.Open();
				cmd = new SqlCommand("UPDATE BioData_Table SET name='" + name + "',dob='" + a + "',height='" + height + "',bloodgroup='" + bloodGroup + "',qualification='" + qualification + "',city='" + city + "',postralcode='" + postralcode + "',gender='" + gender + "' WHERE id = '" + int.Parse(textBox3.Text) + "'", con);
				cmd.ExecuteNonQuery();
				con.Close();
				DialogResult result = MessageBox.Show("Database Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
				if (result == DialogResult.OK)
				{
					this.Close();
				}
			}
		}
	}
}
