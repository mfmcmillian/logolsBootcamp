using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace day2
{
    [Route("api/[controller]")]
    public class statusController : Controller
    {
        statusRepository statusRepository;

        public statusController()
        {
            statusRepository = new statusRepository();
        }

        // GET api/status
        [HttpGet]
        public List<status> Get()
        {
            return statusRepository.GetAll();
        }

         [HttpPost]
        public void Post([FromBody]status status)
        {
            statusRepository.Insert(status);
        }



         

    }
}