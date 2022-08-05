using System;
namespace CsharpOOP.Classes
{
	public class BankAccount
	{
		
		private float balance;
		public float Balance
        {
			get { return balance; }
			private set
			{
				if (value >= 0)
					balance = value;
				else
					balance = 0;
			}
        }

		private string owner;

		public BankAccount()
        {
			// this is default constructor
        }

		public BankAccount(float balance, string owner)
		{
			Balance = balance;
			this.owner = owner;
		}

		public virtual float AddBalance(float balanceToBeAdded)
        {
			Balance = balance + balanceToBeAdded;
			return Balance;
		}

		public virtual float AddBalance(float balanceToBeAdded, bool balanceCanBeNegative)
		{
			if (balanceCanBeNegative)
				balance = balance + balanceToBeAdded;
			else
				Balance = balance + balanceToBeAdded;
			return Balance;
		}
	}

	public class ChildBankAccount : BankAccount
    {
        // extra properties
        public string Parent { get; set; }
        public ChildBankAccount(float balance, string owner, string parent) : base(balance, owner)
        {
			Parent = parent;
        }

		// overriding
		public override float AddBalance(float balanceToBeAdded)
        {
			if (balanceToBeAdded >= -10)
				return base.AddBalance(balanceToBeAdded);
			return Balance;
        }

		public override float AddBalance(float balanceToBeAdded, bool balanceCanBeNegative)
        {
			if (balanceToBeAdded >= -10)
				return base.AddBalance(balanceToBeAdded, balanceCanBeNegative);
			return Balance;
        }

	}
}

