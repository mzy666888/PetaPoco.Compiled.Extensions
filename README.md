# PetaPoco.Compiled.Extensions
## .net core 2.2 asp.net mvc 中使用PetePoco

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


在nuget中发布了0.0.1版本
使用命令 >> Install-Package PetaPoco.Compiled.Extensions -Version 0.0.1

BLOG:https://blog.csdn.net/weixin_42930928/article/details/89384044
