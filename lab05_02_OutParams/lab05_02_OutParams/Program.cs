//Ex 38
//bool AuthenticateUser(string username, string password)
//{
//	if (username == "admin" && password == "1234")
//	{
//		return true;
//	}
//	else
//	{
//		return false;
//	}
//}

//if (AuthenticateUser("admin", "1234"))
//{
//    Console.WriteLine($"Login successful.");
//}
//else
//{
//    Console.WriteLine($"Error: Invalid credentials.");
//}

//Ex 39

//string roleResult = "";
//DateTime lastLoginResult = DateTime.MinValue;
//string roleResult;
//DateTime lastLoginResult;
bool AuthenticateUser(string username, string password, out string role, out DateTime lastLogin)
{
    if (username == "admin" && password == "1234")
    {
        role = "Administrator";
        lastLogin = DateTime.Now;
        return true;
    }
    else
    {
        role = "Unknown";
        lastLogin = DateTime.MinValue;
        return false;
    }
}

//if (AuthenticateUser("admin", "1234", out string roleResult, out DateTime lastLoginResult))
if (AuthenticateUser("admin", "1234", out var roleResult, out var lastLoginResult))
{
    Console.WriteLine($"Login successful. Role: {roleResult}, Last login: {lastLoginResult}");
}
else
{
    Console.WriteLine($"Error: Invalid credentials.");
}