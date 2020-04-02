using System.Collections.Generic;
using TP01Module09.models;

namespace TP01Module09.services
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

        public List<Tweet> getTweets()
        {
            var tweets = new List<Tweet>();

            tweets.Add(new Tweet() {
                CreatedAt = "Le 25/02/2019 à 13h00",
                Text = "Charles a mangé de la bolognaise. Charles a mangé de la bolognaise. Charles a mangé de la bolognaise." +
                "Charles a mangé de la bolognaise. Charles a mangé de la bolognaise. Charles a mangé de la bolognaise." +
                "Charles a mangé de la bolognaise. Charles a mangé de la bolognaise. Charles a mangé de la bolognaise." +
                "Charles a mangé de la bolognaise. Charles a mangé de la bolognaise. Charles a mangé de la bolognaise." +
                "Charles a mangé de la bolognaise. Charles a mangé de la bolognaise. Charles a mangé de la bolognaise." +
                "Charles a mangé de la bolognaise. Charles a mangé de la bolognaise. Charles a mangé de la bolognaise. ",
                Username = "Twitter API", 
                UserPseudo = "twitterapi" 
            });
            tweets.Add(new Tweet() {
                CreatedAt = "Le 26/02/2019 à 13h00",
                Text = "Charles a mangé de la carbonara",
                Username = "Twitter API",
                UserPseudo = "twitterapi"
            });
            tweets.Add(new Tweet() {
                CreatedAt = "Le 27/02/2019 à 13h00",
                Text = "Charles a mangé de la pâté pour chat",
                Username = "Twitter API",
                UserPseudo = "twitterapi"
            });
            tweets.Add(new Tweet()
            {
                CreatedAt = "Le 25/02/2019 à 13h00",
                Text = "Charles a mangé de la bolognaise. Charles a mangé de la bolognaise. Charles a mangé de la bolognaise." +
                "Charles a mangé de la bolognaise. Charles a mangé de la bolognaise. Charles a mangé de la bolognaise." +
                "Charles a mangé de la bolognaise. Charles a mangé de la bolognaise. Charles a mangé de la bolognaise." +
                "Charles a mangé de la bolognaise. Charles a mangé de la bolognaise. Charles a mangé de la bolognaise." +
                "Charles a mangé de la bolognaise. Charles a mangé de la bolognaise. Charles a mangé de la bolognaise." +
                "Charles a mangé de la bolognaise. Charles a mangé de la bolognaise. Charles a mangé de la bolognaise. ",
                Username = "Twitter API",
                UserPseudo = "twitterapi"
            });
            tweets.Add(new Tweet()
            {
                CreatedAt = "Le 25/02/2019 à 13h00",
                Text = "Charles a mangé de la bolognaise. Charles a mangé de la bolognaise. Charles a mangé de la bolognaise." +
                "Charles a mangé de la bolognaise. Charles a mangé de la bolognaise. Charles a mangé de la bolognaise." +
                "Charles a mangé de la bolognaise. Charles a mangé de la bolognaise. Charles a mangé de la bolognaise." +
                "Charles a mangé de la bolognaise. Charles a mangé de la bolognaise. Charles a mangé de la bolognaise." +
                "Charles a mangé de la bolognaise. Charles a mangé de la bolognaise. Charles a mangé de la bolognaise." +
                "Charles a mangé de la bolognaise. Charles a mangé de la bolognaise. Charles a mangé de la bolognaise. ",
                Username = "Twitter API",
                UserPseudo = "twitterapi"
            });
            tweets.Add(new Tweet()
            {
                CreatedAt = "Le 25/02/2019 à 13h00",
                Text = "Charles a mangé de la bolognaise. Charles a mangé de la bolognaise. Charles a mangé de la bolognaise." +
                "Charles a mangé de la bolognaise. Charles a mangé de la bolognaise. Charles a mangé de la bolognaise." +
                "Charles a mangé de la bolognaise. Charles a mangé de la bolognaise. Charles a mangé de la bolognaise." +
                "Charles a mangé de la bolognaise. Charles a mangé de la bolognaise. Charles a mangé de la bolognaise." +
                "Charles a mangé de la bolognaise. Charles a mangé de la bolognaise. Charles a mangé de la bolognaise." +
                "Charles a mangé de la bolognaise. Charles a mangé de la bolognaise. Charles a mangé de la bolognaise. ",
                Username = "Twitter API",
                UserPseudo = "twitterapi"
            });

            return tweets;
        }
    }
}
