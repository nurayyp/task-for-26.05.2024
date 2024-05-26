using System.Collections.Generic;

namespace task5
{
    internal class SocialMedia
    {
        Dictionary<string, List<string>> Friends {  get; set; }
        public SocialMedia() 
        { 
            Friends = new Dictionary<string, List<string>>();
        }
        public void AddFriend(string friendName, List<string> friendFollowers)
        {
            Friends.Add(friendName, friendFollowers);
        }
        public void RemoveFriend(string friendName)
        {
            Friends.Remove(friendName);
        }
        public void GetAllFriendsByUsername(string username)
        {
            foreach (var friend in Friends[username])
            {
                Console.WriteLine($"{friend}");
            }
        }
    }
}
