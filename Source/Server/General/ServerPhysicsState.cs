﻿namespace CodeImp.Bloodmasters.Server;

public class ServerPhysicsState : PhysicsState
{
    public ServerPhysicsState(Bloodmasters.Map map) : base(map)
    {
    }

    protected override PlayerCollision CreatePlayerCollision(IPhysicsState plr, Vector3D sv)
    {
        return new ServerPlayerCollision(plr, pos, sv, radius, isplayer);
    }

    protected override bool IsClientMode => false;
}
