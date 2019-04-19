using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetaPoco.Compiled.Extensions.MvcTest.Models
{
    using PetaPoco;

    [TableName("Users")]
    public class User
    {

        public ulong Id { get; set; }
        public Guid Uid { get; set; }
        public string UserName { get; set; }
    }
}
