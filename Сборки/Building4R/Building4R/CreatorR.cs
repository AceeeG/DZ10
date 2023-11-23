using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building4R
{
    public class CreatorR
    {
        static private Hashtable building_table = new Hashtable(9999);
        static public Hashtable Building_table
        {
            get
            {
                return building_table;
            }
        }
        private CreatorR()
        {

        }
        static public Building4 CreateBuilding()
        {
            Building4 building = new Building4();
            building_table.Add(building.Id, building);
            return (Building4)building_table[building.Id];
        }
        static public void DeleteBuilding(uint id)
        {
            building_table.Remove(id);
        }
        static public Building4 GetBuilding(uint id)
        {
            return (Building4)building_table[id];
        }
    }
}
