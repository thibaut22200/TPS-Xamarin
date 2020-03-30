using System;
using System.Collections.Generic;
using System.Text;
using TP01Module07.models;

namespace TP01Module07.services
{
    interface ITwitterService
    {
        bool authenticate(String utilisateur, String password);
        List<Tweet> getTweets(String chaine);
    }
}
