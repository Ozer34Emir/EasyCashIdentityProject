using EasyCashIdentityProject.DateAccessLayer.Abstract;
using EasyCashIdentityProject.DateAccessLayer.Repositories;
using EasyCashIdentityProject.EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.DateAccessLayer.EntityFramework
{
    public class EfCustomerAccountProcessDal:GenericRepository<CustomerAccountProcess>,ICustomerAccountProcessDal
    {
    }
}
