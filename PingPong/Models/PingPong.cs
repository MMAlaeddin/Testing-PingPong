namespace PingPong
{
  public class PingPong
  {
    public bool IsPing(int number)
    {
      return number % 5 == 0;
    }
    public bool IsPong(int number)
    {
      return number % 3 == 0;
    }
    public bool IsPingPong(int number)
    {
      return number % 15 == 0;
    }
  }
}