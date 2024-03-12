using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml;
using System.Xml.Linq;

namespace WebApplication15.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GetMedicinesController : ControllerBase
    {

        [HttpGet]
        public ActionResult<object> Get()
        {
            List<string[]> data =
            [
                ["Парацетамол", "Пушкинский", "789"],
                ["Цитрамон", "Пушкинский", "986"],
                ["Нош-па", "Алексеевский", "874"],
                ["Ибупрофен", "Ивановский", "578"]
            ];

            return new { data };
        }

        //return struct or class
        /*
            struct Player
            {
                public string name { get; set; }
                public int age { get; set; }
                public DateTime dateBirthday { get; set; }
            }
            [HttpGet]
            public ActionResult<object> Get()
            {
                List<Player> players =
                [
                    new Player() { name = "Alex", age = 5, dateBirthday = DateTime.Now.Date },
                    new Player() { name = "Oleg", age = 35, dateBirthday = DateTime.Now.Date },
                    new Player() { name = "Ruslan", age = 47, dateBirthday = DateTime.Now.Date }
                ];

                return new { players };
            }
        */
    }
}
