namespace LealPassword.DataBases
{
    [System.Serializable]
    internal sealed class PersonalInfo
    {
        internal PersonalInfo(string name, string cellphone, string email, string rg, string cpf)
        {
            Name = name;
            Cellphone = cellphone;
            Email = email;
            Rg = rg;
            Cpf = cpf;
        }

        internal string Name { get; set; }
        internal string Cellphone { get; set; }
        internal string Email { get; set; }
        internal string Rg { get; set; }
        internal string Cpf { get; set; }
    }
}