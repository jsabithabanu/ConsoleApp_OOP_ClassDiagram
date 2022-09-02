using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp_OOP
{
    public abstract class Person : ICanteen
    {
        protected string Name
        {
            get => default;
            set
            {
            }
        }

        protected int Age
        {
            get => default;
            set
            {
            }
        }

        public virtual void getUniversityName()
        {
            throw new System.NotImplementedException();
        }

        public void takeAwayMeals()
        {
            throw new System.NotImplementedException();
        }

        public void dineInMeals()
        {
            throw new System.NotImplementedException();
        }
    }
}