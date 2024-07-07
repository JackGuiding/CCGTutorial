using System;
using System.Collections.Generic;

public class TemplateManager {

    Dictionary<int, RoleTE> roles;

    public TemplateManager() {
        roles = new Dictionary<int, RoleTE>();
    }

    public void LoadAll() {
        // Read From Files(Disk/Network)
    }

    public void UnloadAll() {
        
    }

    public RoleTE GetRole(int typeID) {
        return roles[typeID];
    }
}