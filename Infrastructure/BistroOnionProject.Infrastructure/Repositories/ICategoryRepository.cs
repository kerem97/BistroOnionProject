using BistroOnionProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BistroOnionProject.Infrastructure.Persistence.Repositories
{
    public interface ICategoryRepository : GenericRepository<Category>
    {
    }
}
