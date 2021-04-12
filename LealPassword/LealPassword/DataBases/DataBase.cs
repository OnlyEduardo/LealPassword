using System;
using System.Collections.Generic;
using System.Drawing;

namespace LealPassword.DataBases
{
    [Serializable]
    internal sealed class DataBase
    {
        internal DataBase(string name, Hash hash, List<Register> regs)
            : this(name, hash, regs, new PersonalInfo(), new List<Card>()) { }

        internal DataBase(string name, Hash hash, PersonalInfo personalInfo)
            : this(name, hash, new List<Register>(), personalInfo, new List<Card>()) { }

        internal DataBase(string name, Hash hash, List<Register> registers, PersonalInfo personalInfo, List<Card> cards)
        {
            Name = name;
            Hash = hash;
            Registers = registers;
            PersonalInfo = personalInfo;
            Cards = cards;
            BackgroundColor = Color.White;
            ForegroundColor = Color.Black;
            SystemTray = false;
            AutoSave = false;
        }

        internal string Name { get; set; }
        internal Hash Hash { get; }
        internal List<Register> Registers { get; }
        internal PersonalInfo PersonalInfo { get; }
        internal List<Card> Cards { get; }
        internal Color BackgroundColor { get; set; }
        internal Color ForegroundColor { get; set; }
        internal bool SystemTray { get; set; }
        internal bool AutoSave { get; set; }

        public override string ToString() => Name;
    }
}
