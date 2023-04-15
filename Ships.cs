using System;


namespace BattleShip

{
	public class Ships

	{

		private int Xaxis;
		private int Yaxis;


		public Ships(int Xax, int Yax)

		{
			this.Xaxis = Xax;
			this.Yaxis = Yax; 

		}

		public int GetSizeX()

		{

			return Xaxis;

		}

        public int GetSizeY()

		{
			return Yaxis;
		}

    }

}

