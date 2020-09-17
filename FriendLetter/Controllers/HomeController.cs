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
      myLetterVariable.Sender = "Ludwig";
      return View(myLetterVariable);
     }

     [Route("/form")]
     public ActionResult Form() { return View(); }

     [Route("/postcard")]
     public ActionResult Postcard(string recipient, string sender)
     {
       LetterVariable model = new LetterVariable();
       model.Recipient = recipient;
       model.Sender = sender;
       return View(model);
     }
  }
}