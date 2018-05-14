namespace RedditPost
{
    class RrditPost {

        private string _username;
        private int _votes;
        private string _post = "Empty text.";

        public string Post {
            get { return _post; }

            set { _post = value; }
        }


        public RrditPost(string alias)
        {
            _username = alias;
        }

        public void Upvote() {
            _votes++;
        }

        public void Downvote() {
            _votes--;
        }

        public int GetVotes() {
            return _votes;
        }

        public string GetUserName() {
            return _username;
        }
    }
}
