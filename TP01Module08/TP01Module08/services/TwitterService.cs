using System;
using System.Collections.Generic;
using System.Text;
using TP01Module08.models;

namespace TP01Module08.services
{
    class TwitterService : ITwitterService
    {
        public bool authenticate(string utilisateur, string password)
        {
            if ("greg".Equals(utilisateur) && "password".Equals(password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Tweet> getTweets(string chaine)
        {
            var tweets = new List<Tweet>();

            tweets.Add(new Tweet() {
                Id = "0000000001",
                CreatedAt = "Thu Apr 06 13:00:00 +0000 2019",
                Text = "Charles a mangé de la bolognaise", 
                UserId = "000001", 
                Username = "Twitter API", 
                UserPseudo = "twitterapi" 
            });
            tweets.Add(new Tweet()
            {
                Id = "0000000002",
                CreatedAt = "Fri Apr 07 13:00:00 +0000 2019",
                Text = "Charles a mangé de la carbonara",
                UserId = "000001",
                Username = "Twitter API",
                UserPseudo = "twitterapi"
            });
            tweets.Add(new Tweet()
            {
                Id = "0000000002",
                CreatedAt = "Sat Apr 08 13:00:00 +0000 2019",
                Text = "Charles a mangé de la pâté pour chat",
                UserId = "000001",
                Username = "Twitter API",
                UserPseudo = "twitterapi"
            });

            return tweets;
        }
    }
}
