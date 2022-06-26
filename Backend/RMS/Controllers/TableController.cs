using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace RMS.Controllers
{
    [EnableCors("*", "*", "*")]
    public class TableController : ApiController
    {
        [Route("api/tables/alltables")]
        [HttpGet]
        public HttpResponseMessage GetTables()
        {
            return Request.CreateResponse(HttpStatusCode.OK, TableService.GetTable());
        }

        [Route("api/tables/reservetables")]
        [HttpGet]
        public HttpResponseMessage GetReserveTables()
        {
            return Request.CreateResponse(HttpStatusCode.OK, TableService.GetReserved());
        }

        [Route("api/tables/nonreservetables")]
        [HttpGet]
        public HttpResponseMessage GetNonReserveTables()
        {
            return Request.CreateResponse(HttpStatusCode.OK, TableService.GetNonReserved());
        }

        [Route("api/tables/tablereserve")]
        [HttpPost]
        public HttpResponseMessage TableSererve(TableModel tl)
        {
            TableService.TableReserve(tl);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
