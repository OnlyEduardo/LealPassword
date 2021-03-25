namespace LealPassword.DataBases
{
    [System.Serializable]
    internal sealed class Note
    {
        internal Note(string name, string text)
        {
            Name = name;
            Text = text;
        }

        internal string Name { get; set; }
        internal string Text { get; set; }

        public override string ToString() => Name;
    }
}