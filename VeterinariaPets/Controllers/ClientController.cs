using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VeterinariaPets.Models;
using VeterinariaPets.DataAccess;

namespace VeterinariaPets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        ClientDAL obj = new ClientDAL();

        [HttpGet]
        [Route("api/Client/Index")]
        public IEnumerable<Client> Index()
        {
            return obj.GetAllClients();
        }
        [HttpPost]
        [Route("api/Client/Create")]
        public int Create(Client client)
        {
            return obj.CreateClient(client);
        }
        [HttpGet]
        [Route("api/Client/Details/{id}")]
        public Client Details(int id)
        {
            return obj.GetClientData(id);
        }
        [HttpPut]
        [Route("api/Client/Edit")]
        public int Edit(Client client)
        {
            return obj.UpdateClient(client);
        }
        [HttpDelete]
        [Route("api/Client/Delete/{id}")]
        public int Delete(int id)
        {
            return obj.DeleteClient(id);
        }
    }
}
