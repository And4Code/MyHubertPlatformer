﻿using UnityEngine;

///<summary>
/// Represents informations about the jump state of a character.
///</summary>
[System.Serializable]
public class JumpUpdateInfos
{
    // Teh total time (in seconds) the character is jumping.
    public float jumpTime;
    // Ratio of the elasped jump time, and the total jump duration.
    public float jumpRatio;
    public Vector3 jumpOrigin;
}