using System;

public static class RoleControler {

    static int idRecord = 1;
    public static void FixLogic(GameContext ctx, float fixdt) {

        // Spawn
        InputEntity input = ctx.input;
        if (input.isSpawnDown)
        {
            RoleDomain.Spawn(ctx, 100);
        }

        // Loop
        int roleLen = ctx.roleRepo.TakeAll(out RoleEntity[] result);
        for (int i = 0; i < roleLen; i += 1) {
            RoleEntity role = result[i];
            // Move
            RoleDomain.Move(ctx, role, input.moveAxis, fixdt);
        }
    }

}