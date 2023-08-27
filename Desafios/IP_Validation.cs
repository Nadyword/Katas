using System.Net;
using System.Text.RegularExpressions;

namespace Katas
{
    internal class IP_Validation
    {

        #region Mi solucion
        public bool is_valid_IP(string ipAddres)
        {
            string[] Ip = ipAddres.Split('.');
            bool resul = true;

            try
            {
                if (Ip.Any(a => a.Length > 1 && a[0] == '0')) resul = false;
                if (Ip.Any(a => a.Contains(' '))) resul = false;
                if (Ip.Any(a => Convert.ToInt16(a) > 255)) return false;
                if (Ip.Any(a => Convert.ToInt16(a) < 0)) return false;
                if (Ip.GetLength(0) != 4) return false;
            }
            catch { return false; }

            return resul;
        }
        #endregion

        #region Opccion 1
        public static bool IsValidIp1(string ipAddres)
        {
            //using System.Text.RegularExpressions;
            Regex regex = new Regex(@"^((25[0-5]|(2[0-4]|1\d|[1-9]|)\d)\.?\b){4}$");
            return regex.IsMatch(ipAddres);
        }

        #endregion

        #region Opccion 2
        public static bool IsValidIp2(string IpAddress)
        {
            //using System.Net;
            return IPAddress.TryParse(IpAddress, out var parsedIp)
              && IpAddress.Split('.').Length == 4;
        }
        #endregion

        #region Opccion 3
        public static bool IsValidIp(string ipAddres) =>
        new Regex("^((2[0-5][0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[1-9]|0)\\.){3}(2[0-5][0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[1-9]|0)$").IsMatch(ipAddres);
        #endregion
    }
}
