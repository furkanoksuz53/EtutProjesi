using Etut.DataAccess;
using EtutProject.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EtutProject.Crud
{
    public class GenericRepository<T> where T : class
    {
        private readonly EtutContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(EtutContext etutContext)
        {
            _dbContext = etutContext;
            _dbSet = etutContext.Set<T>();
        }

        public List<EtutDTO> GetEtutDetails()
        {
            using (EtutContext context = new EtutContext())
            {
                var result = from et in context.Etuts
                             join s in context.Students
                             on et.StudentId equals s.StudentId
                             join t in context.Teachers
                             on et.TeacherId equals t.TeacherId
                             select new EtutDTO
                             {
                                 EtutId=et.EtutId,
                                 StudentName = s.Name+" "+s.Surname,
                                 TeacherName = t.Name + " " + t.Surname,
                                 Date=et.Date,
                                 Time=et.Time,
                                 Statu=et.Statu
                             };
                return result.ToList();
            }
        }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public List<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate).ToList();
        }

        public T GetById(object id)
        {
            return _dbSet.Find(id);
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void DeleteById(object id)
        {
            var entity = _dbSet.Find(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
            }
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
