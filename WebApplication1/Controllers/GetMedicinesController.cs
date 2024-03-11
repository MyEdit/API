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
                ["�����������", "����������", "789"],
                [ "��������", "����������", "986" ],
                [ "���-��", "������������", "874" ],
                [ "���������", "����������", "578" ]
            ];

            return new {data};
        }
    }
}
