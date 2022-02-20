using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public InputAction.CallbackContext()

    public void OnMovement(InputAction.CallbackContext value)
    {
        Vector2 inputMovement = value.ReadValue<Vector2>();
        rawInputMovement = new Vector3(inputMovement.x, 0, inputMovement.y);
    }

    public interface InputAction
    {
        void OnMove(InpuAction.CallbackContext context);
        void OnJump(InpuAction.CallbackContext context);
        // void OnExplosion(InpuAction.CallbackContext context);
    }
}
