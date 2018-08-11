using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CombinedIntelligenceAPI.Controllers
{
    public class AnswerController : ApiController
    {
        // GET api/values
        public IEnumerable<string> GetAnswer()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string GetAnswer(int id)
        {
            return "value";
        }

        // POST api/values
        public void PostAnswer([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void PutAnswer(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void DeleteAnswer(int id)
        {
        }
    }
}
