using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Encyption
{
    public class SigningCredentialsHelper
    {
        //JWT servicelerini WEP API kULLANABILECEGIz anaharı olusturur
        public static SigningCredentials CreateSigningCredentials(SecurityKey security)
        {
            //hangı anaharı kullanacgını ve hangı algorıtmayı kullanacagını gosterıyoruz burada
            return new SigningCredentials(security, SecurityAlgorithms.HmacSha512Signature);

        }
    }
}
