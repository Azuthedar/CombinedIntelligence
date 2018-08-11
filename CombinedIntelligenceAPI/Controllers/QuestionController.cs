using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CombinedIntelligenceAPI.Controllers
{
    public class QuestionController : ApiController
    {
        // GET api/values
        public IEnumerable<string> GetQuestion()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string GetQuestion(int id)
        {
            return "value";
        }

        // POST api/values
        public void PostQuestion([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void PutQuestion(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void DeleteQuestion(int id)
        {
        }
    }
}
