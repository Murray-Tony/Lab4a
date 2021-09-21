using System;

class Program {
  public static void Main (string[] args) {
    double total = 0;
    int car = 1;
    while (car <= 7)
    {
    Console.WriteLine("Enter distance covered by car #"+ car);
    double distance = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter time taken by car #" + car);
    double time = Convert.ToDouble(Console.ReadLine());
    double speed = (distance / time);
    Console.WriteLine("The speed of this car is " + speed + " miles per hour");
    total = total + speed;
    if (car == 7)
      {
        break;
      }
    car++;
    }
    double average = (total/car);
    Console.WriteLine("The average speed of the cars is " + average + " miles per hour");
  }
}