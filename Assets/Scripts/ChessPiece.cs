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

    public Color color = Color.white;

    public string filename() => "Piece_" + ((int)type).ToString() + ".png";


#if UNITY_EDITOR
    private void OnDrawGizmos()
    {
        Gizmos.DrawIcon(transform.position, filename(), true, color);
    }

    private void OnDrawGizmosSelected()
    {
		Gizmos.color = Color.blue;
		switch (type)
        {
            case PieceType.Pawn:
				Gizmos.DrawLine(new Vector3(7, 1, 0), new Vector3(7, 3, 0));
				break;
            case PieceType.Rook:
				Gizmos.DrawLine(new Vector3(-2, 7, 0), new Vector3(2, 7, 0));
				Gizmos.DrawLine(new Vector3(0, 5, 0), new Vector3(0, 9, 0));
				break;
            case PieceType.Bishop:
				Gizmos.DrawLine(new Vector3(3, -2, 0), new Vector3(7, 2, 0));
				Gizmos.DrawLine(new Vector3(3, 2, 0), new Vector3(7, -2, 0));
				break;
            case PieceType.Knight:
				Gizmos.DrawLine(new Vector3(3, 5, 0), new Vector3(7, 5, 0));
				Gizmos.DrawLine(new Vector3(5, 3, 0), new Vector3(5, 7, 0));
				Gizmos.DrawLine(new Vector3(4, 7, 0), new Vector3(6, 7, 0));
				Gizmos.DrawLine(new Vector3(4, 3, 0), new Vector3(6, 3, 0));
				Gizmos.DrawLine(new Vector3(3, 4, 0), new Vector3(3, 6, 0));
				Gizmos.DrawLine(new Vector3(7, 4, 0), new Vector3(7, 6, 0));
				break;
            case PieceType.King:
				Gizmos.DrawLine(new Vector3(1, 2, 0), new Vector3(3, 2, 0));
				Gizmos.DrawLine(new Vector3(2, 1, 0), new Vector3(2, 3, 0));
				Gizmos.DrawLine(new Vector3(1, 3, 0), new Vector3(3, 1, 0));
				Gizmos.DrawLine(new Vector3(1, 1, 0), new Vector3(3, 3, 0));
				break;
            case PieceType.Queen:
				Gizmos.DrawLine(new Vector3(0, 5, 0), new Vector3(4, 5, 0));
				Gizmos.DrawLine(new Vector3(2, 3, 0), new Vector3(2, 7, 0));
				Gizmos.DrawLine(new Vector3(0, 7, 0), new Vector3(4, 3, 0));
				Gizmos.DrawLine(new Vector3(0, 3, 0), new Vector3(4, 7, 0));
				break;
        } 
    }


#endif



}
