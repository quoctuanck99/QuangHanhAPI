using QuangHanhAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuangHanhAPI.Controllers
{
    public class QHApiController : ApiController
    {
        [Route("api/employees/{id}")]
        [HttpGet]
        public IHttpActionResult GetEmployee(string id)
        {
            QUANGHANHABCEntities db = new QUANGHANHABCEntities();
            var nhanvien = db.NhanViens.FirstOrDefault((p) => p.MaNV == id);
            if (nhanvien == null)
            {
                return NotFound();
            }
            return Ok(new { results = nhanvien});
        }
        [Route("api/employees")]
        [HttpGet, HttpPost]
        public IHttpActionResult GetAllEmployees()
        {
            QUANGHANHABCEntities db = new QUANGHANHABCEntities();

            var nhanviens = db.NhanViens.ToList<NhanVien>();

            if (nhanviens == null)
            {
                return NotFound();
            }
            return Ok(new { results= nhanviens });
            //return Request.CreateResponse<string>(HttpStatusCode.OK,"");
        }
    }
}
