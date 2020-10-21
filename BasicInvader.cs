namespace TreehouseDefense
{
    class BasicInvader : Invader
    {

        public override int Health { get; protected set; }

        public BasicInvader(Path path) : base(path)
        {

        }
    }
}