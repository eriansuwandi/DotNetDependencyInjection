
using System;
using System.Reflection;
using Ninject;

namespace NinjectSecondApp
{
    class NinjectSecondExample
    {
        public static void Main()
        {
            StandardKernel _kernel = new StandardKernel();
            _kernel.Load(Assembly.GetExecutingAssembly());
            IProduct objProduct = _kernel.Get<IProduct>();
            var objBL = new BusinessLogic(objProduct);
            objBL.Insert();
            Console.ReadLine();
        }
    }
    public class NinjectBindings : Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
            Bind<IProduct>().To<DataAccessLayer>();
        }
    }

    public class BusinessLogic
    {
        IProduct objProd;
        public BusinessLogic(IProduct tmpProd)
        {
            objProd = tmpProd;
        }

        public void Insert()
        {
            objProd.InsertProduct();
        }
    }

    public class DataAccessLayer : IProduct
    {
        public string InsertProduct()
        {
            string value = "Dependecy Injection using Ninject";
            Console.WriteLine(value);
            return value;
        }
    }

    public interface IProduct
    {
        string InsertProduct();
    }
}
