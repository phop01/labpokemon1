using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labpokemon
{
    public class pokemon
    {

        protected int id;
        protected string name;
        protected Image pic;
        protected int level;
        protected pokemonType type;
        protected pokemonAbilities Abilities;
        protected int HP;
        protected int Att;
        protected int Def;
        protected int speed;
        protected int sdef;
        protected int satt;

        public string Name()
        {
            return name;
        }
        public Image picture()
        {
            return pic;
        }
    }
    public enum pokemonType
    {
        grass, poison, electr, Dragon, Flying, Fire, Fighting, Psychic, Fairy, Steel, Water, Ground, Normal
    }
    public enum pokemonAbilities
    {
        overgrow, chlorophyII, Multitype, Torrent, Damp, Steadfast, Inner_Focus, Justified, Synchronize, Trace, Telepathy, Blaze, Speed_Boost, Air_Lock, Static, Lightning_Rod
    }
}
