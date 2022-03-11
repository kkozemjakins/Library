using System;

class Library{
  public string Name;
  public int WorkHoursStart;
  public int WorkHoursEnd = 20;
  public int NumberBooks;
  public string City;
  public string Rajons;

  public Library(string name, int workHoursStart, int numberBooks, string city, string rajons){
    Name = name;
    WorkHoursStart = workHoursStart;
    //WorkHoursEnds = workHoursEnd;
    NumberBooks = numberBooks;
    City = city;
    Rajons = rajons;

  }


}