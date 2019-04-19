using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetaPoco.Compiled.Extensions.MvcTest.DBContexts
{
    using Microsoft.Extensions.Options;

    public class MvcPetaPocoDBContext:PetaPocoDBContext
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="optionsAccessor"></param>
        public MvcPetaPocoDBContext(IOptions<PetaPocoDBContextOptions> optionsAccessor)
            : base(optionsAccessor)
        {
        }
    }
}
