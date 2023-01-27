using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace NanoGit.Models
{
	class Config
	{
		private string DatabaseLocation { get; set; }
		private string Language { get; set; }
		private Color PrimaryColor { get; }
		//private LightMode lightMode { get; }
	}
}
