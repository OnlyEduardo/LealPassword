namespace LealPassword.DataBases
{
    [System.Serializable]
    internal sealed class Register
    {
        internal Register(string name, string user, string email, string pass, Tag tag)
        {
            Name = name;
            User = user;
            Email = email;
            Pass = pass;
            Tag = tag;
        }

        internal string Name { get; set; }
        internal string User { get; set; }
        internal string Email { get; set; }
        internal string Pass { get; set; }
        internal Tag Tag { get; }
    }
}