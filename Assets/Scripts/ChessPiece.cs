using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

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

[CustomEditor(typeof(ChessPiece))]
public class ChessPieceEditor : Editor
{
	// Custom in-scene UI for when ExampleScript
	// component is selected.
	public void OnSceneGUI()
	{
		var t = target as ChessPiece;
		var tr = t.transform;
		var pos = tr.position;
		// display an orange disc where the object is
		var color = new Color(1, 0.8f, 0.4f, 1);
		Handles.color = color;
		Handles.DrawWireDisc(pos, tr.forward, 0.5f);
		// display object "value" in scene
		GUI.color = color;
		Handles.Label(pos + new Vector3(0.5f, 0.5f, 0), t.type.ToString());

		//Changes made:
		// * Made the disc half the size and oriented towards the 2D plane.
		// * Made the label display the type of the Piece and offset it to the top right.
	}
}
