public class Author 
{

  private string email;
  private string name;
  private char gender;

  public string Email
  {
    get
    {
      return this.email;
    } 
    set {
      email = value;
    }
  }

  public string Name 
  {
    get
    {
      return this.name;
    } 
    set {
      name = value;
    }
  }

  public char Gender
  {
    get
    {
      return this.gender;
    } 
    set {
      gender = value;
    }
  }
}