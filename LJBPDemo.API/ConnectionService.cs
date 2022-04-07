using Microsoft.Extensions.Configuration;

namespace LJBPDemo.API
{
    public class ConnectionService
    {

        public static string connstring = "";
        public static void Set(IConfiguration config)
        {
            connstring = config.GetConnectionString("MyConnection");
        }
    }
}
