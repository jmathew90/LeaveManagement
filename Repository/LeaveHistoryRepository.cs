using LeaveManagement.Contracts;
using LeaveManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace LeaveManagement.Repository
{
    public class LeaveHistoryRepository : ILeaveHistoryRepository
    {
        private readonly ApplicationDbContext _db;

        public LeaveHistoryRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(LeaveHistory entity)
        {
            _db.LeaveHistories.Add(entity);
            return Save();
        }

        public bool Delete(LeaveHistory entity)
        {
            _db.LeaveHistories.Remove(entity);
            return Save();
        }

        public ICollection<LeaveHistory> FindAll()
        {
            return _db.LeaveHistories.ToList();
        }

        public LeaveHistory FindById(int id)
        {
            return _db.LeaveHistories.Find(id);
        }

        public ICollection<LeaveHistory> GetEmployeesByLeaveType(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            var change = _db.SaveChanges();
            return change > 0;
        }

        public bool Update(LeaveHistory entity)
        {
            _db.LeaveHistories.Update(entity);
            return Save();

        }
    }
}
    
