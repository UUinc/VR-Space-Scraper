using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Breakable : MonoBehaviour
{
    public List<GameObject> breakablePieces;

    private float timeToBreak = 2f;
    private float time = 0f;

    public UnityEvent OnBreak;

    void Start()
    {
        foreach(var piece in breakablePieces)
        {
            piece.SetActive(false);
        }
    }

    public void Break()
    {
        time += Time.deltaTime;

        if(time > timeToBreak)
        {
            foreach(var piece in breakablePieces)
            {
                piece.SetActive(true);
                piece.transform.parent = null;
            }

            OnBreak.Invoke();

            gameObject.SetActive(false);
        }
    }
}
