using UnityEngine;

public class  CreateManager : MonoBehaviour
{
    public static void CreateObject(GameObject gameObject, Vector3 positionObject, Quaternion quaternion)
    {
        Instantiate(gameObject, positionObject, quaternion);
    }
}
