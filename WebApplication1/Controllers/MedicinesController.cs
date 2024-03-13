using Microsoft.AspNetCore.Mvc;
using System.Net;
using WebApplication1.Data;

namespace WebApplication15.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MedicinesController : ControllerBase
    {
        //http://192.168.0.105:5016/api/Medicines/checkStatus
        [HttpGet("checkStatus")]
        public ActionResult<HttpStatusCode> CheckStatus()
        {
            return HttpStatusCode.OK;
        }

        //http://192.168.0.105:5016/api/Medicines/getMedicines
        [HttpGet("getMedicines")]
        public ActionResult<object> GetMedicines()
        {
            return Medicines.data;
        }

        //http://192.168.0.105:5016/api/Medicines/getMedicine?index=0
        [HttpGet("getMedicine")]
        public ActionResult<object> GetMedicine(int index)
        {
            return Medicines.data[index];
        }

        //http://192.168.0.105:5016/api/Medicines/addMedicine
        [HttpPost("addMedicine")]
        public ActionResult<HttpStatusCode> AddMedicine([FromBody] Medicines medicine)
        {
            Medicines.data.Add(medicine);
            return HttpStatusCode.OK;
        }

        //http://192.168.0.105:5016/api/Medicines/deleteMedicine?index=0
        [HttpDelete("deleteMedicine")]
        public ActionResult<HttpStatusCode> DeleteMedicine(int index)
        {
            Medicines.data.RemoveAt(index);
            return HttpStatusCode.OK;
        }

        //http://192.168.0.105:5016/api/Medicines/updateMedicine?index=0
        [HttpPut("updateMedicine")]
        public ActionResult<HttpStatusCode> UpdateMedicine(int index, [FromBody] Medicines updatedMedicine)
        {
            Medicines.data[index] = updatedMedicine;
            return HttpStatusCode.OK;
        }
    }
}
