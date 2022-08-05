using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Gold.Logic
{
    public class DataHelper
    {
        private static DataHelper _instance;
        public static DataHelper Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DataHelper();
                return _instance;
            }
        }

        public string HashText(string text)
        {
            using MD5 md5Hash = MD5.Create();
            byte[] sourceBytes = Encoding.UTF8.GetBytes(text);
            byte[] hashBytes = md5Hash.ComputeHash(sourceBytes);
            return BitConverter.ToString(hashBytes).Replace("-", string.Empty);
        }
    }
}
