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
				Gizmos.DrawLine(new Vector3(transform.position.x, transform.position.y, 0), new Vector3(transform.position.x, transform.position.y + 2, 0));
				break;
            case PieceType.Rook:
				Gizmos.DrawLine(new Vector3(transform.position.x - 8, transform.position.y, 0), new Vector3(transform.position.x + 8, transform.position.y, 0));
				Gizmos.DrawLine(new Vector3(transform.position.x, transform.position.y - 8, 0), new Vector3(transform.position.x, transform.position.y + 8, 0));
				break;
            case PieceType.Bishop:
				Gizmos.DrawLine(new Vector3(transform.position.x - 8, transform.position.y - 8, 0), new Vector3(transform.position.x + 8, transform.position.y + 8, 0));
				Gizmos.DrawLine(new Vector3(transform.position.x - 8, transform.position.y + 8, 0), new Vector3(transform.position.x + 8, transform.position.y - 8, 0));
				break;
            case PieceType.Knight:
				Gizmos.DrawLine(new Vector3(transform.position.x - 2, transform.position.y, 0), new Vector3(transform.position.x + 2, transform.position.y, 0));
				Gizmos.DrawLine(new Vector3(transform.position.x, transform.position.y - 2, 0), new Vector3(transform.position.x, transform.position.y + 2, 0));
				Gizmos.DrawLine(new Vector3(transform.position.x - 2, transform.position.y - 1, 0), new Vector3(transform.position.x - 2, transform.position.y + 1, 0));
				Gizmos.DrawLine(new Vector3(transform.position.x + 2, transform.position.y - 1, 0), new Vector3(transform.position.x + 2, transform.position.y + 1, 0));
				Gizmos.DrawLine(new Vector3(transform.position.x - 1, transform.position.y + 2, 0), new Vector3(transform.position.x + 1, transform.position.y + 2, 0));
				Gizmos.DrawLine(new Vector3(transform.position.x - 1, transform.position.y - 2, 0), new Vector3(transform.position.x + 1, transform.position.y - 2, 0));
				break;
            case PieceType.King:
				Gizmos.DrawLine(new Vector3(transform.position.x - 1, transform.position.y, 0), new Vector3(transform.position.x + 1, transform.position.y, 0));
				Gizmos.DrawLine(new Vector3(transform.position.x, transform.position.y - 1, 0), new Vector3(transform.position.x, transform.position.y + 1, 0));
				Gizmos.DrawLine(new Vector3(transform.position.x - 1, transform.position.y - 1, 0), new Vector3(transform.position.x + 1, transform.position.y + 1, 0));
				Gizmos.DrawLine(new Vector3(transform.position.x - 1, transform.position.y + 1, 0), new Vector3(transform.position.x + 1, transform.position.y - 1, 0));
				break;
            case PieceType.Queen:
				Gizmos.DrawLine(new Vector3(transform.position.x - 8, transform.position.y, 0), new Vector3(transform.position.x + 8, transform.position.y, 0));
				Gizmos.DrawLine(new Vector3(transform.position.x, transform.position.y - 8, 0), new Vector3(transform.position.x, transform.position.y + 8, 0));
				Gizmos.DrawLine(new Vector3(transform.position.x - 8, transform.position.y - 8, 0), new Vector3(transform.position.x + 8, transform.position.y + 8, 0));
				Gizmos.DrawLine(new Vector3(transform.position.x - 8, transform.position.y + 8, 0), new Vector3(transform.position.x + 8, transform.position.y - 8, 0));
				break;
        } 
    }


#endif



}
