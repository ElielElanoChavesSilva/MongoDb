using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaCarrosServer.Models;
public class MongoDBSettings
{
    public string ConnectionString { get; set; }

    public string DatabaseName { get; set; }
}