using Microsoft.AspNetCore.Mvc;

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
                [ "Цитрамон", "Пушкинский", "986" ],
                [ "Нош-па", "Алексеевский", "874" ],
                [ "Ибупрофен", "Ивановский", "578" ]
            ];

            return new {data};
        }
    }
}
