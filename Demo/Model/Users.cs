using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Model
{
	//This annotation is optional unless you are trying to refer this model as table name.
	[Table("Users")]
	public class Users : CommonFields
	{
		public Users()
		{
			this.UserAddresses = new HashSet<UserAddress>();
		}

		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public long UserId { get; set; }

		//Required field with length constraint of 50 chars
		[Required]
		[StringLength(50)]
		public string FirstName
		{
			get;
			set;
		}

		//Will be created like a varchar field
		public string LastName
		{
			get;
			set;
		}

		// An abstract property declaration. It does not provide an implementation of the property accessors 
		//-- it declares that the class supports properties, but leaves the accessor implementation to derived classes.
		public virtual ICollection<UserAddress> UserAddresses
		{
			get;
			set;
		}

	}
}
