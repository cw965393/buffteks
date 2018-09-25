using System;

namespace buffteks.models
{
    public class Team_Project
    {
        public int TeamID {get; set;}
      
        public team TheTeam{ get; set;}

        public int ProjectID {get; set;}
        public project TheProject{ get; set;}
    }
}