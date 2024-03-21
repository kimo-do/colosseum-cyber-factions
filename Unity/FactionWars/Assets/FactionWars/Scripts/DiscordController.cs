using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DiscordController : MonoBehaviour {

    //private readonly long applicationId = 1220056368430710844;

    //public Discord.Discord discord;
    //public TextMeshProUGUI logText;


    //private bool isSetup = false;

    //// Use this for initialization
    //void Start()
    //{
    //    StartCoroutine(AfterStart());
    //}

    //private void OnDisable()
    //{
    //    if (discord != null)
    //    {
    //        discord.Dispose();
    //    }
    //}

    //IEnumerator AfterStart()
    //{
    //    yield return new WaitForSeconds(1f);

    //    discord = new Discord.Discord(applicationId, (System.UInt64)Discord.CreateFlags.Default);
    //    var activityManager = discord.GetActivityManager();
    //    var activity = new Discord.Activity
    //    {
    //        State = "Still Testing",
    //        Details = "Bigger Test"
    //    };

    //    isSetup = true;

    //    activityManager.UpdateActivity(activity, (res) =>
    //    {
    //        if (res == Discord.Result.Ok)
    //        {
    //            //Debug.Log("Everything is fine!");
    //        }
    //    });

    //    var userManager = discord.GetUserManager();

    //    // Return normally
    //    userManager.OnCurrentUserUpdate += () =>
    //    {
    //        MainThreadDispatcher.Instance().Enqueue(ShowCurrentUser);
    //    };
    //}

    //private void ShowCurrentUser()
    //{
    //    var userManager = discord.GetUserManager();
    //    var currentUser = userManager.GetCurrentUser();
    //    logText.text += "\n " + currentUser.Username;
    //    logText.text += "\n " + currentUser.Discriminator;
    //    logText.text += "\n " + currentUser.Id;
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    if (isSetup)
    //    {
    //        discord.RunCallbacks();
    //    }
    //}
}
