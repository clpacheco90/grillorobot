using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BoxCollider))]
public class Coin : MonoBehaviour {
//-----------------------------------------------------------------------------------------------------------------------------//			
    void OnTriggerEnter(Collider other) {
        if (!other.transform.tag.Equals("Player")) return;
        var scriptCoinSystem = GameObject.FindGameObjectWithTag("Manager").GetComponent<CoinSystem>();
        scriptCoinSystem._currentScore++;
        Destroy(gameObject);
    }
//-----------------------------------------------------------------------------------------------------------------------------//			
}
