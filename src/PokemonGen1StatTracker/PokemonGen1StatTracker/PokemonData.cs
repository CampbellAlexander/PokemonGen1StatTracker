﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGen1StatTracker
{
    internal static class PokemonData
    {
        internal enum Types
        {
            NONE,
            NORMAL,
            FIRE,
            WATER,
            ELECTRIC,
            GRASS,
            ICE,
            FIGHTING,
            POISON,
            GROUND,
            FLYING,
            PSYCHIC,
            BUG,
            ROCK,
            GHOST,
            DRAGON
        }

        internal static string TypeToString(Types type)
        {
            switch(type)
            {
                case Types.NORMAL: return "Normal";
                case Types.FIRE: return "Fire";
                case Types.WATER: return "Water";
                case Types.ELECTRIC: return "Electric";
                case Types.GRASS: return "Grass";
                case Types.ICE: return "Ice";
                case Types.FIGHTING: return "Fighting";
                case Types.POISON: return "Poison";
                case Types.GROUND: return "Ground";
                case Types.FLYING: return "Flying";
                case Types.PSYCHIC: return "Psychic";
                case Types.BUG: return "Bug";
                case Types.ROCK: return "Rock";
                case Types.GHOST: return "Ghost";
                case Types.DRAGON: return "Dragon";
                default: return "";
            }
        }

        internal static readonly Types[][] AllTypes = new Types[][]
        {
            //0 - No Pokemon
            new Types[] { Types.NONE, Types.NONE },
            //1 - Bulbasaur                      
            new Types[] { Types.GRASS, Types.POISON },
            //2 - Ivysaur
            new Types[] { Types.GRASS, Types.POISON },
            //3 - Venusaur
            new Types[] { Types.GRASS, Types.POISON },
            //4 - Charmander
            new Types[] { Types.FIRE, Types.NONE },
            //5 - Charmeleon
            new Types[] { Types.FIRE, Types.NONE },
            //6 - Charizard
            new Types[] { Types.FIRE, Types.FLYING },
            //7 - Squirtle
            new Types[] { Types.WATER, Types.NONE },
            //8 - Wartortle
            new Types[] { Types.WATER, Types.NONE },
            //9 - Blastoise
            new Types[] { Types.WATER, Types.NONE },
            //10 - Caterpie
            new Types[] { Types.BUG, Types.NONE },
            //11 - Metapod
            new Types[] { Types.BUG, Types.NONE },
            //12 - Butterfree
            new Types[] { Types.BUG, Types.FLYING },
            //13 - Weedle
            new Types[] { Types.BUG, Types.POISON },
            //14 - Kakuna
            new Types[] { Types.BUG, Types.POISON },
            //15 - Beedrill
            new Types[] { Types.BUG, Types.POISON },
            //16 - Pidgey
            new Types[] { Types.NORMAL, Types.FLYING },
            //17 - Pidgeotto
            new Types[] { Types.NORMAL, Types.FLYING },
            //18 - Pidgeot
            new Types[] { Types.NORMAL, Types.FLYING },
            //19 - Rattata
            new Types[] { Types.NORMAL, Types.NONE },
            //20 - Raticate
            new Types[] { Types.NORMAL, Types.NONE },
            //21 - Spearow
            new Types[] { Types.NORMAL, Types.FLYING },
            //22 - Fearow
            new Types[] { Types.NORMAL, Types.FLYING },
            //23 - Ekans
            new Types[] { Types.POISON, Types.NONE },
            //24 - Arbok
            new Types[] { Types.POISON, Types.NONE },
            //25 - Pikachu
            new Types[] { Types.ELECTRIC, Types.NONE },
            //26 - Raichu
            new Types[] { Types.ELECTRIC, Types.NONE },
            //27 - Sandshrew
            new Types[] { Types.GROUND, Types.NONE },
            //28 - Sandslash
            new Types[] { Types.GROUND, Types.NONE },
            //29 - Nidoran Female
            new Types[] { Types.POISON, Types.NONE },
            //30 - Nidorina
            new Types[] { Types.POISON, Types.NONE },
            //31 - Nidoqueen
            new Types[] { Types.POISON, Types.GROUND },
            //32 - Nidoran Male
            new Types[] { Types.POISON, Types.NONE },
            //33 - Nidorino
            new Types[] { Types.POISON, Types.NONE },
            //34 - Nidoking
            new Types[] { Types.POISON, Types.GROUND },
            //35 - Clefairy
            new Types[] { Types.NORMAL, Types.NONE },
            //36 - Clefable
            new Types[] { Types.NORMAL, Types.NONE },
            //37 - Vulpix
            new Types[] { Types.FIRE, Types.NONE },
            //38 - Ninetails
            new Types[] { Types.FIRE, Types.NONE },
            //39 - Jigglypuff
            new Types[] { Types.NORMAL, Types.NONE },
            //40 - Wigglytuff
            new Types[] { Types.NORMAL, Types.NONE },
            //41 - Zubat
            new Types[] { Types.POISON, Types.FLYING },
            //42 - Golbat
            new Types[] { Types.POISON, Types.FLYING },
            //43 - Oddish
            new Types[] { Types.GRASS, Types.POISON },
            //44 - Gloom
            new Types[] { Types.GRASS, Types.POISON },
            //45 - Vileplume
            new Types[] { Types.GRASS, Types.POISON },
            //46 - Paras
            new Types[] { Types.BUG, Types.GRASS },
            //47 - Parasect
            new Types[] { Types.BUG, Types.GRASS },
            //48 - Venonat
            new Types[] { Types.BUG, Types.POISON },
            //49 - Venomoth
            new Types[] { Types.BUG, Types.POISON },
            //50 - Diglett
            new Types[] { Types.GROUND, Types.NONE },
            //51 - Dugtrio
            new Types[] { Types.GROUND, Types.NONE },
            //52 - Meowth
            new Types[] { Types.NORMAL, Types.NONE },
            //53 - Persian
            new Types[] { Types.NORMAL, Types.NONE },
            //54 - Psyduck
            new Types[] { Types.WATER, Types.NONE },
            //55 - Golduck
            new Types[] { Types.WATER, Types.NONE },
            //56 - Mankey
            new Types[] { Types.FIGHTING, Types.NONE },
            //57 - Primeape
            new Types[] { Types.FIGHTING, Types.NONE },
            //58 - Growlithe
            new Types[] { Types.FIRE, Types.NONE },
            //59 - Arcanine
            new Types[] { Types.FIRE, Types.NONE },
            //60 - Poliwag
            new Types[] { Types.WATER, Types.NONE },
            //61 - Poliwhirl
            new Types[] { Types.WATER, Types.NONE },
            //62 - Poliwrath
            new Types[] { Types.WATER, Types.FIGHTING },
            //63 - Abra
            new Types[] { Types.PSYCHIC, Types.NONE },
            //64 - Kadabra
            new Types[] { Types.PSYCHIC, Types.NONE },
            //65 - Alakazam
            new Types[] { Types.PSYCHIC, Types.NONE },
            //66 - Machop
            new Types[] { Types.FIGHTING, Types.NONE },
            //67 - Machoke
            new Types[] { Types.FIGHTING, Types.NONE },
            //68 - Machamp
            new Types[] { Types.FIGHTING, Types.NONE },
            //69 - Bellsprout
            new Types[] { Types.GRASS, Types.POISON },
            //70 - Weepinbell
            new Types[] { Types.GRASS, Types.POISON },
            //71 - Victreebel
            new Types[] { Types.GRASS, Types.POISON },
            //72 - Tentacool
            new Types[] { Types.WATER, Types.POISON },
            //73 - Tentacruel
            new Types[] { Types.WATER, Types.POISON },
            //74 - Geodude
            new Types[] { Types.ROCK, Types.GROUND },
            //75 - Graveler
            new Types[] { Types.ROCK, Types.GROUND },
            //76 - Golem
            new Types[] { Types.ROCK, Types.GROUND },
            //77 - Ponyta
            new Types[] { Types.FIRE, Types.NONE },
            //78 - Rapidash
            new Types[] { Types.FIRE, Types.NONE },
            //79 - Slowpoke
            new Types[] { Types.WATER, Types.PSYCHIC },
            //80 - Slowbrow
            new Types[] { Types.WATER, Types.PSYCHIC },
            //81 - Magnemite
            new Types[] { Types.ELECTRIC, Types.NONE },
            //82 - Magneton
            new Types[] { Types.ELECTRIC, Types.NONE },
            //83 - Farfetch'd
            new Types[] { Types.NORMAL, Types.FLYING },
            //84 - Doduo
            new Types[] { Types.NORMAL, Types.FLYING },
            //85 - Dodrio
            new Types[] { Types.NORMAL, Types.FLYING },
            //86 - Seel
            new Types[] { Types.WATER, Types.NONE },
            //87 - Dewgong
            new Types[] { Types.WATER, Types.ICE },
            //88 - Grimer
            new Types[] { Types.POISON, Types.NONE },
            //89 - Muk
            new Types[] { Types.POISON, Types.NONE },
            //90 - Shellder
            new Types[] { Types.WATER, Types.NONE },
            //91 - Cloyster
            new Types[] { Types.WATER, Types.ICE },
            //92 - Gastly
            new Types[] { Types.GHOST, Types.POISON },
            //93 - Haunter
            new Types[] { Types.GHOST, Types.POISON },
            //94 - Gengar
            new Types[] { Types.GHOST, Types.POISON },
            //95 - Onix
            new Types[] { Types.ROCK, Types.GROUND },
            //96 - Drowzee
            new Types[] { Types.PSYCHIC, Types.NONE },
            //97 - Hypno
            new Types[] { Types.PSYCHIC, Types.NONE },
            //98 - Krabby
            new Types[] { Types.WATER, Types.NONE },
            //99 - Kingler
            new Types[] { Types.WATER, Types.NONE },
            //100 - Voltorb
            new Types[] { Types.ELECTRIC, Types.NONE },
            //101 - Electrode
            new Types[] { Types.ELECTRIC, Types.NONE },
            //102 - Exeggcute
            new Types[] { Types.GRASS, Types.PSYCHIC },
            //103 - Exeggutor
            new Types[] { Types.GRASS, Types.PSYCHIC },
            //104 - Cubone
            new Types[] { Types.GROUND, Types.NONE },
            //105 - Marowak
            new Types[] { Types.GROUND, Types.NONE },
            //106 - Hitmonlee
            new Types[] { Types.FIGHTING, Types.NONE },
            //107 - Hitmonchan
            new Types[] { Types.FIGHTING, Types.NONE },
            //108 - Lickitung
            new Types[] { Types.NORMAL, Types.NONE },
            //109 - Koffing
            new Types[] { Types.POISON, Types.NONE },
            //110 - Weezing
            new Types[] { Types.POISON, Types.NONE },
            //111 - Rhyhorn
            new Types[] { Types.GROUND, Types.ROCK },
            //112 - Rhydon
            new Types[] { Types.GROUND, Types.ROCK },
            //113 - Chansey
            new Types[] { Types.NORMAL, Types.NONE },
            //114 - Tangela
            new Types[] { Types.GRASS, Types.NONE },
            //115 - Kangaskhan
            new Types[] { Types.NORMAL, Types.NONE },
            //116 - Horsea
            new Types[] { Types.WATER, Types.NONE },
            //117 - Seadra
            new Types[] { Types.WATER, Types.NONE },
            //118 - Goldeen
            new Types[] { Types.WATER, Types.NONE },
            //119 - Seaking
            new Types[] { Types.WATER, Types.NONE },
            //120 - Staryu
            new Types[] { Types.WATER, Types.NONE },
            //121 - Starmie
            new Types[] { Types.WATER, Types.PSYCHIC },
            //122 - Mr. Mime
            new Types[] { Types.PSYCHIC, Types.NONE },
            //123 - Scyther
            new Types[] { Types.BUG, Types.FLYING },
            //124 - Jynx
            new Types[] { Types.ICE, Types.PSYCHIC },
            //125 - Electabuzz
            new Types[] { Types.ELECTRIC, Types.NONE },
            //126 - Magmar
            new Types[] { Types.FIRE, Types.NONE },
            //127 - Pinsir
            new Types[] { Types.BUG, Types.NONE },
            //128 - Tauros
            new Types[] { Types.NORMAL, Types.NONE },
            //129 - Magikarp
            new Types[] { Types.WATER, Types.NONE },
            //130 - Gyarados
            new Types[] { Types.WATER, Types.FLYING },
            //131 - Lapras
            new Types[] { Types.WATER, Types.ICE },
            //132 - Ditto
            new Types[] { Types.NORMAL, Types.NONE },
            //133 - Eevee
            new Types[] { Types.NORMAL, Types.NONE },
            //134 - Vaporeon
            new Types[] { Types.WATER, Types.NONE },
            //135 - Jolteon
            new Types[] { Types.ELECTRIC, Types.NONE },
            //136 - Flareon
            new Types[] { Types.FIRE, Types.NONE },
            //137 - Porygon
            new Types[] { Types.NORMAL, Types.NONE },
            //138 - Omanyte
            new Types[] { Types.ROCK, Types.WATER },
            //139 - Omastar
            new Types[] { Types.ROCK, Types.WATER },
            //140 - Kabuto
            new Types[] { Types.ROCK, Types.WATER },
            //141 - Kabutops
            new Types[] { Types.ROCK, Types.WATER },
            //142 - Aerodactyl
            new Types[] { Types.ROCK, Types.FLYING },
            //143 - Snorlax
            new Types[] { Types.NORMAL, Types.NONE },
            //144 - Articuno
            new Types[] { Types.ICE, Types.FLYING },
            //145 - Zapdos
            new Types[] { Types.ELECTRIC, Types.FLYING },
            //146 - Moltres
            new Types[] { Types.FIRE, Types.FLYING },
            //147 - Dratini
            new Types[] { Types.DRAGON, Types.NONE },
            //148 - Dragonair
            new Types[] { Types.DRAGON, Types.NONE },
            //149 - Dragonite
            new Types[] { Types.DRAGON, Types.FLYING },
            //150 - Mewtwo
            new Types[] { Types.PSYCHIC, Types.NONE },
            //151 - Mew
            new Types[] { Types.PSYCHIC, Types.NONE }
        };

        internal static readonly string[] Species = new string[]
        {
            "Bulbasaur", // 1
            "Ivysaur",
            "Venusaur",
            "Charmander",
            "Charmeleon",
            "Charizard",
            "Squirtle",
            "Wartortle",
            "Blastoise",
            "Caterpie", //10
            "Metapod",
            "Butterfree",
            "Weedle",
            "Kakuna",
            "Beedrill",
            "Pidgey",
            "Pidgeotto",
            "Pidgeot",
            "Rattata",
            "Raticate", //20
            "Spearow",
            "Fearow",
            "Ekans",
            "Arbok",
            "Pikachu",
            "Raichu",
            "Sandshrew",
            "Sandslash",
            "Nidoran Female",
            "Nidorina",  //30
            "Nidoqueen",
            "Nidoran Male",
            "Nidorino",
            "Nidoking",
            "Clefairy",
            "Clefable",
            "Vulpix",
            "Ninetails",
            "Jigglypuff",
            "Wigglytuff", //40
            "Zubat",
            "Golbat",
            "Oddish",
            "Gloom",
            "Vileplume",
            "Paras",
            "Parasect",
            "Venonat",
            "Venomoth",
            "Diglett",
            "Dugtrio",
            "Meowth",
            "Persian",
            "Psyduck",
            "Golduck",
            "Mankey",
            "Primeape",
            "Growlithe",
            "Arcanine",
            "Poliwag",
            "Poliwhirl",
            "Poliwrath",
            "Abra",
            "Kadabra",
            "Alakazam",
            "Machop",
            "Machoke",
            "Machamp",
            "Bellsprout",
            "Weepinbell",
            "Victreebel",
            "Tentacool",
            "Tentacruel",
            "Geodude",
            "Graveler",
            "Golem",
            "Ponyta",
            "Rapidash",
            "Slowpoke",
            "Slowbro",
            "Magnemite",
            "Magneton",
            "Farfetch'd",
            "Doduo",
            "Dodrio",
            "Seel",
            "Dewgong",
            "Grimer",
            "Muk",
            "Shellder",
            "Cloyster",
            "Gastly",
            "Haunter",
            "Gengar",
            "Onix",
            "Drowzee",
            "Hypno",
            "Krabby",
            "Kingler",
            "Voltorb",
            "Electrode",
            "Exeggcute",
            "Exeggutor",
            "Cubone",
            "Marowak",
            "Hitmonlee",
            "Hitmonchan",
            "Lickitung",
            "Koffing",
            "Weezing",
            "Rhyhorn",
            "Rhydon",
            "Chansey",
            "Tangela",
            "Kangaskhan",
            "Horsea",
            "Seadra",
            "Goldeen",
            "Seaking",
            "Staryu",
            "Starmie",
            "Mr. Mime",
            "Scyther",
            "Jynx",
            "Electabuzz",
            "Magmar",
            "Pinsir",
            "Tauros",
            "Magikarp",
            "Gyarados",
            "Lapras",
            "Ditto",
            "Eevee",
            "Vaporeon",
            "Jolteon",
            "Flareon",
            "Porygon",
            "Omanyte",
            "Omastar",
            "Kabuto",
            "Kabutops",
            "Aerodactyl",
            "Snorlax",
            "Articuno",
            "Zapdos",
            "Moltres",
            "Dratini",
            "Dragonair",
            "Dragonite",
            "Mewtwo",
            "Mew"
        };



        internal static readonly BaseStats[] AllBaseStats = new BaseStats[]
        {   // 0 - No Pokemon
            new BaseStats(0f, 0f, 0f, 0f, 0f),
            // 1 - Bulbasaur
            new BaseStats(45f, 49f, 49f, 65f, 45f),
            // 2 - Ivysaur
            new BaseStats(60f, 62f, 63f, 80f, 60f),
            // 3 - Venusaur
            new BaseStats(80f, 82f, 83f, 100f, 80f),
            // 4 - Charmander
            new BaseStats(39f, 52f, 43f, 50f, 65f),
            // 5 - Charmeleon
            new BaseStats(58f, 64f, 58f, 65f, 80f),
            // 6 - Charizard
            new BaseStats(78f, 84f, 78f, 85f, 100f),
            // 7 - Squirtle
            new BaseStats(44f, 48f, 65f, 50f, 43f),
            // 8 - Wartortle
            new BaseStats(59f, 63f, 80f, 65f, 58f),
            // 9 - Blastoise
            new BaseStats(79f, 83f, 100f, 85f, 78f),
            // 10 - Caterpie
            new BaseStats(45f, 30f, 35f, 20f, 45f),
            // 11 - Metapod
            new BaseStats(50f, 20f, 55f, 25f, 30f),
            // 12 - Butterfree
            new BaseStats(60f, 45f, 50f, 80f, 70f),
            // 13 - Weedle
            new BaseStats(40f, 35f, 30f, 20f, 50f),
            // 14 - Kakuna
            new BaseStats(45f, 25f, 50f, 25f, 35f),
            // 15 - Beedrill
            new BaseStats(65f, 80f, 40f, 45f, 75f),
            // 16 - Pidgey
            new BaseStats(40f, 45f, 40f, 35f, 56f),
            // 17 - Pidgeotto
            new BaseStats(63f, 60f, 55f, 50f, 71f),
            // 18 - Pidgeot
            new BaseStats(83f, 80f, 75f, 70f, 91f),
            // 19 - Rattata
            new BaseStats(30f, 56f, 35f, 25f, 72f),
            // 20 - Raticate
            new BaseStats(55f, 81f, 60f, 50f, 97f),
            // 21 - Spearow
            new BaseStats(40f, 60f, 30f, 31f, 70f),
            // 22 - Fearow
            new BaseStats(65f, 90f, 65f, 61f, 100f),
            // 23 - Ekans
            new BaseStats(35f, 60f, 44f, 40f, 55f),
            // 24 - Arbok
            new BaseStats(60f, 85f, 69f, 65f, 80f),
            // 25 - Pikachu
            new BaseStats(35f, 55f, 30f, 50f, 90f),
            // 26 - Raichu
            new BaseStats(60f, 90f, 55f, 90f, 100f),
            // 27 - Sandshrew
            new BaseStats(50f, 75f, 85f, 30f, 40f),
            // 28 - Sandslash
            new BaseStats(75f, 100f, 110f, 55f, 65f),
            // 29 - Nidoran Female
            new BaseStats(55f, 47f, 52f, 40f, 41f),
            // 30 - Nidorina
            new BaseStats(70f, 62f, 67f, 55f, 56f),
            // 31 - Nidoqueen
            new BaseStats(90f, 82f, 87f, 75f, 76f),
            // 32 - Nidoran Male
            new BaseStats(46f, 57f, 40f, 40f, 50f),
            // 33 - Nidorino
            new BaseStats(61f, 72f, 57f, 55f, 65f),
            // 34 - Nidoking
            new BaseStats(81f, 92f, 77f, 75f, 85f),
            // 35 - Clefairy
            new BaseStats(70f, 45f, 48f, 60f, 35f),
            // 36 - Clefable
            new BaseStats(95f, 70f, 73f, 85f, 60f),
            // 37 - Vulpix
            new BaseStats(38f, 41f, 40f, 65f, 65f),
            // 38 - Ninetails
            new BaseStats(73f, 76f, 75f, 100f, 100f),
            // 39 - Jigglypuff
            new BaseStats(115f, 45f, 20f, 25f, 20f),
            // 40 - Wigglytuff
            new BaseStats(140f, 70f, 45f, 50f, 45f),
            // 41 - Zubat
            new BaseStats(40f, 45f, 35f, 40f, 55f),
            // 42 - Golbat
            new BaseStats(75f, 80f, 70f, 75f, 90f),
            // 43 - Oddish
            new BaseStats(45f, 50f, 55f, 75f, 30f),
            // 44 - Gloom
            new BaseStats(60f, 65f, 70f, 85f, 40f),
            // 45 - Vileplume
            new BaseStats(75f, 80f, 85f, 100f, 50f),
            // 46 - Paras
            new BaseStats(35f, 70f, 55f, 55f, 25f),
            // 47 - Parasect
            new BaseStats(60f, 95f, 80f, 80f, 30f),
            // 48 - Venonat
            new BaseStats(60f, 55f, 50f, 40f, 45f),
            // 49 - Venomoth
            new BaseStats(70f, 65f, 60f, 90f, 90f),
            // 50 - Diglett
            new BaseStats(10f, 55f, 25f, 45f, 95f),
            // 51 - Dugtrio
            new BaseStats(35f, 80f, 50f, 70f, 120f),
            // 52 - Meowth
            new BaseStats(40f, 45f, 35f, 40f, 90f),
            // 53 - Persian
            new BaseStats(65f, 70f, 60f, 65f, 115f),
            // 54 - Psyduck
            new BaseStats(50f, 52f, 48f, 50f, 55f),
            // 55 - Golduck
            new BaseStats(80f, 82f, 78f, 80f, 85f),
            // 56 - Mankey
            new BaseStats(40f, 80f, 35f, 35f, 70f),
            // 57 - Primeape
            new BaseStats(65f, 105f, 60f, 60f, 95f),
            // 58 - Growlithe
            new BaseStats(55f, 70f, 45f, 50f, 60f),
            // 59 - Arcanine
            new BaseStats(90f, 110f, 80f, 80f, 95f),
            // 60 - Poliwag
            new BaseStats(40f, 50f, 40f, 40f, 90f),
            // 61 - Poliwhirl
            new BaseStats(65f, 65f, 65f, 50f, 90f),
            // 62 - Poliwrath
            new BaseStats(90f, 85f, 95f, 70f, 70f),
            // 63 - Abra
            new BaseStats(25f, 20f, 15f, 105f, 90f),
            // 64 - Kadabra
            new BaseStats(40f, 35f, 30f, 120f, 105f),
            // 65 - Alakazam
            new BaseStats(55f, 50f, 45f, 135f, 120f),
            // 66 - Machop
            new BaseStats(70f, 80f, 50f, 35f, 35f),
            // 67 - Machoke
            new BaseStats(80f, 100f, 70f, 50f, 45f),
            // 68 - Machamp
            new BaseStats(90f, 130f, 80f, 65f, 55f),
            // 69 - Bellsprout
            new BaseStats(50f, 75f, 35f, 70f, 40f),
            // 70 - Weepinbell
            new BaseStats(65f, 90f, 50f, 85f, 55f),
            // 71 - Victreebel
            new BaseStats(80f, 105f, 65f, 100f, 70f),
            // 72 - Tentacool
            new BaseStats(40f, 40f, 35, 100f, 70f),
            // 73 - Tentacruel
            new BaseStats(80f, 70f, 65f, 120f, 100f),
            // 74 - Geodude
            new BaseStats(40f, 80f, 100f, 30f, 20f),
            // 75 - Graveler
            new BaseStats(55f, 95f, 115f, 45f, 35f),
            // 76 - Golem
            new BaseStats(80f, 110f, 130f, 55f, 45f),
            // 77 - Ponyta
            new BaseStats(50f, 85f, 55f, 65f, 90f),
            // 78 - Rapidash
            new BaseStats(65f, 100f, 70f, 80f, 105f),
            // 79 - Slowpoke
            new BaseStats(90f, 65f, 65f, 40f, 15f),
            // 80 - Slowbro
            new BaseStats(95f, 75f, 110f, 80f, 30f),
            // 81 - Magnemite
            new BaseStats(25f, 35f, 70f, 95f, 45f),
            // 82 - Magneton
            new BaseStats(50f, 60f, 95f, 120f, 70f),
            // 83 - Fatfetchd
            new BaseStats(52f, 65f, 55f, 58f, 60f),
            // 84 - Doduo
            new BaseStats(35f, 85f, 45f, 35f, 75f),
            // 85 - Dodrio
            new BaseStats(60f, 110f, 70f, 60f, 100f),
            // 86 - Seel
            new BaseStats(65f, 45f, 55f, 70f, 45f),
            // 87 - Dewgong
            new BaseStats(90f, 70f, 80f, 95f, 70f),
            // 88 - Grimer
            new BaseStats(80f, 80f, 50f, 40f, 25f),
            // 89 - Muk
            new BaseStats(105f, 105f, 75f, 65f, 50f),
            // 90 - Shellder
            new BaseStats(30f, 65f, 100f, 45f, 40f),
            // 91 - Cloyster
            new BaseStats(50f, 95f, 180f, 85f, 70f),
            // 92 - Gastly
            new BaseStats(30f, 35f, 30f, 100f, 80f),
            // 93 - Haunter
            new BaseStats(45f, 50f, 45f, 115f, 95f),
            // 94 - Gengar
            new BaseStats(60f, 65f, 60f, 130f, 110f),
            // 95 - Onix
            new BaseStats(35f, 45f, 160f, 30f, 70f),
            // 96 - Drowzee
            new BaseStats(60f, 48f, 45f, 90f, 42f),
            // 97 - Hypno
            new BaseStats(85f, 73f, 70f, 115f, 67f),
            // 98 - Krabby
            new BaseStats(30f, 105f, 90f, 25f, 50f),
            // 99 - Kingler
            new BaseStats(55f, 130f, 115f, 50f, 75f),
            // 100 - Voltorb
            new BaseStats(40f, 30f, 50f, 55f, 100f),
            // 101 - Electrode
            new BaseStats(60f, 50f, 70f, 80f, 140f),
            // 102 - Exeggcute
            new BaseStats(60f, 40f, 80f, 60f, 40f),
            // 103 - Exeggutor
            new BaseStats(95f, 95f, 85f, 125f, 55f),
            // 104 - Cubone
            new BaseStats(50f, 50f, 95f, 40f, 35f),
            // 105 - Marowak
            new BaseStats(60f, 80f, 110f, 50f, 45f),
            // 106 - Hitmonlee
            new BaseStats(50f, 120f, 53f, 35f, 87f),
            // 107 - Hitmonchan
            new BaseStats(50f, 105f, 79f, 35f, 76f),
            // 108 - Lickitung
            new BaseStats(90f, 55f, 75f, 60f, 30f),
            // 109 - Koffing
            new BaseStats(40f, 65f, 95f, 60f, 35f),
            // 110 - Weezing
            new BaseStats(65f, 90f, 120f, 85f, 60f),
            // 111 - Rhyhorn
            new BaseStats(80f, 85f, 95f, 30f, 25f),
            // 112 - Rhydon
            new BaseStats(105f, 130f, 120f, 45f, 40f),
            // 113 - Chansey
            new BaseStats(250f, 5f, 5f, 105f, 50f),
            // 114 - Tangela
            new BaseStats(65f, 55f, 115f, 100f, 60f),
            // 115 - Kangaskhan
            new BaseStats(105f, 95f, 80f, 40f, 90f),
            // 116 - Horsea
            new BaseStats(30f, 40f, 70f, 70f, 60f),
            // 117 - Seadra
            new BaseStats(55f, 65f, 95f, 95f, 85f),
            // 118 - Goldeen
            new BaseStats(45f, 67f, 60f, 50f, 63f),
            // 119 - Seaking
            new BaseStats(80f, 92f, 65f, 80f, 68f),
            // 120 - Staryu
            new BaseStats(30f, 45f, 55f, 70f, 85f),
            // 121 - Starmie
            new BaseStats(60f, 75f, 85f, 100f, 115f),
            // 122 - Mr. Mime
            new BaseStats(40f, 45f, 65f, 100f, 90f),
            // 123 - Scyther
            new BaseStats(70f, 110f, 80f, 55f, 105f),
            // 124 - Jynx
            new BaseStats(65f, 50f, 35f, 95f, 95f),
            // 125 - Electabuzz
            new BaseStats(65f, 83f, 57f, 85f, 105f),
            // 126 - Magmar
            new BaseStats(65f, 95f, 57f, 85f, 93f),
            // 127 - Pinsir
            new BaseStats(65f, 125f, 100f, 55f, 85f),
            // 128 - Tauros
            new BaseStats(75f, 100f, 95f, 70f, 110f),
            // 129 - Magikarp
            new BaseStats(20f, 10f, 55f, 20f, 80f),
            // 130 - Gyarados
            new BaseStats(95f, 125f, 79f, 100f, 81f),
            // 131 - Lapras
            new BaseStats(130, 85f, 80f, 95f, 60f),
            // 132 - Ditto
            new BaseStats(48f, 48f, 48f, 48f, 48f),
            // 133 - Eevee
            new BaseStats(55f, 55f, 50f, 65f, 55f),
            // 134 - Vaporeon
            new BaseStats(130f, 65f, 60f, 110f, 65f),
            // 135 - Jolteon
            new BaseStats(65f, 65f, 60f, 110f, 130f),
            // 136 - Flareon
            new BaseStats(65f, 130f, 60f, 110f, 65f),
            // 137 - Porygon
            new BaseStats(65f, 60f, 70f, 75f, 40f),
            // 138 - Omanyte
            new BaseStats(35f, 40f, 100f, 90f, 35f),
            // 139 - Omastar
            new BaseStats(70f, 60f, 125f, 115f, 55f),
            // 140 - Kabuto
            new BaseStats(30f, 80f, 90f, 45f, 55f),
            // 141 - Kabutops
            new BaseStats(60f, 115f, 105f, 70f, 80f),
            // 142 - Aerodactyl
            new BaseStats(80f, 105f, 65f, 60f, 130f),
            // 143 - Snorlax
            new BaseStats(160f, 110f, 65f, 65f, 30f),
            // 144 - Articuno
            new BaseStats(90f, 85f, 100f, 125f, 85f),
            // 145 - Zapos
            new BaseStats(90f, 90f, 85f, 125f, 100f),
            // 146 - Moltres
            new BaseStats(90f, 100f, 90f, 125f, 90f),
            // 147 - Dratini
            new BaseStats(41f, 64f, 45f, 50f, 50f),
            // 148 - Dragonair
            new BaseStats(61f, 84f, 65f, 70f, 70f),
            // 149 - Dragonite
            new BaseStats(91f, 134f, 95f, 100f, 80f),
            // 150 - Mewtwo
            new BaseStats(106f, 110f, 90f, 154f, 130f),
            // 151 - Mew
            new BaseStats(100f, 100f, 100f, 100f, 100f)
        };



        internal sealed class BaseStats
        {
            public readonly float HP;
            public readonly float Attack;
            public readonly float Defense;
            public readonly float Special;
            public readonly float Speed;

            public BaseStats(float hp, float attack, float defense, float special, float speed)
            {
                HP = hp;
                Attack = attack;
                Defense = defense;
                Special = special;
                Speed = speed;
            }

        }





    }
}
