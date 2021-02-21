using System;
using System.Collections.Generic;
using System.Text;
using GameSimulation.Entities;

namespace GameSimulation.Abstract
{
    public abstract class BaseUserManager : IUserService
    {
        public virtual void Save(User user)
        {
            Console.WriteLine("Kaydınız Gerçekleşti: '" + user.FirstName + " " + user.LastName + "'");
        }

        public void Update(User user)
        {
            Console.WriteLine("Bilgileriniz güncellendi: '" + user.FirstName + " " + user.LastName + "'");
        }

        public void Delete(User user)
        {
            Console.WriteLine("Hesabınız silindi: '" + user.FirstName + " " + user.LastName + "'");
        }
    }
}
