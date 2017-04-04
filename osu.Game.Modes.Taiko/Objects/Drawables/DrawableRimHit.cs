﻿// Copyright (c) 2007-2017 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using osu.Framework.Allocation;
using osu.Game.Graphics;
using osu.Game.Modes.Taiko.Objects.Drawables.Pieces;
using OpenTK.Input;

namespace osu.Game.Modes.Taiko.Objects.Drawables
{
    public class DrawableRimHit : DrawableHit
    {
        protected override Key[] HitKeys { get; } = { Key.D, Key.K };

        public DrawableRimHit(Hit hit)
            : base(hit)
        {
        }

        [BackgroundDependencyLoader]
        private void load(OsuColour colours)
        {
            Circle.AccentColour = colours.BlueDarker;
        }

        protected override CirclePiece CreateCirclePiece() => new CirclePiece
        {
            Children = new[] { new RimHitSymbolPiece() }
        };
    }
}