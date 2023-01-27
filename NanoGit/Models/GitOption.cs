using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NanoGit.Models
{
	class GitOption
	{
		private string Command { get; }
		private string Shortcut { get; }
		private string Example { get; }
		private string Description { get; }

		public GitOption(string command, string shortcut, string example, string description)
		{
			Command = command;
			Shortcut = shortcut;
			Example = example;
			Description = description;
		}
	}
}
