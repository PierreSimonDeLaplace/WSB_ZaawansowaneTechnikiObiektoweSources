using System.Numerics;
using CommandPattern;

namespace CommandPattern
{
	public class MoveCommand : ICommand
	{
		private readonly Character objectToMove;
		private readonly Vector3 displacement;

		public MoveCommand(Character objectToMove, Vector3 displacement)
		{
			this.objectToMove = objectToMove;
			this.displacement = displacement;
		}

		public void Execute()
		{
			objectToMove.Position += displacement;
		}

		public void Undo()
        {
			//...
        }
	}
}