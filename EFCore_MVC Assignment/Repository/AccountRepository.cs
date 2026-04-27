using EFCore_MVC_Assignment.Entity;
using EFCore_MVC_Assignment.Database;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace EFCore_MVC_Assignment.Repository
{
    public class AccountRepository
    {
        private readonly AppContextDb _context;

        public AccountRepository()
        {
            _context = new AppContextDb();
        }

        public void AddAccount(Account account)
        {
            _context.Accounts.Add(account);
            _context.SaveChanges();
        }

        public List<Account> GetAccounts()
        {
            return _context.Accounts.ToList();
        }

        public Account? GetAccount(int id)
        {
            return _context.Accounts.FirstOrDefault(a => a.AccountId == id);
        }

        public Account? GetAccountByCustomer(string name)
        {
            return _context.Accounts.FirstOrDefault(a => a.Customer == name);
        }

        public void UpdateAccount(Account account)
        {
            _context.Accounts.Update(account);
            _context.SaveChanges();
        }

        public void DeleteAccount(Account account)
        {
            _context.Accounts.Remove(account);
            _context.SaveChanges();
        }
    }
}