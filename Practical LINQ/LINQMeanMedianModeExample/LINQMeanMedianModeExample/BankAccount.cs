using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQGroupByExample
{
    public class BankAccount
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public double Balance { get; set; }

        public static BankAccount CreatAccount(int theAge, string theFN, string theSN, double theBalance)
        {
            return new BankAccount() { Age = theAge, FirstName = theFN, Surname = theSN, Balance = theBalance };
        }
    }

    public class BankAccounts
    {
        public List<BankAccount> m_BankAccounts { get; set; }

        public BankAccounts()
        {
            m_BankAccounts = new List<BankAccount>();
            CreateAccounts();
        }

        private void CreateAccounts()
        {
            m_BankAccounts.Add( BankAccount.CreatAccount( 5, "Naruto", "Uzumaki", 100 ) );
            m_BankAccounts.Add( BankAccount.CreatAccount( 5, "Sasuke", "Uchiha", 150 ) );
            m_BankAccounts.Add( BankAccount.CreatAccount( 7, "Itachi", "Uchiha", 1000 ) );
            m_BankAccounts.Add( BankAccount.CreatAccount( 10, "Kakashi", "Kakashi", 100 ) );
            m_BankAccounts.Add( BankAccount.CreatAccount( 10, "Gai", "Mitei", 75 ) );
            m_BankAccounts.Add( BankAccount.CreatAccount( 20, "Sensei", "Jiraiya", 10000 ) );
            m_BankAccounts.Add( BankAccount.CreatAccount( 5, "Sakura", "Hanato", 400 ) );
        }
    }
}
