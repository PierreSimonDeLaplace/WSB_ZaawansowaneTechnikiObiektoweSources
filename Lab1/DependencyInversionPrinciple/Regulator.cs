using System;
using System.Threading;

// Extract low-level abstractions from Regulator class and inverse dependency following the dependency inversion principle based on:
// https://pierresimondelaplace.gitlab.io/wsb-zaawansowane-techniki-obiektowe/WSB_ZaawansowaneTechnikiObiektowe.pdf

namespace DependencyInversionPrinciple
{
    public class Regulator
    {
		private readonly byte THERMOMETER = 0X86;
		private readonly byte FURNACE = 0X87;
		private readonly byte ENGAGE = 1;
		private readonly byte DISENGAGE = 0;

		public void Regulate(double minTemp, double maxTemp)
		{
			for (; ; )
			{
				while (this.Read(THERMOMETER) > minTemp)
				{
					Thread.Sleep(1000);
				}
				this.Write(FURNACE, ENGAGE);
				while (this.Read(THERMOMETER) < maxTemp)
				{
					Thread.Sleep(1000);
				}
				this.Write(FURNACE, DISENGAGE);
			}
		}

		byte Read(byte register)
		{
            Console.WriteLine("Sensor reading...");
			return 0x00; //returned value not relevant.
		}
        void Write(byte register, byte value)
		{
            Console.WriteLine("Register value writing...");
		}
	}
}
