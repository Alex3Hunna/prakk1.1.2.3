using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakk1._1._2._3
{
    internal class Program
    {
        class Car
        {

            public double NumCar;
            public string NameCar;
            public double maxspeed;
            public double Race_end_time;

            public Car(string NameCar, double maxspeed)
            {

                this.NameCar = NameCar;
                this.maxspeed = maxspeed;

            }


            public void CalculateTime(double distance)
            {
                this.Race_end_time = distance / maxspeed;
            }


            public void race(string race)
            {

            }



        }


        static void Main(string[] args)
        {
            double distance = 700;








            Car car_1 = new Car("Bugatti", 490);
            car_1.CalculateTime(distance);
            Console.WriteLine(car_1.NameCar);
            Console.WriteLine(car_1.Race_end_time);


            Car car_2 = new Car("Koenigsegg", 531);
            car_2.CalculateTime(distance);
            Console.WriteLine(car_2.NameCar);
            Console.WriteLine(car_2.Race_end_time);


            Car car_3 = new Car("SSC Tuatara", 460);
            car_3.CalculateTime(distance);
            Console.WriteLine(car_3.NameCar);
            Console.WriteLine(car_3.Race_end_time);

            Car car_4 = new Car("McLaren", 403);
            car_4.CalculateTime(distance);
            Console.WriteLine(car_4.NameCar);
            Console.WriteLine(car_4.Race_end_time);

            // string[] gons = new string[] { car_1.NameCar, car_2.NameCar, car_3.NameCar, car_4.NameCar };
            //double[] gon = new double[] { car_1.Race_end_time, car_2.Race_end_time, car_3.Race_end_time, car_4.Race_end_time };

            // var gon1 = gon.OrderBy(Race_and_time=>Race_and_time);



            // foreach (double gon2 in gon1)
            //   {

            //     Console.WriteLine(gon2);

            //   }







            double min;
            string[] gons = new string[] { car_1.NameCar, car_2.NameCar, car_3.NameCar, car_4.NameCar };
            double[] gon = new double[] { car_1.Race_end_time, car_2.Race_end_time, car_3.Race_end_time, car_4.Race_end_time };
            min = gon[0];
            for (int i = 1; i < 4; i++)
            {
                if (gon[i] < min) { min = gon[i]; };
                {

                    Console.WriteLine("Winner = {0}", min);
                    break;

                }

            }







            Console.ReadLine();
        }
        
    }
}
