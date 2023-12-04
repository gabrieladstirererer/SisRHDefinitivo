using System;
using SisRHDefinitivo.Core.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisRHDefinitivo.Core.Repository
{
    public interface ILoginRepository
    {
        Login BuscarPorLogin(string login);
    }
}
