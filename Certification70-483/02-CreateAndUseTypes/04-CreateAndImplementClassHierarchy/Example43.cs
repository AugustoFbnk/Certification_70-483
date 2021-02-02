using System;
using System.Collections.Generic;
using System.Linq;

namespace Certification70_483._02_CreateAndUseTypes._04_CreateAndImplementClassHierarchy
{
    /// <summary>
    /// Creating an interface with a generic type parameter
    /// </summary>
    public static class Example43
    {

        public static void Start()
        {
            var client = new Client();
            Console.WriteLine($"Id 1: {client.FindById(1).id}");
            Console.WriteLine("All clients:");
            foreach (var record in client.All())
            {
                Console.WriteLine($"Id: {record.id}");
            }
            Console.ReadKey();
        }
    }

    public class Client : IRepository<ClientEntity>
    {
        private IEnumerable<ClientEntity> records = new List<ClientEntity> //mock
        {
            new ClientEntity
            {
               id = 1
            },
            new ClientEntity
            {
               id = 2
            },
            new ClientEntity
            {
               id = 3
            },
        };

        public IEnumerable<ClientEntity> All()
        {
            return records.ToList();
        }

        public ClientEntity FindById(int id)
        {
            return records.Where(x => x.id == id).FirstOrDefault();
        }
    }

    public class ClientEntity
    {
        public int id { get; set; }
    }

    public interface IRepository<T>
    {
        T FindById(int id);
        IEnumerable<T> All();
    }
}
