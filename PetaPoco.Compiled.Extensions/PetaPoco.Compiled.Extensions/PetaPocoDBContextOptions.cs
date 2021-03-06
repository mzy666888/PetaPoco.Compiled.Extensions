﻿namespace PetaPoco.Compiled.Extensions
{
    using Microsoft.Extensions.Options;

    public class PetaPocoDBContextOptions : IOptions<PetaPocoDBContextOptions>
    {
        /// <summary>The default configured TOptions instance</summary>
        PetaPocoDBContextOptions IOptions<PetaPocoDBContextOptions>.Value => this;

        public string ConnectionString { get; set; }
        public string ProviderName { get; set; }
    }

    public class PetaPocoDBContextConfigurationOptions : IOptions<PetaPocoDBContextConfigurationOptions>
    {
        /// <summary>The default configured TOptions instance</summary>
        PetaPocoDBContextConfigurationOptions IOptions<PetaPocoDBContextConfigurationOptions>.Value => this;

        
        public IDatabaseBuildConfiguration Configuration { get; set; }
    }


}
