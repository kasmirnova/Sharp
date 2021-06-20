using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleChat
{
    public class ChatManager
    {
        public List<User> _activeUsers = new List<User>();

        public event Action<int> OnUserNumberChanged;
        public event Action<string> OnLog;
        
        public void AddUser(User user)
        {
            if (_activeUsers.Contains(user))
                return;

            // YOUR CODE GOES HERE (Add connections)

            foreach (User aUser in _activeUsers)
            {
                user.OnSent += aUser.Receive;
                aUser.OnSent += user.Receive;
            }

            _activeUsers.Add(user);
        }

        public void RemoveUser(User user)
        {
            if (!_activeUsers.Contains(user))
                return;

            // YOUR CODE GOES HERE (Delete connections)

            foreach (User aUser in _activeUsers)
            {
                user.OnSent -= aUser.Receive;
                aUser.OnSent -= user.Receive;
            }

            _activeUsers.Remove(user);

        }

        public void log(string message)
        {
            OnLog?.Invoke(message);
        }

        public void userNumberChanged(int count)
        {
            OnUserNumberChanged?.Invoke(count);
        }
    }
}
