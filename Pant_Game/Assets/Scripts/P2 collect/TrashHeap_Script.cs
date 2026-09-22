using UnityEngine;

public class TrashHeap_Script : MonoBehaviour
{
    public int TrashInHeapCount;

    private void Start()
    {
        TrashInHeapCount = Random.Range(30, 100);
    }


}
