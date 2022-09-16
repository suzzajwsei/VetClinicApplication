using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Threading.Tasks;
using VetClinicApplication.MVVM.Model;

namespace VetAppTests
{
    [TestClass]
    public class VetAppUnitTests
    {

        /// <summary>
        /// trying to take any client from db. if some exists = test passed
        /// </summary>
        [TestMethod]
        public void GetClientFromDatabase()
        {
            var client1 = GetData.GetClient();

            Assert.IsNotNull(client1);
        }

        /// <summary>
        /// counts all med procs in db and compates it to number in parenthesis. if equal = test passed
        /// </summary>
        [TestMethod]
        public void CheckIfAllProceduresInDatabase()
        {
            var proc = GetData.ProceduresCount();

            Assert.AreEqual(9, proc);
        }
        /// <summary>
        /// Test trying to put null client into our sql db. fail = test passed
        /// </summary>
        [TestMethod]
        public void ForceInsertNullClinet()
        {
            bool isAdded = true;
            var client = GetData.GenerateNullClient();
            using var db = new AppDBContext();
            try
            {
                db.Clients.Add(client);
                db.SaveChanges();
            }
            catch (System.Exception)
            {
                isAdded = false;
                
            }

            Assert.IsFalse(isAdded);
        }
        /// <summary>
        /// trying to take animal with specific ID (1). If accomplished = test passed
        /// </summary>
        [TestMethod]
        public void GetFirstAnimal()
        {
            using var db = new AppDBContext();
            var q = db.Animals
                .Select(a => a)
                .Where(a => a.AnimalID == 1)
                .First();

            Assert.IsNotNull(q);
        }

    }
}
