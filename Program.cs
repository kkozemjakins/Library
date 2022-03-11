using System;

class Program 
{
  public static void Main (string[] args) {
    Library Test = new Library("Rīgas Centrālās bibliotēka",12,2000,"Rīga", "Imanta");

    Console.WriteLine($"Strādnieka Vārds: {Test.Name}, darba laiks: {Test.WorkHoursStart}-{Test.WorkHoursEnd} stundas, profesija: {Test.NumberBooks}, City: {Test.City}, Rajons: {Test.Rajons}");

    Console.WriteLine(Test.IsWorkingNow);
  }

}