using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using osu.GameplayElements.HitObjects;

namespace osu.GameModes.Edit.AiMod.Reports
{
    public class AiReportOneObject : AiReport
    {
        public readonly HitObjectBase h1;

        public AiReportOneObject(HitObjectBase h, BeenCorrectedDelegate corrected, Severity severity, string information, int weblink, GameMode Mode = GameMode.All)
            : base(h.StartTime, severity, information, weblink, corrected, Mode)
        {
            this.h1 = h;
            
            RelatedHitObjects.Add(h);
        }
    }
}
