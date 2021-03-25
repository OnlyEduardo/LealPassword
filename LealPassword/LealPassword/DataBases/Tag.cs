namespace LealPassword.DataBases
{
    [System.Serializable]
    internal class Tag
    {
        internal Tag(string name)
        {
            Name = name;
        }

        internal string Name { get; set; }

        public override string ToString() => Name;
    }
}