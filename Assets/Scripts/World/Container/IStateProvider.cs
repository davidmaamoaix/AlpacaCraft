using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IStateProvider {

	BlockState getBlockState(Vector3Int pos);
}
