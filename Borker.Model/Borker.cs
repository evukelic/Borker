using System;

namespace Borker.Model
{
    public class Borker : EntityBase<int>
    {
        public static readonly int UndefinedBorkerID = -1;

		public Borker() : base(UndefinedBorkerID)
		{
		}

		public Borker(int id, string name, string breed, string location, string salary, float duration, DateTime dateTime, int creator) : base(id)
		{
			CreatorId = creator;
			ApplierId = -1;
			Name = name;
			Breed = breed;
			Location = location;
			Salary = salary;
			Duration = duration;
			DateTime = dateTime;
		}

		public int CreatorId { get; set; }
		public int ApplierId { get; set; }
		public string Name { get; set; }
		public string Breed { get; set; }
		public string Location { get; set; }
		public string Salary { get; set; }
		public float Duration { get; set; }
		public DateTime DateTime { get; set; }

	}
}
