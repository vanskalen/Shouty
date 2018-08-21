using System;
using TechTalk.SpecFlow;
using Shouty;
using NUnit.Framework;
using TechTalk.SpecFlow.Assist;

namespace Shouty.Specs
{
    [Binding]
    public class LocationSteps
    {
        [StepArgumentTransformation(@"(.*), (.*)")]
        public Coordinate ConvertCoordinate(int xCoord, int yCoord)
        {
            return new Coordinate(xCoord, yCoord);
        }
                                    
        public LocationSteps(ShoutyNetwork sh)
        {
            shouty = sh;
        }

        private readonly ShoutyNetwork shouty;

        [Given(@"(.*) is at (.*), (.*)")]
        public void GivenUserIsAt(string name, int xCoord, int yCoord)
        {
            shouty.SetLocation(name, new Coordinate(xCoord, yCoord));
        }

        [Given(@"people are located at")]
        public void GivenPeopleAreLocatedAt(Table table)
        {
             var userLocations = table.CreateSet<User>();

             foreach (var user in userLocations)
            {
                shouty.SetLocation(user.Name, new Coordinate(user.X, user.Y));
            }
        }
        

        
            public class User
    {
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }

    }
}
