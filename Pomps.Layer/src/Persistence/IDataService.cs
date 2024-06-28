using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Pomps.Layer.src.Persistence
{
    public interface IDataBase
    {
        object DbReader(IDataReader rd);
    }
}
