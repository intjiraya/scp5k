// -----------------------------------------------------------------------
// <copyright file="KillingPlayerEventArgs.cs" company="ExMod Team">
// Copyright (c) ExMod Team. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace Exiled.Events.EventArgs.Player
{
    using System;

    using Interfaces;
    using PlayerStatsSystem;

    /// <summary>
    /// Contains all information before player data to kill player is sent.
    /// </summary>
    [Obsolete]
    public class KillingPlayerEventArgs : IPlayerEvent
    {
        /// <summary>
        ///  Initializes a new instance of the <see cref="KillingPlayerEventArgs"/> class.
        /// </summary>
        /// <param name="player"> Current player. </param>
        /// <param name="handler"> DamageHandler instance. </param>
        public KillingPlayerEventArgs(API.Features.Player player, ref DamageHandlerBase handler)
        {
            Player = player;
            Handler = handler;
        }

        /// <summary>
        /// Gets or sets current player.
        /// </summary>
        public API.Features.Player Player { get; set; }

        /// <summary>
        /// Gets or sets current Damage Handler.
        /// </summary>
        public DamageHandlerBase Handler { get; set; }
    }
}