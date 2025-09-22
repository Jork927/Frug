using Unity.VisualScripting;
using UnityEngine;

public class triggerbox : MonoBehaviour
{
    VariableDeclaration points;
    public static int player_points = 0;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collision");
        Destroy(gameObject);
        player_points += 1;
        Debug.Log(player_points);

    }

   





}


