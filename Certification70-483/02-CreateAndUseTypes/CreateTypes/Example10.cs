using System.Collections.Generic;

namespace Certification70_483._02_CreateAndUseTypes.CreateTypes
{
    /// <summary>
    /// Creating a collection such as a Deck class
    /// </summary>
    public static class Example10
    {
        public static void Start()
        {
            var deck = new Deck();
        }
    }

    class Card { }
    class Deck
    {
        public ICollection<Card> Cards { get; private set; }
    }
}
