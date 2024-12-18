using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject characterPrefab;

    void Start()
    {
      SpawnCharacter();
    }

     public void SpawnCharacter()
    {
        if (characterPrefab == null)
        {
            Debug.LogError("No character prefab assigned!");
            return;
        }

        // Instantiate the character at the spawn point’s position and rotation
        Instantiate(characterPrefab, gameObject.transform.position, gameObject.transform.rotation);
    }
}
