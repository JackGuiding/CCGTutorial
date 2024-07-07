using System;
using UnityEngine;

public static class RoleDomain
{

    public static void Spawn(GameContext ctx, int typeID)
    {

        // Create
        RoleEntity role = Factory.Role_Create(ctx, typeID);

        // Repo
        ctx.roleRepo.Add(role);

        Debug.Log("Spawn: " + role.id);

    }

    public static void Unspawn(GameContext ctx, int id)
    {
        // Repo
        ctx.roleRepo.Remove(id);
    }

    public static void Move(GameContext ctx, RoleEntity role, float moveAxis, float fixdt) {
        role.step += moveAxis * fixdt;
    }

    public static void Attack(GameContext ctx, RoleEntity role) {

    }

}