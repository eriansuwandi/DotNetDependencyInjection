using System;
using Ninject;

namespace NinjectApp
{
    public interface IWeapon
    {
        void Sword();
    }
    public class Ninja : IWeapon
    {
        public void Sword()
        {
            Console.WriteLine("I am using Sword");
        }
    }

    public class Erian
    {
        readonly IWeapon _objWeapon = null;
        public Erian(IWeapon tmpWeapon)
        {
            _objWeapon = tmpWeapon;
        }

        public void Attack()
        {
            _objWeapon.Sword();
        }
    }

    class NinjectFirstExample
    {
        static void Main(string[] args)
        {
            IKernel kernal = new StandardKernel();
            kernal.Bind<IWeapon>().To<Ninja>();
            var instance = kernal.Get<Erian>();
            instance.Attack();
            Console.ReadLine();
        }
    }
}
