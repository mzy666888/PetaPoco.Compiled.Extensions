# PetaPoco.Compiled.Extensions
## .net core 2.2 asp.net mvc 中使用PetePoco

目前有两个DBContext：PetaPocoDBContext 和PetaPocoDBContextConfiguration
可用的Options分别为：PetaPocoDBContextOptions 和PetaPocoDBContextConfigurationOptions

对用两个不同的注入方法：
1、AddPetaPoco<T>

 定义一个继承PetaPocoDBContext的类MyPetaPocoDbContext，然后在Startup类的ConfigureServices方法中添加如下代码：
```
 services.AddPetaPoco<MyPetaPocoDbContext>(
     options =>
         {
             var connectionStrnig = Configuration["ConnectionStrings:mysql:WireCloudNetCoreMvcMySQL"];
             var providerName = Configuration["ConnectionStrings:mysql:providerName"];
             options.ConnectionString = connectionStrnig;
             options.ProviderName = providerName;
         });
```
2、AddPetaPocoConfiguration<T>
 
 定义一个继承PetaPocoDBContextConfiguration的类MvcPetaPocoDBContext，然后在Startup类的ConfigureServices方法中添加如下代码：
```
 services.AddPetaPocoConfiguration<MvcPetaPocoDBContext>(
                options =>
                    {
                        var connectionStrnig = Configuration["ConnectionStrings:MySQL:MvcMySQL"];
                        options.Configuration = DatabaseConfiguration.Build().UsingConnectionString(connectionStrnig)
                            .UsingProvider<MariaDbDatabaseProvider>();
                    });
```

使用时，两个DBContext，在项目中只需使用一个即可
在Service中，使用IPetaPocoDBContext就可以了

```
public class UserService : IUserService
    {
        private IPetaPocoDBContext _context;

        public UserService(IPetaPocoDBContext context)
        {
            _context = context;
        }
        
    }
```

在nuget中发布了0.0.2版本
使用命令 >> Install-Package PetaPoco.Compiled.Extensions -Version 0.0.2

BLOG:https://blog.csdn.net/weixin_42930928/article/details/89384044
