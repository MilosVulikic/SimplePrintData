using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintData
{
    static class UserData
    {
        public static List<Account> GetData()
        { 
        List<Account> bankAccounts = new List<Account> {
        new Account {
                      ID = 345678,
                      Balance = 541.27
                    },
        new Account {
                      ID = 4531,
                      Balance = -14.90
                    },
        new Account {
                      ID = 54431,
                      Balance = -5.18
                    },
        new Account {
                      ID = 1286128,
                      Balance = 147.12
                    },
        new Account {
                      ID = 123745,
                      Balance = 99.57
                    },
        new Account {
                  ID = 95841,
                  Balance = -23.43
                },
        new Account {
                  ID = 4531,
                  Balance = -14.90
                },
        new Account {
                      ID = 54431,
                      Balance = -5.18
                    },
        new Account {
                    ID = 4531,
                    Balance = -14.90
                },
        new Account {
                      ID = 54431,
                      Balance = -5.18
                    },
        new Account
        {
            ID = 123745,
            Balance = 99.57
        },
        new Account
        {
            ID = 95841,
            Balance = -23.43
        },
        new Account
        {
            ID = 4531,
            Balance = -14.90
        },
        };
            return bankAccounts;
        }
        
    }

}
