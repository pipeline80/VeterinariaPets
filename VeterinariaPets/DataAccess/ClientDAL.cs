using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VeterinariaPets.Models;

namespace VeterinariaPets.DataAccess
{
    public class ClientDAL
    {
        VeterinariaPetsContext db = new VeterinariaPetsContext();

        //Get a list of clients
        public IEnumerable<Client> GetAllClients()
        {
            return db.Client.ToList();
        }
        //Create new Client
        public int CreateClient(Client client)
        {
            db.Client.Add(client);
            db.SaveChanges();
            return 1;

        }
        //Update existing Client record    
        public int UpdateClient(Client student)
        {
            db.Entry(student).State = EntityState.Modified;
            db.SaveChanges();
            return 1;
        }
        //Get detail of a specific Client
        public Client GetClientData(int id)
        {
            Client student = db.Client.Find(id);
            return student;
        }
        //this method will delete the specifig student record    
        public int DeleteClient(int id)
        {
            Client emp = db.Client.Find(id);
            db.Client.Remove(emp);
            db.SaveChanges();
            return 1;
        }
    }
}
