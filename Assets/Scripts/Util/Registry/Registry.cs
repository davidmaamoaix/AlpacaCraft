using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Registry {

	private string registryName;

	public string getRegistryName() {
		return this.registryName;
	}

	public void setRegistryName(string name) {
		if (this.registryName != null) {
			throw(new RegistryException(this.registryName + " already has an registry name."));
		}
	}
}
