namespace MoqProject
{
    public interface IDbAccessor
    {
        int GetUserId();

        bool DoesUserExist(int userId);

        void CreateNewUser(int userId);
    }
}