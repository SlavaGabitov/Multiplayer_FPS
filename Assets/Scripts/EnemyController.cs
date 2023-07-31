using System.Collections.Generic;
using Colyseus.Schema;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public void OnChange(List<DataChange> changes)
    {
        var position = transform.position;
        foreach (var dataChange in changes)
        {
            switch (dataChange.Field)
            {
                case "x":
                    position.x = (float) dataChange.Value;
                    break;
                case "y":
                    position.z = (float) dataChange.Value;
                    break;
                default:
                    Debug.Log(dataChange.Field + " field change not handled");
                    break;
            }
        }

        transform.position = position;
    }
}
