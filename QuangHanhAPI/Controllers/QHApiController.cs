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
        [Route("api/employee")]
        [HttpPost]
        public IHttpActionResult GetEmployee(requestData requestData)
        {
            string id;
            string token;
            try
            {
                id = requestData.getIdList();
                token = requestData.token;
                if (token == "rZslJnUHOW")
                {
                    string sql = @"select nv.*, dp.department_name from NhanVien nv, Department dp where nv.MaNV in ( "+id+@") and nv.MaPhongBan=dp.department_id
                    UNION ALL
                    select *,NULL as department_name from nhanvien where MaPhongBan is null AND NhanVien.MaNV in ("+id+")";
                    QUANGHANHABCEntities db = new QUANGHANHABCEntities();
                    var nhanvien = db.Database.SqlQuery<NhanVien>(sql).ToList<NhanVien>();
                    if (nhanvien == null||nhanvien.Count==0)
                    {
                        return Ok(new { success = "true", message = "No records found!", results = new List<Employee>() });
                    }
                    return Ok(new { success = "true", message = "Success!",results = nhanvien });
                }
                else
                {
                    return Ok(new { success = "false", message = "Invalid token!", results = new List<Employee>() });
                }
            }
            catch (Exception e)
            {
                return Ok(new { success = "false", message = "Please check the request data!", results = new List<Employee>() });
            }
        }
        [Route("api/employees")]
        [HttpPost]
        public IHttpActionResult GetAllEmployees()
        {
            QUANGHANHABCEntities db = new QUANGHANHABCEntities();

            string sql = @"select nv.*, dp.department_name from NhanVien nv, Department dp where nv.MaPhongBan=dp.department_id
                            UNION ALL
                            select *,NULL as department_name from nhanvien where MaPhongBan is null ";
            var nhanviens = db.Database.SqlQuery<NhanVien>(sql).ToList<NhanVien>();

            if (nhanviens == null)
            {
                return Ok(new { success = "false", message = "Error!", results = new List<Employee>()});
            }
            return Ok(new { success = "true", message = "Success!", results = nhanviens});
            //return Request.CreateResponse<string>(HttpStatusCode.OK,"");
        }
        public class requestData
        {
            string[] _id;
            public string[] id
            {
                get
                {
                    return this._id;
                }
                set
                {
                    this._id = value;
                }
            }
            public string getIdList()
            {
                return "'"+string.Join("','", this._id)+"'" ;
            }
            //public string[] id { get { return null; } set; }
            public string token { get; set; }
        }
    }
}
