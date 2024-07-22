using System;
namespace mustafaapi.Domain.Entities
{

	public class Category : EntityBase
	{
		public Category()
		{

		}
		public Category(int ParentId, string Name, int Priorty)
		{
			this.ParentId = ParentId;
			this.Name = Name;
			this.Priorty = Priorty;
		}
		public required int ParentId { get; set; }

		public required string Name { get; set; }

		public required int Priorty { get; set; }
		public ICollection<Detail> Details { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}