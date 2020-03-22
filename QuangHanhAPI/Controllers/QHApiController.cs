using QuangHanhAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
                id = requestData.id;
                token = requestData.token;
                if (token == "rZslJnUHOW")
                {
                    string sql = @"select nv.*, dp.department_name as TenPhongBan from NhanVien nv, Department dp where nv.MaNV = @id1 and nv.MaPhongBan=dp.department_id
                    UNION ALL
                    select *,NULL as TenPhongBan from nhanvien where MaPhongBan is null AND NhanVien.MaNV = @id2";
                    ; QUANGHANHABCEntities db = new QUANGHANHABCEntities();
                    var nhanvien = db.Database.SqlQuery<NhanVienResultModel>(sql, new SqlParameter("@id1", id), new SqlParameter("@id2", id)).ToList<NhanVienResultModel>().FirstOrDefault<NhanVienResultModel>();
                    if (nhanvien == null)
                    {
                        return Ok(new { success = true, message = "NO RECORDS FOUND!" });
                    }
                    return Ok(new { success = true, message = "SUCCESSED!", results = nhanvien });
                }
                else
                {
                    return Ok(new { success = false, message = "INVALID TOKEN!" });
                }
            }
            catch (Exception e)
            {
                return Ok(new { success = false, message = "INVALID REQUEST!" });
            }
        }
        [Route("api/employees")]
        [HttpPost]
        public IHttpActionResult GetAllEmployees()
        {
            QUANGHANHABCEntities db = new QUANGHANHABCEntities();

            string sql = @"select nv.*, dp.department_name as TenPhongBan from NhanVien nv, Department dp where nv.MaPhongBan=dp.department_id
                            UNION ALL
                            select *,NULL as TenPhongBan from nhanvien where MaPhongBan is null ";
            var nhanviens = db.Database.SqlQuery<NhanVienResultModel>(sql).ToList<NhanVienResultModel>();

            if (nhanviens == null)
            {
                return Ok(new { success = false, message = "Error!", results = new List<Employee>() });
            }
            return Ok(new { success = true, message = "Success!", results = nhanviens });
            //return Request.CreateResponse<string>(HttpStatusCode.OK,"");
        }
        public class requestData
        {
            public string id { get; set; }
            //public string[] id
            //{
            //    get
            //    {
            //        return this._id;
            //    }
            //    set
            //    {
            //        this._id = value;
            //    }
            //}
            //public string getIdList()
            //{
            //    return "'"+string.Join("','", this._id)+"'" ;
            //}
            //public string[] id { get { return null; } set; }
            public string token { get; set; }
        }
        public class NhanVienResultModel : NhanVien
        {
            public string TenPhongBan { get; set; }
        }
    }
}
