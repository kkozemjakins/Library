using System;

class Library{
  public string Name;
  public double WorkHoursStart;
  public double WorkHoursEnd;
  public int NumberBooks;
  public string City;
  public string District;

  public Library(string name, double workHoursStart, double workHoursEnd, int numberBooks, string city, string district){
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
  
  public bool IsWorkingNow(){
  
  }


}
