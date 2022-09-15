using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetFinder : ITargetFinder
{
    public static TargetFinder Instance =>
        _instance ?? (_instance = new TargetFinder());

    private static TargetFinder _instance;

    public Enemy[] FindTargets()
    {
        return Object.FindObjectsOfType<Enemy>();
    }
}
