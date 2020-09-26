using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpotifyAPI.Web;

using Engine;

namespace musicDatabase
{
	public partial class musicDatabase : Form
	{
		public Artist _artist;
		public musicDatabase()
		{
			InitializeComponent();
			lblArtistName.Text = "Artist Name goes here";
		}

		private async void WriteArtist()
		{
			string _artistName = await SpotifyCalls.GetArtist();
			_artist = new Artist(_artistName);
			lblArtistName.Text = _artist.ArtistName;
		}

		private void btnTest_Click(object sender, EventArgs e)
		{
			WriteArtist();
		}
	}
}
