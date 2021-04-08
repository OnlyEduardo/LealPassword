namespace LealPassword.DataBases
{
    [System.Serializable]
    internal sealed class PersonalInfo
    {
        internal PersonalInfo() 
            : this("Nome completo", "email.email@email.com", "999999999", "99999999999", "") { }
             
        internal PersonalInfo(string name, string email, string rg, string cpf, string imagePath)
        {
            Name = name;
            Email = email;
            Rg = rg;
            Cpf = cpf;
            ImagePath = imagePath;
        }

        internal string Name { get; set; }
        internal string Email { get; set; }
        internal string Rg { get; set; }
        internal string Cpf { get; set; }
        internal string ImagePath { get; set; }
    }
}