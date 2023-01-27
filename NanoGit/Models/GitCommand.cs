using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NanoGit.Models
{
	class GitCommand
	{
		private string Name { get; }
		private string Command { get; }
		private string Synopsis { get; }
		private string Description { get; }
		private List<string> Examples { get; }
		private List<GitCommand> SubCommands { get; }
		private List<GitOption> Options { get; }
		private GitCommand Parent { get; }

		public GitCommand(
			string name,
			string command,
			string synopsis,
			string description,
			List<string> examples,
			List<GitCommand> subCommands,
			List<GitOption> options,
			GitCommand parent)
		{
			Name = name;
			Command = command;
			Synopsis = synopsis;
			Description = description;
			Examples = examples;
			SubCommands = subCommands;
			Options = options;
			Parent = parent;
		}
	}
}
