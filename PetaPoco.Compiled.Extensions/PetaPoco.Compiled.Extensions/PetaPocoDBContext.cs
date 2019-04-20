/*******************************************************************************************
 *Copyright (c) 2019  All Rights Reserved.
 *CLR版本: 4.0.30319.42000
 *机器名称:ZHIMATECH
 *公司名称:
 *命名空间:PetaPoco.Compiled.Extensions
 *文件名:PetaPocoDBContext
 *版本号:V1.0.0.0
 *唯一标识:17a94219-5fd2-4108-aeda-7d770442ea84
 *当前的用户域:ZHIMATECH
 *创建人:Administrator
 *电子邮箱:mzyfbz@dingtalk.com
 *创建时间:2019/4/18 15:11:30

 *描述
 *
 *==========================================================================================
 *修改标记
 *修改时间:2019/4/18 15:11:30
 *修改人:Administrator
 *版本号:V1.0.0.0
 *描述:
 *
********************************************************************************************/

namespace PetaPoco.Compiled.Extensions
{
    using Microsoft.Extensions.Options;
    using PetaPoco;

    public abstract class PetaPocoDBContext:Database,IPetaPocoDBContext
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="optionsAccessor"></param>
        protected PetaPocoDBContext(IOptions<PetaPocoDBContextOptions> optionsAccessor)
            : base(optionsAccessor.Value.ConnectionString, optionsAccessor.Value.ProviderName)
        {

        }
    }

    public abstract class PetaPocoDBContextConfiguration : Database, IPetaPocoDBContext
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="optionsAccessor"></param>
        protected PetaPocoDBContextConfiguration(IOptions<PetaPocoDBContextConfigurationOptions> optionsAccessor)
            : base(optionsAccessor.Value.Configuration)
        {

        }
    }
}
