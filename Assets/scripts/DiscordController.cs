using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Discord;

public class DiscordController : MonoBehaviour
{
    public Discord.Discord discord;
    public GameObject MainMenuExit;
    void Start()
    {
        discord = new Discord.Discord(817591101497671741, (System.UInt64)Discord.CreateFlags.NoRequireDiscord);
        var activityManager = discord.GetActivityManager();
        var activity = new Discord.Activity
        {
            State = "Main Menu",
            Details = "Running Dev Build",
            Timestamps =
            {
                Start = 5
            },
            Party =
            {
                Id = "SinglePlayer",
                Size =
                {
                    CurrentSize = 1
                }
            },
            Assets =
            {
                LargeImage = "largeimage",
                LargeText = "In The Grasslands",
                
            }
            
        };

        activityManager.UpdateActivity(activity, (res) =>
        {
            if (res == Discord.Result.Ok)
            {
                Debug.Log("Discord Rich Presence activated succsessfully!");
            }
            else
            {
                Debug.LogError("Discord Rich Presense Failed! is Discord open?");
            }
        });
        if(MainMenuExit.GetComponent<MainMenu>().isGameQuitting == true)
        {
            activityManager.ClearActivity((result) =>
            {
                if (result == Discord.Result.Ok)
                {
                    Debug.Log("Clear Success!");
                }
                else
                {
                    Debug.LogError("Clear Failed!");
                }
            });
        }
    }

    void Update()
    {
        discord.RunCallbacks();
    }
}
