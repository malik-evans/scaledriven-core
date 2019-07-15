using Scaledriven.Database;

namespace Scaledriven.Services
{
    /// todo fix: ModelFactory implementation
//    public class ModelFactory : Factory
//    {
//        private readonly ApplicationDbContext _context;
//
//
//        protected ModelFactory(ApplicationDbContext context)
//        {
//            _context = context;
//        }
//
//        /// <summary>
//        ///  class is abstract so the the this methods becomes base implementation
//        /// </summary>
//        /// <typeparam name="T">DbSet</typeparam>
//        public override T Create<T>()
//        {
//            T model = Create<T>();
//            _context.Set<T>().Add(model);
//
//            return _context.Set<T>().Find(model);
//        }
//
//        public new void CreateMany<T>(int amount = 10) where T : class
//        {
//            _context.Set<T>().AddRange(base.CreateMany<T>(amount));
//        }
//    }
}
