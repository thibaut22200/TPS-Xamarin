using System;
using System.Collections.Generic;
using System.Text;
using TP01Module08.models;

namespace TP01Module08.services
{
    interface ITwitterService
    {
        bool authenticate(String utilisateur, String password);
        List<Tweet> getTweets(String chaine);
    }
}
