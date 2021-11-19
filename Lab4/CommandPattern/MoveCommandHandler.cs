using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
	public class MoveCommandHandler
	{
		private readonly Stack<ICommand> commands = new Stack<ICommand>();
		private readonly Stack<ICommand> redos = new Stack<ICommand>();

		public void Handle(ICommand command)
		{
			//clear the redos container
			//push the command to the commands container
			//execute the command
		}

		public void Undo()
		{
			if (commands.Any())
			{
				redos.Push(commands.Peek());
				commands.Pop().Undo();
			}
		}

		public void Redo()
		{
			//as in the preceding example
		}
	}
}
