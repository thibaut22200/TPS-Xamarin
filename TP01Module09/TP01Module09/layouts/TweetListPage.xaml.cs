using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using TP01Module09.models;
using TP01Module09.services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP01Module09.layouts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TweetListPage : ContentPage
    {
        ITwitterService twitterService = new TwitterService();
        ObservableCollection<Tweet> tweets = new ObservableCollection<Tweet>();
        public TweetListPage()
        {
            InitializeComponent();
            List<Tweet> tweets = twitterService.getTweets();

            foreach (Tweet tweet in tweets)
            {
                this.tweets.Add(tweet);
            }
            this.tweetsList.ItemsSource = tweets;
        }
    }
}