namespace _03BarracksFactory.Core.Commands
{
    using System;
    using Contracts;
    
    public class RetireCommand : Command
    {
        [Inject]
        private IRepository repository;

        public RetireCommand(string[] data, IRepository repository) : base(data)
        {
            this.Repository = repository;
        }

        protected IRepository Repository
        {
            get { return repository; }
            private set { repository = value; }
        }

        public override string Execute()
        {
            string unitType = this.Data[1];

            try
            {
                this.Repository.RemoveUnit(unitType);
                return $"{unitType} retired!";
            }
            catch (Exception ex)
            {
                throw new ArgumentException("No such units in repository.", ex);
            }
        }
    }
}
