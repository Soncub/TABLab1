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
        
    }
#endif



}
