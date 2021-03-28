using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    private static string[] wordList = {"Fortnite", "Dark Souls", "Bloodborne", "Assassin's Creed", "Batman", "Bioshock",
    "Call of Duty", "Control", "Cyberpunk 2077", "Deus Ex", "Yakuza Kiwami", "Zero Escape", "XCOM II",
    "Uncharted IV", "Torment", "Tomb Raider", "The Witcher", "The Last of Us", "The Evil Within",
    "Street Fighter", "Tekken", "Resident Evil", "Ratchet & Clank", "Persona V", "Outlast", "Pacman",
    "Metal Gear", "Kingdom Hearts", "Hitman", "Hotline Miami", "Hellblade", "God of War", "Final Fantasy", "Dragonball",
     "Destiny", "Death Stranding", "Red Dead Redemption", "Shovel Knight", "Spiderman", "Overwatch", "Horizon:Zero Dawn",
     "Fallout", "Nioh", "Minecraft", "Mortal Kombat", "Doom", "Wolfenstein", "Crash Bandicoot", "Tetris", "Dishonored"  };
       
    public static string GetRandomWord ()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }
}
