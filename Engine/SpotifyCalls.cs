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
		//set variables for API keys
		//gets values from app.config file to keep them hidden
		private static string CLIENT_ID = ConfigurationManager.AppSettings["CLIENT_ID"];
		private static string CLIENT_SECRET = ConfigurationManager.AppSettings["CLIENT_SECRET"];
		static SpotifyClient Spotify;

		//private method to request a connection to the API
		private static async Task RequestConnection()
		{
			var Config = SpotifyClientConfig.CreateDefault();

			var Request = new ClientCredentialsRequest(CLIENT_ID, CLIENT_SECRET);
			var Response = await new OAuthClient(Config).RequestToken(Request);

			Spotify = new SpotifyClient(Config.WithToken(Response.AccessToken));
		}

		//method to get Artist name based on unique Artist ID
		//currently using a placeholder ID for Pitbull
		public static async Task<string> GetArtist()
		{
			await RequestConnection();

			var Artist = await Spotify.Artists.Get("0TnOYISbd1XYRBk9myaseg");
			string ArtistName = Artist.Name;
			return ArtistName;
		}
	}
}
