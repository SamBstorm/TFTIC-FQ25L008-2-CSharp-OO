using Demo_DelegateReturn.Models;

namespace Demo_DelegateReturn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompactDisk cd1 = new CompactDisk("Compil' CyberSécu!",
                new MusicSingle("Daft Punk","One More Time", 341),
                new MusicSingle("Daft Punk","Veridis Qo", 546),
                new MusicSingle("Jean-Michel Jarre","Téo et Téa", 209),
                new MusicSingle("Jean-Michel Jarre","Oxigen", 208),
                new MusicSingle("Bob Marley","No Woman No Cry", 414),
                new MusicSingle("Franck Sinatra","Flying to the moon", 148)
                );

            CompactDisk cd2 = new CompactDisk("Compil' CyberSécu! 2",
                new MusicSingle("Céline Dion", "All by myself", 341),
                new MusicSingle("Céline Dion", "My heart will go on", 546),
                new MusicSingle("Céline Dion", "Là-bas", 209),
                new MusicSingle("Céline Dion", "Sous le vent", 208)
                );

            CDPlayer player = new CDPlayer();
            player.CurrentCD = cd2;

            //player.SetProgram(5);
            //player.SetProgram(6);
            player.SetProgram(1);
            player.SetProgram(1);
            player.SetProgram(4);

            player.PlayCD();
        }
    }
}
