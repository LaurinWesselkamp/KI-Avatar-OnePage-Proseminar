using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Normal.Realtime;

public class SyncedCountdown : RealtimeComponent<IntModel>
{
    public int startingTime = 600;
    public Text time;

    // Update is called once per frame
    void Update()
    {
        if(model == null || model.value == 0.0)
        {
            time.text = "" + startingTime;
        }
        else
        {
            var rt = realtime.room.time;
            var mt = model.value;
            int ftime = startingTime - (int)(rt - mt);
            if(ftime > 0)
            {
                time.text = ftime.ToString();
            }
            else
            {
                time.text = "0";
            }

        }
    }

    public void SetActivationTime()
    {
        model.value = (int) realtime.room.time;
    }
}
