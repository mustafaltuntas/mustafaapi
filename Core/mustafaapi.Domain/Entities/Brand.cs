using System;
using mustafaapi.Domain.Common;

namespace mustafaapi.Domain.Entities
{
	public class Brand : EntityBase
	{
		public Brand()
		{
		}
		public Brand(string name)
		{
            Name = name;
        }
		public required string Name { get; set; }
	}
}

