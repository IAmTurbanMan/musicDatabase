using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpotifyAPI.Web;
using System.Configuration;

namespace Engine
{
	public static class SpotifyCalls
	{
		private static string CLIENT_ID = ConfigurationManager.AppSettings["CLIENT_ID"];
		private static string CLIENT_SECRET = ConfigurationManager.AppSettings["CLIENT_SECRET"];

		public static async Task<string> GetArtist()
		{
			var Config = SpotifyClientConfig.CreateDefault();

			var Request = new ClientCredentialsRequest(CLIENT_ID, CLIENT_SECRET);
			var Response = await new OAuthClient(Config).RequestToken(Request);

			var Spotify = new SpotifyClient(Config.WithToken(Response.AccessToken));

			var Artist = await Spotify.Artists.Get("0TnOYISbd1XYRBk9myaseg");
			string ArtistName = Artist.Name;
			return ArtistName;
		}
	}
}
