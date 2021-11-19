using System;
using System.Numerics;

namespace CommandPattern
{
    public class Character
    {
		public Vector3 Position { get; set; }
		private readonly MoveCommandHandler commands = new MoveCommandHandler();

		public void Move(ICommand command)
		{
			commands.Handle(command);
		}

		public void ComeBack()
		{
			//...
		}

		public void MoveAgain()
		{
			//...
		}

		public override string ToString() => $"Current position: {this.Position}";
	}
}