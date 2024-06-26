﻿using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

[UdonBehaviourSyncMode(BehaviourSyncMode.NoVariableSync)]
public class Invoke : UdonSharpBehaviour
{
    [SerializeField] string methodName;
    [SerializeField] UdonBehaviour target;

    public override void Interact(){
        target.SendCustomEvent(methodName);
    }
}