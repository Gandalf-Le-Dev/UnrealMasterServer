﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UnrealMasterServer.Models;

namespace UnrealMasterServer.Controllers
{
    public class HostController : ApiController
    {
        // GET: api/Host
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Host/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Host
        public void Post(ServerData Data)
        {
            DatabaseInterface db = new DatabaseInterface();
            db.PostData(Data);
        }

        // PUT: api/Host/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Host/5
        public void Delete(int id)
        {
        }
    }
}
