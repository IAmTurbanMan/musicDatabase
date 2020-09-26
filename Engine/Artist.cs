using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpotifyAPI.Web;

namespace Engine
{
	public class Artist
	{
		public string ArtistName { get; set; }

		public Artist(string artistName)
		{
			ArtistName = artistName;
		}
	}
}
