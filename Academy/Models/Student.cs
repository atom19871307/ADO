using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Academy.Models
{
	internal class Student :Human
	{
		internal int group;
		public Student
			(
			int id,
			string last_name, string first_name, string middle_name, string birth_date,
			string email, string phone, Image photo,
			int group
			): base(id,last_name, first_name, middle_name, birth_date, email, phone,photo)
		{
			this.group = group;
		}
		public Student(Human human,int group ): base(human)
		{
			this.group = group;
		}
		public Student(object[] values) : base(values)
		{
			group = Convert.ToInt32(values[8]);
		}

		public override string GetNamse()
		{
			return base.GetNamse()+",[group]";
		}
		public override string GetValus()
		{
			return base.GetValus()+$",{group}";
		}
		public override string GetUpdateString()
		{
			return base.GetUpdateString()+$",[group]={group}";
		}
	}
}
