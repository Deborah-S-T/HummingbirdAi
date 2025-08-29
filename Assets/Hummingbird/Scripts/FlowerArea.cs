using UnityEngine;

/// <summary>
/// Manages a collection of flower plants and attached flowers
/// </summary>
public class FlowerArea : MonoBehaviour
{
    // The diameter of the area where the agent and flower can be
    // used for observing relative distance from agent to flower
    public const float AreaDiameter = 20f;

    // The list of all flower plants in this area (flower plants have multiple flowers)
    private List<GameObject> flowerPlants;

    // A lookup dictionnary for looking up a flower from a nectar collider
    private Dictionnary<Collider, Flower> nectarFlowerDictionnary;

    /// <summary>
    /// The list of all flowers in the flower area
    /// </summary>
    public List<Flower> Flowers { get; private set; }
}
