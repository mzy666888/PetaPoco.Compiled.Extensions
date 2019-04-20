/*******************************************************************************************
 *Copyright (c) 2019  All Rights Reserved.
 *CLR版本: 4.0.30319.42000
 *机器名称:ZHIMATECH
 *公司名称:
 *命名空间:PetaPoco.Compiled.Extensions
 *文件名:PetaPocoDbContextServiceCollectionExtensions
 *版本号:V1.0.0.0
 *唯一标识:841f6407-9bbc-497a-9f68-b44025176983
 *当前的用户域:ZHIMATECH
 *创建人:Administrator
 *电子邮箱:mzyfbz@dingtalk.com
 *创建时间:2019/4/15 15:30:49

 *描述
 *
 *==========================================================================================
 *修改标记
 *修改时间:2019/4/15 15:30:49
 *修改人:Administrator
 *版本号:V1.0.0.0
 *描述:
 *
********************************************************************************************/
using System;

namespace PetaPoco.Compiled.Extensions
{
    using Microsoft.Extensions.DependencyInjection;

    public static class PetaPocoDBContextServiceCollectionExtensions 
    {
        public static IServiceCollection AddPetaPoco<T>(
            this IServiceCollection services,
            Action<PetaPocoDBContextOptions> setupAction)
            where T : class ,IPetaPocoDBContext
        {
            if (null == services)
            {
                throw new ArgumentNullException(nameof(services));
            }

            if (null == setupAction)
            {
                throw new ArgumentNullException(nameof(setupAction));
            }

            services.AddOptions();
            services.Configure(setupAction);
            services.AddScoped<IPetaPocoDBContext, T>();

            return services;

        }

        public static IServiceCollection AddPetaPocoConfiguration<T>(
            this IServiceCollection services,
            Action<PetaPocoDBContextConfigurationOptions> setupAction)
            where T : class, IPetaPocoDBContext
        {
            if (null == services)
            {
                throw new ArgumentNullException(nameof(services));
            }

            if (null == setupAction)
            {
                throw new ArgumentNullException(nameof(setupAction));
            }

            services.AddOptions();
            services.Configure(setupAction);
            services.AddScoped<IPetaPocoDBContext, T>();

            return services;
        }
    }
}
