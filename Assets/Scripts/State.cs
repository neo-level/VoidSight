using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [SerializeField] private State[] nextStates;
    [TextArea(10, 14)] [SerializeField] private string storyText;

    /// <summary>
    /// Returns the given story text
    /// </summary>
    /// <returns>string</returns>
    public string GetStateStory()
    {
        return storyText;
    }

    /// <summary>
    /// Returns an array of states.
    /// </summary>
    /// <returns>State[]</returns>
    public State[] GetNextStates()
    {
        return nextStates;
    }
}