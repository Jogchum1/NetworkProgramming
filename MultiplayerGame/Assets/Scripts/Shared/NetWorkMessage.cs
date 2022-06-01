using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Networking.Transport;


public class NetWorkMessage
{
    public DataTypes dataType { set; get; }

    public virtual void Serialize(ref DataStreamWriter writer)
    {

    }

    public virtual void Deserialize()
    {

    }
}
