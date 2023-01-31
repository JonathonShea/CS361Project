using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class EncounterItem
    {
        private String _name;
        private String _level;
        private String _type;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public String Level
        {
            get { return _level; }
            set { _level = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public EncounterItem(String name, String level, String type)
        {
            _name = name;
            _level = level;
            _type = type;
        }



    }
}
