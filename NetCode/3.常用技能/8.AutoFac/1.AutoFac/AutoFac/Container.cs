using _1.AutoFac.BLL;
using _1.AutoFac.IBLL;
using Autofac;
using System;

/// <summary>
/// Autofac IOC类
/// </summary>
public class Container
{
    /// <summary>
    /// IOC 容器
    /// </summary>
    public static IContainer container = null;
    public static T Resolve<T>()
    {
        try
        {
            if (container == null)
            {
                Initialise();
            }
        }
        catch (Exception ex)
        {
            throw new Exception("IOC实例化出错!" + ex.Message);
        }

        return container.Resolve<T>();
    }

    /// <summary>
    /// 初始化
    /// </summary>
    public static void Initialise()
    {
        var builder = new ContainerBuilder();

        //格式：builder.RegisterType<xxxx>().As<Ixxxx>().InstancePerLifetimeScope();
        builder.RegisterType<TestBLL>().As<ITestBLL>().InstancePerLifetimeScope();

        container = builder.Build();
    }
}