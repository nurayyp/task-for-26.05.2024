using task5;

public static class Program
{
    public static void Main(string[] args)
    {
        SocialMedia instagram = new SocialMedia();
        instagram.AddFriend("nuray2006", new List<string> { "ayka", "nez.rin" });
        instagram.AddFriend("cllova", new List<string> { "khanum", "asdli." });
        instagram.AddFriend("a.xnhmdv", new List<string> { "xanlarr", "esed.zda" });
        instagram.RemoveFriend("cllova");
        instagram.GetAllFriendsByUsername("nuray2006");
    }
}