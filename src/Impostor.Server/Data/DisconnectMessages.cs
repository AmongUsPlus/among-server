namespace Impostor.Server.Data
{
    public static class DisconnectMessages
    {
        public const string Error = "There was an internal server error. " +
                                    "AmongUsPlus servers have gone offline." +
                                    "Please report the issue on our discord if it keeps happening" +
                                    "https://discord.amongus.plus";

        public const string Destroyed = "The game you tried to join is being destroyed. " +
                                        "Please create a new game.";

        public const string NotImplemented = "This feature has not been added yet.";

        public const string UsernameLength = "Your username is too long, please make it shorter.";
    }
}
