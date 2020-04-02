using System;
using System.Collections.Generic;
using TP01Module09.models;

namespace TP01Module09.services
{
    interface ITwitterService
    {
        bool authenticate(String utilisateur, String password);
        List<Tweet> getTweets();
    }
}
