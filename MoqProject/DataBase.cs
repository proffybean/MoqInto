using System;

namespace MoqProject
{
    internal class DataBase : IDataBase
    {
        public bool ConnectToDataBase()
        {
            return false;
        }

        public int InsertNewUser(int userId)
        {
            return 100;
        }
    }
}