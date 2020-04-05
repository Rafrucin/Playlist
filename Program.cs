using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Song
{
    private string name;
    public Song NextSong { get; set;  }


    public Song(string name)
    {
        this.name = name;
        
    }



    public bool IsRepeatingPlaylist()
    {
        Song slow = this;
        Song fast = this.NextSong;

        while (slow != null && fast != null)
        {
            if (ReferenceEquals(slow, fast))
                return true;

            slow = slow.NextSong;
            fast = fast.NextSong?.NextSong;
        }

        return false;

    }

    public static void Main(string[] args)
    {

        Song first = new Song("11");
        Song second = new Song("22");
        Song third = new Song("33");
        Song forth = new Song("44");

        first.NextSong = second;
        second.NextSong = third;
        third.NextSong = forth;
        forth.NextSong = third;
        

        Console.WriteLine(first.IsRepeatingPlaylist());
        Console.ReadLine();
    }
}