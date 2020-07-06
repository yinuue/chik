namespace Def
{
    public static class AppDef
    {
        public enum CardState
        {
            InDeck,
            InHand,
            InField
        }

        public enum CardType
        {
            Action,
            Attack,
            Skill,
            Counter,
            Status,
        }
    }
}