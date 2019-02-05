using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiWithDapper.Models
{
	[Table("UserAddress")]
	public class UserAddress : CommonFields
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column(Order = 1)]
		public long UserAddressId { get; set; }

		public string City
		{
			get;
			set;
		}

		public string State
		{
			get;
			set;
		}

		[Required]
		public string Country
		{
			get;
			set;
		}

		public long UserId
		{
			get;
			set;
		}
	}
}
