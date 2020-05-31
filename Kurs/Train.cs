using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kurs
{
	public struct time
	{
		public string hour;
		public string min;
	};
	public struct train
	{
		public string station;
		public int number;
		public time arrival;
		public time departure;
		public int price;
	};
	public class Train
    {
		Random r;
		public train trains = new train();
		public Train(int seed) 
		{
			 r = new Random(seed++);
		}
		public Train() {}
		public string SetStation()
		{
			int a = r.Next(0, 5);
			switch (a)
			{
				case 0:
					{
						trains.station = "Киев";
						break;
					}
				case 1:
					{
						trains.station = "Варшава";
						break;
					}
				case 2:
					{
						trains.station = "Раздельная";
						break;
					}
				case 3:
					{
						trains.station = "Львов";
						break;
					}
				case 4:
					{
						trains.station = "Полтава";
						break;
					}
				case 5:
					{
						trains.station = "Минск";
						break;
					}
			}
			return trains.station;
		}
		public int SetNumber()
		{
			return trains.number = r.Next(1,100);
		}
		public string SetArivalTime()
		{
			trains.arrival.min = r.Next(0, 60).ToString();
			trains.arrival.hour = r.Next(0, 24).ToString();

			if (Convert.ToInt32(trains.arrival.min) < 10) 
			{
				trains.arrival.min = "0" + trains.arrival.min;
			}
			if (Convert.ToInt32(trains.arrival.hour) < 10)
			{
				trains.arrival.hour = "0" + trains.arrival.hour;
			}
			return trains.arrival.hour + ":" + trains.arrival.min;
		}
		public string SetDepartureTime()
		{
			trains.departure.min = r.Next(0, 60).ToString();
			trains.departure.hour = r.Next(0, 24).ToString();

			if (Convert.ToInt32(trains.departure.min) < 10)
			{
				trains.departure.min = "0" + trains.departure.min;
			}
			if (Convert.ToInt32(trains.departure.hour) < 10)
			{
				trains.departure.hour = "0" + trains.departure.hour;
			}

			return trains.departure.hour + ":" + trains.departure.min;
		}
		public int SetPrice()
		{
			return trains.price = r.Next(100, 500);
		}
		//public int SetListNumber()
		//{
		//	++trains.listnumber;
		//	return trains.listnumber;
		//}
		public void SetTrainInfo()
		{
			SetStation();
			SetNumber();
			SetArivalTime();
			SetDepartureTime();
			SetPrice();
		}
		public void Write(BinaryWriter bw)
		{
			bw.Write(trains.station);
			bw.Write(trains.number);
			bw.Write(trains.arrival.hour);
			bw.Write(trains.arrival.min);
			bw.Write(trains.departure.hour);
			bw.Write(trains.departure.min);
			bw.Write(trains.price);
		}
		public Train Read(BinaryReader br)
		{
			Train temp = new Train();

			temp.trains.station = br.ReadString();
			temp.trains.number = br.ReadInt32();
			temp.trains.arrival.hour = br.ReadString();
			temp.trains.arrival.min = br.ReadString();
			temp.trains.departure.hour = br.ReadString();
			temp.trains.departure.min = br.ReadString();
			temp.trains.price = br.ReadInt32();

			return temp;
		}
	}
}
