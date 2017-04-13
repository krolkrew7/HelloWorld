using System.Collections.Generic;
using System.Web.Http;


namespace HelloWorldApp
{
    public class WriteMessageController : ApiController
    {
        private WriterFactory _writerFactory = null;
        public WriteMessageController()
        {
            _writerFactory = new WriterFactory();
        }
       
        // POST api/values 
        public void Post([FromBody] string value)
        {
            IWriter writer = _writerFactory.GetWriter();
            writer.Write(value);
        }
    }
}