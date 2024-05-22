using UnityEngine;

public class WaterBeamController : MonoBehaviour
{
    [SerializeField] private GameObject waterBeamPrefab;
     
    private GameObject waterBeamInstance;

    // Update is called once per frame
    void Update()
    {
        // Get the mouse position in world coordinates
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0; // Make sure it's at the same z-position as the player

        // Calculate direction from player to mouse position
        Vector2 direction = (mousePos - transform.position).normalized;

        // Check if the water beam instance exists
        if (waterBeamInstance == null)
        {
            // If not, instantiate the water beam prefab
            waterBeamInstance = Instantiate(waterBeamPrefab, transform.position, Quaternion.identity);
        }

        // Update the position and rotation of the water beam instance
        waterBeamInstance.transform.position = transform.position + (Vector3)direction;
        waterBeamInstance.transform.right = direction; // Set the direction of the water beam
    }
}
