// Repo 仓库
using System;
using System.Collections.Generic;

public class RoleRepo
{

    Dictionary<int, RoleEntity> all;

    RoleEntity[] temp;

    public RoleRepo()
    {
        all = new Dictionary<int, RoleEntity>();
        temp = new RoleEntity[100];
    }

    public void Add(RoleEntity role)
    {
        all.Add(role.id, role);
    }

    public void Remove(int id)
    {
        all.Remove(id);
    }

    public RoleEntity Get(int id)
    {
        return all[id];
    }

    public int TakeAll(out RoleEntity[] result)
    {
        if (all.Count > temp.Length)
        {
            temp = new RoleEntity[all.Count];
        }
        all.Values.CopyTo(temp, 0);
        result = temp;
        return all.Count;
    }

    // Query who hp < 10
    // ..... 

}