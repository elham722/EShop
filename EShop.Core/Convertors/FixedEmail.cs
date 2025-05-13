using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Core.Convertors
{
    public static class FixedEmail
    {
        public static string FixEmail(string email)
        {
            return email.Trim().ToLower();
        }
    }
}
