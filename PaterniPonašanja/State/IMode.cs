using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public interface IMode
    {
        public void koristiDestinyWeapons();
        public void igrajMultiplayer(List<string> usernames);
    }
}
