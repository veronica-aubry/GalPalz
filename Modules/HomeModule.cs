
using Nancy;

namespace Project
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View ["index.html", };
    }
  }
}
