using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] private Text textComponent;
    [SerializeField] private State startingState;

    private State _state;

    private void Start()
    {
        _state = startingState;
        textComponent.text = _state.GetStateStory();
    }

    private void Update()
    {
        ManageState();
    }

    /// <summary>
    /// Changes between states, depending on the button that the
    /// user pressed.
    /// </summary>
    private void ManageState()
    {
        var nextStates = _state.GetNextStates();

        for (int stateIndex = 0; stateIndex < nextStates.Length; stateIndex++)
        {
            // Looping over elements, adding keys based on elements.
            if (Input.GetKeyDown(key: KeyCode.Alpha1 + stateIndex))
            {
                _state = nextStates[stateIndex];
            }
        }

        textComponent.text = _state.GetStateStory();
    }
}