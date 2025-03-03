using Microsoft.EntityFrameworkCore;
using Repository.InterFaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mock
{
    class DataBase:DbContext, IContext
    {
        
    }
}
