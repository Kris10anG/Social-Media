using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Media
{
    internal interface IProfileList
    {
        public void AddToProfileList(Profile profile);
        public Profile FindProfileById(string id);
        public Profile FindProfileByName(string name);
    }
}
