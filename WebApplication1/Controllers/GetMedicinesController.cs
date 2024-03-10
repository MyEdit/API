using Microsoft.AspNetCore.Mvc;

namespace WebApplication15.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GetMedicinesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<string[]>> Get()
        {
            return new List<string[]> {
                new string[] { "Парацетамол", "Пушкинский", "789" },
                new string[] { "Цитрамон", "Пушкинский", "986" },
                new string[] { "Нош-па", "Алексеевский", "874" },
                new string[] { "Ибупрофен", "Ивановский", "578" }
            };
        }
    }
}
