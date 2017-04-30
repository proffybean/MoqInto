using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqProject
{
    public class DbAccessor : IDbAccessor
    {
        private IDataBase db;
        public DbAccessor(IDataBase db)
        {
            this.db = db;
        }

        public bool DoesUserExist(int userId)
        {
            // connect to db
            if (!db.ConnectToDataBase())
            {
                throw new Exception("Failed to connect");
            }

            return true;
        }

        public int GetUserId()
        {
            // connect to db
            if (!db.ConnectToDataBase())
            {
                throw new Exception("Failed to connect");
            }

            return 55;
        }

        public void CreateNewUser(int userId)
        {
            if (DoesUserExist(userId) == true)
            {
                throw new Exception("User Exists");
            }

            int newUserId = GetUserId();

            // insert new userID into Db
            int newId = db.InsertNewUser(userId);

            if (newId < 0)
            {
                throw new Exception("negative");
            }
        }

    }
}
