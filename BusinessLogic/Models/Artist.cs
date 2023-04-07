using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Models
{
	public class Artist
	{
		public int ID { get; set; }
		public string ArtistName { get; set; }
		public ICollection<Album> Albums { get; set; }
	}
}
