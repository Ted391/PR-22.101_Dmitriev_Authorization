using PR_22._101_Dmitriev_Authorization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_22._101_Dmitriev_Authorization
{
    internal class Helper
    {
        private static DmitrievKR_ProgModulesEntities _context;

        public static DmitrievKR_ProgModulesEntities GetContext()
        {
            if (_context == null)
            {
                _context = new DmitrievKR_ProgModulesEntities();
            }
            return _context;
        }
    }
}
