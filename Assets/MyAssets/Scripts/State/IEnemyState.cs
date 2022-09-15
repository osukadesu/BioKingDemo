using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public interface IEnemyState
{
    Task<StateResult> DoAction(object data);
}
