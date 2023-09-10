using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryApi.Persistance.Configurations
{
    public static class Connection
    {
        static public string ConnectionStringForDormitoryApiDB
        {
            get
            {
                ConfigurationManager configurationManager = new();

                //C:\Users\user\source\repos\DormitoryAPI\DormitoryApi.Persistance - burdan
                //C:\Users\user\source\repos\DormitoryAPI\DormitoryApi.PresentationPages
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../DormitoryAPI/DormitoryApi.Presentation"));
                configurationManager.AddJsonFile("appsettings.json");


                return configurationManager.GetConnectionString("DormitoryApiDB");

            }
        }
    }
}
