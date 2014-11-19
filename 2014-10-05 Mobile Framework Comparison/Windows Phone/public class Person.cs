public class Person
{
  public enum Sex
  {
    Male,
    Female,
  }
  public string Name { get; set; }
  public bool Moustache { get; set; }
  public bool Goatee { get; set; }
  public bool Beard { get; set; }
  public Sex WhichSex { get; set; }
  public double Height { get; set; }
  public DateTime BirthDate { get; set; }
  public bool Favorite { get; set; }
}