using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkMap<K, C, V> {

	private Dictionary<K, Dictionary<C, V>> chunkMap;

	public ChunkMap() {
		this.chunkMap = new Dictionary<K, Dictionary<C, V>>();
	}

	public bool hasKey(K keyA, C keyB) {
		if (!this.chunkMap.ContainsKey(keyA)) {
			return false;
		}

		return this.chunkMap[keyA].ContainsKey(keyB);
	}

	public V get(K keyA, C keyB) {
		Dictionary<C, V> layer;
		if (this.chunkMap.ContainsKey(keyA)) {
			layer = this.chunkMap[keyA];
		} else {
			return default(V);
		}

		return layer.ContainsKey(keyB) ? layer[keyB] : default(V);
	}

	public V set(K keyA, C keyB, V value) {
		Dictionary<C, V> layer;
		if (this.chunkMap.ContainsKey(keyA)) {
			layer = this.chunkMap[keyA];
		} else {
			layer = new Dictionary<C, V>();
			this.chunkMap.Add(keyA, layer);
		}

		layer.Add(keyB, value);
		return value;
	}
}
