namespace _03BarracksFactory.Core.Commands
{
    using _03BarracksFactory.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Command : IExecutable
    {
        private string[] data;
        //private IRepository repository;
        //private IUnitFactory unitFactory;

        public Command(string[] data)
        {
            this.Data = data;
            //this.Repository = repository;
            //this.UnitFactory = unitFactory;
        }
        
        protected string[] Data
        {
            get { return data; }
            private set { data = value; }
        }

        //protected IRepository Repository
        //{
        //    get { return repository; }
        //    private set { repository = value; }
        //}

        //protected IUnitFactory UnitFactory
        //{
        //    get { return unitFactory; }
        //    private set { unitFactory = value; }
        //}

        public abstract string Execute();
    }
}
