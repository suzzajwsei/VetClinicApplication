using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetClinicApplication.MVVM.Model;

namespace VetAppTests
{
    public class GetData
    {
        /// <summary>
        /// Gets client from database
        /// </summary>
        /// <returns></returns>
        public static Client GetClient()
        {
            using var db = new AppDBContext();
            var q = db.Clients
                .Select(q => q)
                .FirstOrDefault();
            return q;
        }

        /// <summary>
        /// Counts all medical procedures
        /// </summary>
        /// <returns></returns>
        public static int ProceduresCount()
        {
            using var db = new AppDBContext();
            var q = db.MedProceduresList
                .Select(q => q)
                .ToList();

            return q.Count;
        }

        /// <summary>
        /// Generates client with null fields
        /// </summary>
        /// <returns></returns>
        public static Client GenerateNullClient()
        {
            Client client = new Client();
            client.ClientID = 0;
            client.Name = null;
            client.PhoneNr = null;
            client.Pesel = null;
            client.Surname = null;
            return client;
        }
    }
}
