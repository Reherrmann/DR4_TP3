using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class FriendsController : ApiController
    {
        // GET: api/Friends
        public IEnumerable<Amigo> Get()
        {
            return DataRepository.Amigos;
        }

        // GET: api/Friends/5
        public Amigo Get(string fname)
        {
            var result = DataRepository.Amigos.FirstOrDefault(Amigo => Amigo.FName.Equals(fname));

            if (result == null) 
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return result;
        }

       


        // POST: api/Friends
        public void Post(Amigo amigo)
        {
            throw new HttpResponseException(HttpStatusCode.NotImplemented);
        }

        // PUT: api/Friends/5
        public void Put(int id, Amigo value)
        {
            throw new HttpResponseException(HttpStatusCode.NotImplemented);
        }

        // DELETE: api/Friends/5
        public void Delete(int id)
        {
            throw new HttpResponseException(HttpStatusCode.NotImplemented);
        }
    }
}
