using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessPiece : MonoBehaviour
{

    public enum PieceType
    {
        Pawn,
        Rook,
        Bishop,
        Knight,
        King,
        Queen,
    }
    public PieceType type;

    public Color color;

    public string filename() => "Piece_" + ((int)type).ToString() + ".png";


#if UNITY_EDITOR
    private void OnDrawGizmos()
    {
        Gizmos.DrawIcon(transform.position, filename(), false, color);
    }

    private void OnDrawGizmosSelected()
    {   
            //Pawn
            /*
            Gizmos.color = Color.blue;
            Gizmos.DrawLine(new Vector3(7, 1, 0), new Vector3(7, 3, 0));
            

            //Rook
            
            Gizmos.color = Color.blue;
            Gizmos.DrawLine(new Vector3(-2, 7, 0), new Vector3(2, 7, 0));
            Gizmos.DrawLine(new Vector3(0, 5, 0), new Vector3(0, 9, 0));
            

            //Bishop
            
            Gizmos.color = Color.blue;
            Gizmos.DrawLine(new Vector3(3, -2, 0), new Vector3(7, 2, 0));
            Gizmos.DrawLine(new Vector3(3, 2, 0), new Vector3(7, -2, 0));
            

            //Knight
            
            Gizmos.color = Color.blue;
            Gizmos.DrawLine(new Vector3(3, 5, 0), new Vector3(7, 5, 0));
            Gizmos.DrawLine(new Vector3(5, 3, 0), new Vector3(5, 7, 0));
            Gizmos.DrawLine(new Vector3(4, 7, 0), new Vector3(6, 7, 0));
            Gizmos.DrawLine(new Vector3(4, 3, 0), new Vector3(6, 3, 0));
            Gizmos.DrawLine(new Vector3(3, 4, 0), new Vector3(3, 6, 0));
            Gizmos.DrawLine(new Vector3(7, 4, 0), new Vector3(7, 6, 0));
            

           //Queen
            
            Gizmos.color = Color.blue;
            Gizmos.DrawLine(new Vector3(0, 5, 0), new Vector3(4, 5, 0));
            Gizmos.DrawLine(new Vector3(2, 3, 0), new Vector3(2, 7, 0));
            Gizmos.DrawLine(new Vector3(0, 7, 0), new Vector3(4, 3, 0));
            Gizmos.DrawLine(new Vector3(0, 3, 0), new Vector3(4, 7, 0));

            //King
            
            Gizmos.color = Color.blue;
            Gizmos.DrawLine(new Vector3(1, 2, 0), new Vector3(3, 2, 0));
            Gizmos.DrawLine(new Vector3(2, 1, 0), new Vector3(2, 3, 0));
            Gizmos.DrawLine(new Vector3(1, 3, 0), new Vector3(3, 1, 0));
            Gizmos.DrawLine(new Vector3(1, 1, 0), new Vector3(3, 3, 0));
            */
    }
#endif



}
