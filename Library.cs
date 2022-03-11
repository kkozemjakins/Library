using System;

class Library{
  public string Name;
  public int WorkHoursStart;
  public int WorkHoursEnd;
  public int NumberBooks;
  public string City;
  public string District;

  public Library(string name, int workHoursStart, int workHoursEnd, int numberBooks, string city, string district){
    Name = name;
    WorkHoursStart = workHoursStart;
    WorkHoursEnd = workHoursEnd;
    NumberBooks = numberBooks;
    City = city;
    District = district;

  }

  public void PrintInfo(){
    Console.WriteLine($"Library name: {Name}\nWorking Hours: {WorkHoursStart} - {WorkHoursEnd}\nNumber of books: {NumberBooks}\nCity: {City}\nDistrict: {District}");
  }


}