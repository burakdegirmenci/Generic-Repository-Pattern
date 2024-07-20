using RepositoryPattern.Domain.Entities;
using RepositoryPattern.Infrastructure.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Infrastructure.Repositories.PublisherRepositories;

public class PublisherRepository : BaseRepository<Publisher>, IPublisherRepository
{
}
