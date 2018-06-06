namespace DataAccess.Repositories
{
    using ProjectDB.Entities;
    using System.Threading.Tasks;
    using System.Threading;
    using System.Data;
    using System.Data.Entity.Infrastructure;
    using System.Data.Common;
    using ProjectDB;
    using UserRepository;

    public class UnitOfWork
    {
        private readonly CourseProjectDbContext context;

      //  private RepositoryBase<User> userRepository;
        private RepositoryBase<Cinema> cinemaRepository;
        private RepositoryBase<Genre> genreRepository;
        private RepositoryBase<Movies> moviesRepository;


        private UsersRepository userRepository;

        public UnitOfWork(CourseProjectDbContext ctx)
        {
            context = ctx;
        }

        public UsersRepository GetUserRepository
        {
            get
            {
                if (userRepository == null)
                {
                    userRepository = new UsersRepository(context);
                }

                return userRepository;
            }
        }

        public RepositoryBase<Cinema> CinemaRepository
        {
            get
            {
                if (cinemaRepository == null)
                {
                    cinemaRepository = new RepositoryBase<Cinema>(context);
                }

                return CinemaRepository;
            }
        }

        public RepositoryBase<Genre> GenreRepository
        {
            get
            {
                if (genreRepository == null)
                {
                    genreRepository = new RepositoryBase<Genre>(context);
                }

                return genreRepository;
            }
        }

        public RepositoryBase<Movies> MoviesRepository
        {
            get
            {
                if (moviesRepository == null)
                {
                    moviesRepository = new RepositoryBase<Movies>(context);
                }

                return MoviesRepository;
            }
        }

        public DbTransaction Transaction { get; private set; }

        public virtual int SaveChanges() => context.SaveChanges();

        public Task<int> SaveChangesAsync()
        {
            return context.SaveChangesAsync();
        }

        public virtual Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return context.SaveChangesAsync(cancellationToken);
        }

        public virtual int ExecuteSqlCommand(string sql, params object[] parameters)
        {
            return context.Database.ExecuteSqlCommand(sql, parameters);
        }

        public virtual async Task<int> ExecuteSqlCommandAsync(string sql, params object[] parameters)
        {
            return await context.Database.ExecuteSqlCommandAsync(sql, parameters);
        }

        public virtual async Task<int> ExecuteSqlCommandAsync(string sql, CancellationToken cancellationToken, params object[] parameters)
        {
            return await context.Database.ExecuteSqlCommandAsync(sql, cancellationToken, parameters);
        }

        public virtual void BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.Unspecified)
        {
            var objectContext = ((IObjectContextAdapter)context).ObjectContext;
            if (objectContext.Connection.State != ConnectionState.Open)
            {
                objectContext.Connection.Open();
            }
            Transaction = objectContext.Connection.BeginTransaction(isolationLevel);
        }

        public virtual bool Commit()
        {
            Transaction.Commit();
            return true;
        }

        public virtual void Rollback()
        {
            Transaction.Rollback();
        }
    }
}
