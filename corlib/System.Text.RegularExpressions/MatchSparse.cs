﻿namespace System.Text.RegularExpressions
{
    using System;
    using System.Collections;

    internal class MatchSparse : Match
    {
        internal System.Collections.Generic.Dictionary<object,object> _caps;

        internal MatchSparse(Regex regex, System.Collections.Generic.Dictionary<object, object> caps, int capcount, string text, int begpos, int len, int startpos)
            : base(regex, capcount, text, begpos, len, startpos)
        {
            this._caps = caps;
        }

        public override GroupCollection Groups
        {
            get
            {
                if (base._groupcoll == null)
                {
                    base._groupcoll = new GroupCollection(this, this._caps);
                }
                return base._groupcoll;
            }
        }
    }
}

