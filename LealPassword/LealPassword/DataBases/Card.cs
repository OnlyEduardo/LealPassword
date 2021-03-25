using System;

namespace LealPassword.DataBases
{
    [Serializable]
    internal sealed class Card
    {
        internal Card(string cardName, string onwerName, string number, DateTime validDate, string cvv)
        {
            CardName = cardName;
            OnwerName = onwerName;
            Number = number;
            ValidDate = validDate;
            Cvv = cvv;
        }

        internal string CardName { get; set; }
        internal string OnwerName { get; set; }
        internal string Number { get; set; }
        internal DateTime ValidDate { get; }
        internal string Cvv { get; set; }
        
        public override string ToString() => $"{CardName} - Final {Number.Split('.')[3]}";
    }
}