using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    public GameObject characterPrefab;
    public Transform pathwayParent;

    void Start()
    {
       StartCoroutine(SpawnCharacterRoutine());

    }
      IEnumerator SpawnCharacterRoutine()
    {
        while (true)
        {
            SpawnCharacter();
            float randomWaitTime = Random.Range(7f, 10f);
            yield return new WaitForSeconds(randomWaitTime);
        }
    }

     public void SpawnCharacter()
    {
        if (characterPrefab == null)
        {
            Debug.LogError("No character prefab assigned!");
            return;
        }

        // Instantiate the character at the spawn point’s position and rotation
        GameObject character = Instantiate(characterPrefab, gameObject.transform.position, gameObject.transform.rotation);

        Transform[] waypoints = new Transform[pathwayParent.childCount];
        for (int i = 0; i < pathwayParent.childCount; i++)
        {
            waypoints[i] = pathwayParent.GetChild(i);
        }

         CharacterFollowWaypoints followScript = character.GetComponent<CharacterFollowWaypoints>();
        if (followScript != null)
        {
            followScript.waypoints = waypoints;
        }
        else
        {
            Debug.LogWarning("Character doesn't have a CharacterFollowWaypoints component!");
        }
    }

}
