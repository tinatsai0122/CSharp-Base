using System.Diagnostics;

namespace Exo_struc_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PisteAudio track1;
            track1.artist = "Dianne Reeves";
            track1.title = "Feels So Good";
            track1.category = "Jazz";
            track1.lengthSong = 310;

            PisteAudio track2;
            track2.artist = "Beyonce";
            track2.title = "Break My Soul";
            track2.category = "Pop";
            track2.lengthSong = 280;

            PisteAudio track3;
            track3.artist = "Ariana Grande";
            track3.title = "Side to Side";
            track3.category = "Pop";
            track3.lengthSong = 350;

            PisteAudio track4 = track3;
            track4.title = "Stuck with U";
            track4.lengthSong = 184;


            Album album1;
            album1.albumTitle = "Monday Jazz";
            album1.releaseDate = new DateOnly(2022,1,1);
            album1.tracks = new List<PisteAudio>();
            album1.tracks.Add(track1);
            album1.tracks.Add(track2);
            album1.tracks.Add(track3);
            album1.tracks.Add(track4);

            Console.WriteLine($"Album 1: {album1.albumTitle} released on {album1.releaseDate}: ");
            Console.WriteLine($"{album1.tracks.Count} tracks");
            foreach (PisteAudio track in album1.tracks )
                Console.WriteLine($"\t\"{track.title}\" - sang by {track.artist} ({track.lengthSong}sec.)");

            




            







            Console.WriteLine($"");


        }
    }
}