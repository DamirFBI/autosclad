namespace AutoSclad
{
    class CurrentUser
    {
        private static CurrentUser instance;

        public int id;

        public int type;

        private CurrentUser()
        { }

        public static CurrentUser getInstance()
        {
            if (instance == null)
            {
                instance = new CurrentUser();
            }
            return instance;
        }
    }
}