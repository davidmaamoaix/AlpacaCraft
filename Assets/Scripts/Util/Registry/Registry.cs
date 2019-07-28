using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Registry<T> where T: Registry<T> {

	private string registryName;

	public string getRegistryName() {
		return this.registryName;
	}

	public T setRegistryName(string name) {
		if (this.registryName != null) {
			throw(new RegistryException(this.registryName + "has already been assigned a registry name."));
		}

		this.registryName = name;
		return (T) this;
	}
}
