// Create 生成
public static class Factory
{

    public static RoleEntity Role_Create(GameContext ctx, int typeID)
    {
        RoleEntity role = new RoleEntity();

        int id = ctx.idService.GetRoleID();

        RoleTE te = ctx.templateManager.GetRole(typeID);
        role.id = id;
        role.typeID = te.typeID;
        role.hp = te.hp;
        return role;
    }

}