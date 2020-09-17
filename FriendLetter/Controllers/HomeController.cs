using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {

    [Route("/hello")]
    public string Hullo() { return "Hullo, Gandalf!"; }

    [Route("/goodbye")]
    public string Adios() { return "Adios, guapx ;)";}

    [Route("/")]
    public ActionResult Letter() { 
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = "Lina";
      return View(myLetterVariable);
     }
  }
}