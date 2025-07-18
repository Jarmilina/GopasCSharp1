UserManager um1 = new UserManager();
um1.ConnectUser("Alice");
um1.ConnectUser("Bob");
um1.ConnectUser("Charlie");

um1.DisconnectUser("Alice");
um1.DisconnectUser("Joe");

UserManager um2 = new UserManager();
um2.ConnectUser("Paul");

//int totalActiveUsers = um2.GetActiveUsersCount();
int totalActiveUsers = UserManager.GetActiveUsersCount();
Console.WriteLine($"Total active users: {totalActiveUsers}");

class UserManager
{
    private List<string> connectedUsers = new List<string>();
    private static int activeUserCount = 0;

    public void ConnectUser(string userName)
    {
        this.connectedUsers.Add(userName);
        UserManager.activeUserCount++;
        Console.WriteLine("User {0} has logged in. Active users: {1}", userName, UserManager.activeUserCount);

    }

    public void DisconnectUser(string userName)
    {
        if (this.connectedUsers.Contains(userName))
        {
            this.connectedUsers.Remove(userName);
            UserManager.activeUserCount--;
            Console.WriteLine("User {0} has logged out. Active users: {1}", userName, UserManager.activeUserCount); 
        }
        else
        {
            Console.WriteLine($"{userName} was not connected. Active users: {UserManager.activeUserCount}");
        }
    }

    //public int GetActiveUsersCount()
    public static int GetActiveUsersCount()
    {
        return UserManager.activeUserCount;
    }
}
