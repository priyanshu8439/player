using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class PlayersController1 : Controller
    {
        static List<Player> list = new List<Player>()
        {
            new Player{PId=1,PName="Rohit",PTeam="India",PCategory="All-Rounder"},
            new Player{PId=2,PName="Virat",PTeam="CSK",PCategory="Batsman"},
            new Player{PId=3,PName="Dhoni",PTeam="India",PCategory="Bowler"},
            new Player{PId=4,PName="Mohd Shami",PTeam="Banglore",PCategory="Wicket-Keeper"},
        };
        public IActionResult Index()
        {
            return View(list);
        }
    }
}
