using Def;

namespace Repository
{
    public static class CardRepository
    {
        
        
        // ================================================
        // method
        // ================================================
        public static CardModel BuildCard(int id)
        {
            switch (id)
            {
                case 1:
                    return CreatePunch();
                default:
                    return null;
            }
        }

        private static CardModel CreatePunch()
        {
            return new CardModel(1, AppDef.CardType.Action, PunchEffect);
        }

        private static void PunchEffect()
        {
            
        }
    }
}