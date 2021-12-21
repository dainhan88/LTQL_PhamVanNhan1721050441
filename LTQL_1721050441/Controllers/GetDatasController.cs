using LTQL_1721050441.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTQL_1721050441.Controllers
{
    public class GetDatasController : Controller
    {
        // GET: GetDatas
        PVN1721050441DbContext db = new PVN1721050441DbContext();
        // GET: View2chucnang
        public ActionResult Index()
        {
            var List = from st in db.NhaCungCap441s
                       join s in db.PVNSanPham441s on st.MaNhaCungCap equals s.MaNhaCungCap
                       select new GetData { NhaCungCap441s = st, pVNSanPham441s = s };
            return View(List);
        }
    }
}