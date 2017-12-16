/*
26. Создать абстрактный класс CVehicle.
	На его основе реализовать классы CPlane и ССаr.
	Классы должны иметь возможность задавать и получать координаты,
	параметры средств передвижения (цена, скорость, год выпуска).
	Для самолета должна быть определена высота, для автомобиля — количество пассажиров.
	Написать программу, создающую список объектов этих классов в динамической памяти.
*/

using System;
 
namespace Vehicle
{
    class Program
    {
        static void Main()
        {
            var car = new Car {Price = 50000};
            //Или так:
            //Car car = new Car();
            //car.Price = 50000
 
            car.Coordinate(40000,30000);
 
            Console.WriteLine("Стоимость машины {0}:", car.Price.ToString());
            //Console.WriteLine("Координаты машины X:{0},Y: {1}", car.CoordinateX.ToString(),car.CoordinateY.ToString());
            Console.WriteLine("Координаты машины X:{0},Y: {1}",car.CoordinateX.ToString(),car.CoordinateY.ToString());
            Console.Read();
        }
    }
      internal class Vehicle
      {
        private double coordinateX, coordinateY;
        private double price,speed,year_of_construction;
        
        /* можно также применять автосвойства(тогда не нужны написанные выше поля ):
         public double CoordinateX { get; set; }
        */
        public double CoordinateX 
         {
             get { return coordinateX; }
             set { coordinateX = value; }
         }
 
        public double CoordinateY
        {
            get { return coordinateY; }
            set { coordinateY = value; }
        }
        
          public double Price
         { get { return price; }
             set { price = value;}
         }
 
         public double Speed
         {
             get { return speed; }
             set { speed = value; }
         }
 
         public double Year_of_construction
         {
             get { return year_of_construction; }
             set { year_of_construction = value; }
         }
 
 
         //Метод для динамически меняющихся свойств
         public void Coordinate(double CoordinateX, double CoordinateY)
         {
              this.CoordinateX = CoordinateX;
              this.coordinateY = CoordinateY;
         }
 
         //Метод для динамически меняющихся свойств
         public void SpeedMethod(double Speed)
         {
              this.Speed = Speed;
         }
     }
 
        class Plane : Vehicle
        {
            public double Height { get; set; }
            public double NumberOfPassengers { get; set; }
        }
 
        class Ship : Vehicle
        {
            public double NumberOfPassengers { get; set; }
            public string DestinationPort { get; set; }
        }
 
        class Car :Vehicle
        {
          
        }
}