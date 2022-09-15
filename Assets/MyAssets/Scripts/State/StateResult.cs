using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateResult : MonoBehaviour
{
    public readonly int NextStateId;

    public readonly object ResultData;

    public StateResult(int nextStateId, object resultData = null)
    {
        NextStateId = nextStateId;
        ResultData = resultData;
    }
}
