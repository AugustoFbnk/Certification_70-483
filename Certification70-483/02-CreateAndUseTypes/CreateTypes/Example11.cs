using System.Collections.Generic;

namespace Certification70_483._02_CreateAndUseTypes.CreateTypes
{
    /// <summary>
    /// Adding a constructor to your type
    /// </summary>
    public static class Example11
    {
        public static void Start()
        {
            var deck2 = new Deck2(50);
        }
    }

    class Card2 { }

    class Deck2
    {
        private int _maximumNumberOfCards;
        public List<Card2> Cards { get; set; }
        public Deck2(int maximumNumberOfCards)
        {
            _maximumNumberOfCards = maximumNumberOfCards;
            Cards = new List<Card2>();
        }
    }
}
