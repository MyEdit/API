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
                new string[] { "�����������", "����������", "789" },
                new string[] { "��������", "����������", "986" },
                new string[] { "���-��", "������������", "874" },
                new string[] { "���������", "����������", "578" }
            };
        }
    }
}
