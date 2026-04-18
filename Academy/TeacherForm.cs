using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
	public partial class TeacherForm : HumanForm
	{
		// 1.որպեսզի teacher օբյեկտը հասանելի լինի
		Models.Teacher teacher;
		public TeacherForm()
		{
			InitializeComponent();
		}

		public TeacherForm(int id) : this()
		{
			DataTable table = DataBase.Connector.Load($"SELECT * FROM Teachers WHERE teacher_id={id}");
			if (table.Rows.Count > 0)
			{
				teacher = new Models.Teacher(table.Rows[0].ItemArray);
				human = teacher;
				Extract();
			}
		}

		protected override void Extract()
		{
			base.Extract();
		}

		protected override void buttonOK_Click(object sender, EventArgs e)
		{
			base.buttonOK_Click(sender, e);

			teacher.last_name = human.last_name;
			teacher.first_name = human.first_name;
			teacher.birth_date = human.birth_date;

			if (teacher.id == 0)
			{
				string sql = $"INSERT Teachers({teacher.GetNamse()}) VALUES ({teacher.GetValus()}); SELECT SCOPE_IDENTITY();";
				teacher.id = Convert.ToInt32(DataBase.Connector.Scalar(sql));
			}
			else
			{
				DataBase.Connector.Update(
					"Teachers",
					teacher.GetNamse(),
					teacher.GetValus(),
					$"teacher_id={teacher.id}"
				);
			}
		}
	}
}