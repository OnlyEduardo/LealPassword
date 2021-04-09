using System;
using System.Collections.Generic;
using System.Drawing;

namespace LealPassword.DataBases
{
    [Serializable]
    internal sealed class DataBase
    {
        internal DataBase(string name, Hash hash, List<Register> regs)
            : this(name, hash, regs, new List<Note>(), new PersonalInfo(), new List<Card>()) { }

        internal DataBase(string name, Hash hash, PersonalInfo personalInfo)
            : this(name, hash, new List<Register>(), new List<Note>(), personalInfo, new List<Card>()) { }

        internal DataBase(string name, Hash hash, List<Register> registers, List<Note> notes, PersonalInfo personalInfo, List<Card> cards)
        {
            Name = name;
            Hash = hash;
            Registers = registers;
            Notes = notes;
            PersonalInfo = personalInfo;
            Cards = cards;
            BackgroundColor = Color.White;
            ForegroundColor = Color.Black;
            AutoSave = false;
        }

        internal string Name { get; set; }
        internal Hash Hash { get; }
        internal List<Register> Registers { get; }
        internal List<Note> Notes { get; }
        internal PersonalInfo PersonalInfo { get; }
        internal List<Card> Cards { get; }
        internal Color BackgroundColor { get; set; }
        internal Color ForegroundColor { get; set; }
        internal bool AutoSave { get; set; }

        public override string ToString() => Name;
    }
}
