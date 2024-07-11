using UnityEngine;

public class TrashCan : MonoBehaviour
{
    private void Start()
    {
        GetComponent<TriggerZone>().OnEnterEvent.AddListener(InsideTrash);
    }
    public void InsideTrash(GameObject obj)
    {
        obj.SetActive(false);
    }
}
