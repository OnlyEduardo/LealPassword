using System;
using System.Collections.Generic;

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
        }

        internal string Name { get; set; }
        internal Hash Hash { get; }
        internal List<Register> Registers { get; }
        internal List<Note> Notes { get; }
        internal PersonalInfo PersonalInfo { get; }
        internal List<Card> Cards { get; }

        public override string ToString() => Name;
    }
}
