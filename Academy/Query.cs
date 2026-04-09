using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class Query
	{
		public string Fields { get; set;}
		public string Tables{ get; set; }
		public string Condition { get; set; }
		public Query (string  fislds, string tables, string condition = "")
		{
			this.Fields = fislds;
			this.Tables = tables;
			this.Condition = condition;
		}
		public override string ToString()
		{
			string cmd = $"SELECT {Fields} FROM {Tables}";
			if (Condition != "") cmd += $" WHERE {Condition}";
			return cmd;
		}

	}
}
