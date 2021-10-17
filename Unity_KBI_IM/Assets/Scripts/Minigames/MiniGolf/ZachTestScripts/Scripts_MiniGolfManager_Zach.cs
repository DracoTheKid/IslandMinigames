using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DefaultExecutionOrder(-50)]
public class Scripts_MiniGolfManager_Zach : Scripts_BaseManager_Wyatt
{
    protected override void Awake()
    {
        base.Awake();

        Screen.orientation = ScreenOrientation.Portrait;
    }
}