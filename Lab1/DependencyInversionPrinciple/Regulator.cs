using System;
using System.Threading;

// Extract low-level abstractions from Regulator class and inverse dependency following the dependency inversion principle based on:
// https://pierresimondelaplace.gitlab.io/wsb-zaawansowane-techniki-obiektowe/WSB_ZaawansowaneTechnikiObiektowe.pdf

namespace DependencyInversionPrinciple
{
    public class Regulator
    {
		const byte THERMOMETER = 0X86;
		const byte FURNACE = 0X87;
		const byte ENGAGE = 1;
		const byte DISENGAGE = 0;

		void Regulate(double minTemp, double maxTemp)
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

        byte Read(byte register) => 0x00; //returned value not relevant.

        void Write(byte register, byte value)
		{
			//...
		}
	}
}
