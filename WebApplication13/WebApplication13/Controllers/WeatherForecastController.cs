using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication13.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        List<Books> bookStore = new List<Books>
        {
            new Books(){Name= "In Search of Lost Time", shelfNumber="F105" , Category="Action", price=450},
            new Books(){Name= "The Great Gatsby"      , shelfNumber="F105" , Category="Fiction", price=450},
            new Books(){Name= "Wuthering Heights"     , shelfNumber="F105" , Category="Adventure", price=450},
            new Books(){Name= "Catcher in the Rye"    , shelfNumber="F107" , Category="Action", price=450},
            new Books(){Name= "War and Peace"         , shelfNumber="F106" , Category="Horror", price=450},
            new Books(){Name= "Invisible Man"         , shelfNumber="F108" , Category="Action", price=450},
            new Books(){Name= "In Search of Lost Time", shelfNumber="F108" , Category="Action", price=450},
            new Books(){Name= "Crime and Punishment"  , shelfNumber="F107" , Category="Crime", price=450},


        };

        private readonly ILogger<BooksController> _logger;

        public BooksController(ILogger<BooksController> logger)
        {
            _logger = logger;
        }


        [Route("names")]
        [HttpGet]
        public List<string> Get()
        {

            List<string> namesList = new List<string>();

            for (int i=0;i<bookStore.Count;i++) 
            {
                namesList.Add(bookStore[i].Name);


            }
            return namesList;
            

        }

        //[Route("names/{id}")]
        //public ActionResult GetRecordsById(int id)
        //{
            
            
        //    return Ok(bookStore[id]);
        //}

        [Route("names/{id2}")]
        [HttpGet]
        public Books findByNames(string id2)
        {

            Books booksDontExist = new Books();

            
            foreach(var i in bookStore)
            {
                if(i.Name==id2)
                {
                    return i;
                }
            }
            return booksDontExist;

        }






    }
}
