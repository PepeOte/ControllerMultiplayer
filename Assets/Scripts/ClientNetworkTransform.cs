using UnityEngine;
using Unity.Netcode.Components;
public class ClientNetworkTransform : NetworkTransform
{
    protected override bool OnIsServerAuthoritative()
    {
        // This is a client-side transform, so we return false to indicate that the server does not have authority over it.
        return false;
    }

}
