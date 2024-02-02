using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labpokemon
{
    public class pikachu : pokemon
    {
        public pikachu()
        {
            name = "pikachu";
            id = 25;
            level = 100;
            type = pokemonType.electr;

        }
    }
    public class Rayquaza : pokemon
    {
        public Rayquaza()
        {
            name = "Rayquaza";
            id = 384;
            level = 100;
            type = pokemonType.Dragon;
            type = pokemonType.Flying;
        }
    }
    public class Blaziken : pokemon
    {
        public Blaziken()
        {
            name = "Blaziken";
            id = 257;
            level = 100;
            type = pokemonType.Fire;
            type = pokemonType.Fighting;
        }
    }
    public class Gardevoir : pokemon
    {
        public Gardevoir()
        {
            name = "Gardevoir";
            id = 282;
            level = 100;
            type = pokemonType.Psychic;
            type = pokemonType.Fairy;
        }
    }
    public class Lucario : pokemon
    {
        public Lucario()
        {
            name = "Lucario";
            id = 448;
            level = 100;
            type = pokemonType.Fighting;
            type = pokemonType.Steel;
        }
    }
    public class Swampert : pokemon
    {
        public Swampert()
        {
            name = "Swampert";
            id = 260;
            level = 100;
            type = pokemonType.Water;
            type = pokemonType.Ground;
        }
    }
    public class Arceus : pokemon
    {
        public Arceus()
        {
            name = "Arceus";
            id = 493;
            level = 100;
            type = pokemonType.Normal;

        }
    }
}
