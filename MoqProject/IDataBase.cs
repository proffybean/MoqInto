using System;

namespace MoqProject
{
    public interface IDataBase
    {
        bool ConnectToDataBase();

        int InsertNewUser(int userId);
    }
}