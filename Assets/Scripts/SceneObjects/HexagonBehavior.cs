using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexagonBehavior : MonoBehaviour
{
    private int collectionScore;
    [SerializeField] private Sora.Events.SoraEvent hexagonCollectionEvent;

    private void Start()
    {
        collectionScore = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            collectionScore += 100;
            hexagonCollectionEvent.InvokeEvent(this, collectionScore);
        }
    }
}
