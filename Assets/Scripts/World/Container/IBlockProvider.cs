using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBlockProvider {

	Block getBlock(Vector3Int pos);
}
