using Microsoft.AspNetCore.Mvc;
using System.Net;
using WebApplication1.Data;
using WebApplication1.Utils;

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
            return Medicines.getListMedicines(DataBaseWorker.ExecuteQuery("SELECT * FROM Medicines", 5));
        }

        //http://192.168.0.105:5016/api/Medicines/getMedicine?id=0
        [HttpGet("getMedicine")]
        public ActionResult<object> GetMedicine(int id)
        {
            List<string[]> medicine = DataBaseWorker.ExecuteQuery($"SELECT * FROM Medicines WHERE ID = {id}", 5);

            if (medicine == null)
                return HttpStatusCode.NotFound;

            return new Medicines(medicine[0]);
        }

        //http://192.168.0.105:5016/api/Medicines/addMedicine
        [HttpPost("addMedicine")]
        public ActionResult<HttpStatusCode> AddMedicine([FromBody] Medicines medicine)
        {
            DataBaseWorker.ExecuteQueryWithoutResponse($"INSERT INTO Medicines (Name, Storage, Count) VALUES ('{medicine.Name}', '{medicine.Storage}', {medicine.Count})");
            return HttpStatusCode.OK;
        }

        //http://192.168.0.105:5016/api/Medicines/deleteMedicine?id=0
        [HttpDelete("deleteMedicine")]
        public ActionResult<HttpStatusCode> DeleteMedicine(int id)
        {
            DataBaseWorker.ExecuteQueryWithoutResponse($"DELETE FROM Medicines WHERE ID = {id}");
            return HttpStatusCode.OK;
        }

        //http://192.168.0.105:5016/api/Medicines/updateMedicine?id=0
        [HttpPut("updateMedicine")]
        public ActionResult<HttpStatusCode> UpdateMedicine(int id, [FromBody] Medicines updatedMedicine)
        {
            DataBaseWorker.ExecuteQueryWithoutResponse($"UPDATE Medicines SET Name = '{updatedMedicine.Name}', Storage = '{updatedMedicine.Storage}', Count = {updatedMedicine.Count} WHERE ID = {id}");
            return HttpStatusCode.OK;
        }
    }
}
