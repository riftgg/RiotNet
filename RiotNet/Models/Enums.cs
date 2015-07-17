﻿namespace RiotNet.Models
{
    /// <summary>
    /// Represents a region (or server).
    /// </summary>
    public enum Region
    {
        /// <summary>
        /// Brazil
        /// </summary>
        BR,
        /// <summary>
        /// Europe Nordic &amp; East
        /// </summary>
        EUNE,
        /// <summary>
        /// Europe West
        /// </summary>
        EUW,
        /// <summary>
        /// Korea
        /// </summary>
        KR,
        /// <summary>
        /// Latin America North
        /// </summary>
        LAN,
        /// <summary>
        /// Latin America South
        /// </summary>
        LAS,
        /// <summary>
        /// North America
        /// </summary>
        NA,
        /// <summary>
        /// Oceania
        /// </summary>
        OCE,
        /// <summary>
        /// Public Beta Environment
        /// </summary>
        PBE,
        /// <summary>
        /// Russia
        /// </summary>
        RU,
        /// <summary>
        /// Turkey
        /// </summary>
        TR,
    }

    /// <summary>
    /// Represents a ranked queue.
    /// </summary>
    public enum RankedQueue
    {
        /// <summary>
        /// Ranked Solo 5v5
        /// </summary>
        RANKED_SOLO_5x5,
        /// <summary>
        /// Ranked Team 3v3
        /// </summary>
        RANKED_TEAM_3x3,
        /// <summary>
        /// Ranked Team 5v5
        /// </summary>
        RANKED_TEAM_5x5,
    }

    /// <summary>
    /// Represents a ranked tier.
    /// </summary>
    public enum Tier
    {
        /// <summary>
        /// Challenger tier
        /// </summary>
        Challenger,
        /// <summary>
        /// Master tier
        /// </summary>
        Master,
        /// <summary>
        /// Diamond tier
        /// </summary>
        Diamond,
        /// <summary>
        /// Platinum tier
        /// </summary>
        Platinum,
        /// <summary>
        /// Gold tier
        /// </summary>
        Gold,
        /// <summary>
        /// Silver tier
        /// </summary>
        Silver,
        /// <summary>
        /// Bronze tier
        /// </summary>
        Bronze
    }

    /// <summary>
    /// Represents a game mode.
    /// </summary>
    public enum GameMode
    {
        /// <summary>
        /// Classic, played on both Summoner's Rift and Twisted Treeline.
        /// </summary>
        CLASSIC,
        /// <summary>
        /// Dominion, played on The Crystal Scar.
        /// </summary>
        ODIN,
        /// <summary>
        /// All Random All Mid, played on both Howling Abyss and Butcher's Bridge.
        /// </summary>
        ARAM,
        /// <summary>
        /// Tutorial.
        /// </summary>
        TUTORIAL,
        /// <summary>
        ///  One for All, played on both Summoner's Rift and Howling Abyss.
        /// </summary>
        ONEFORALL,
        /// <summary>
        /// Ascension, played on The Crystal Scar.
        /// </summary>
        ASCENSION,
        /// <summary>
        /// Snowdown Showdown, played on the Howling Abyss.
        /// </summary>
        FIRSTBLOOD,
        /// <summary>
        /// Legend of the Poro King, played on the Howling Abyss.
        /// </summary>
        KINGPORO
    }
}
