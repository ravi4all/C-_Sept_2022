using System;
using System.Collections.Generic;
using System.Text;

interface IPlayer
{
    void walk();
    void run();
    void jump();
}

interface IPlayerAction
{
    void punch();
    void kick();
    void superKick();
}

abstract class PlayerExtraPower : IPlayer
{
    abstract public void disappear();
    public void jump()
    {
        throw new NotImplementedException();
    }

    public void run()
    {
        throw new NotImplementedException();
    }

    public void walk()
    {
        throw new NotImplementedException();
    }
}

class King : PlayerExtraPower, IPlayerAction
{
    public override void disappear()
    {
        throw new NotImplementedException();
    }

    public void kick()
    {
        throw new NotImplementedException();
    }

    public void punch()
    {
        throw new NotImplementedException();
    }


    public void superKick()
    {
        throw new NotImplementedException();
    }

}

class Eddy : IPlayer, IPlayerAction
{
    public void jump()
    {
        throw new NotImplementedException();
    }

    public void kick()
    {
        throw new NotImplementedException();
    }

    public void punch()
    {
        throw new NotImplementedException();
    }

    public void run()
    {
        throw new NotImplementedException();
    }

    public void superKick()
    {
        throw new NotImplementedException();
    }

    public void walk()
    {
        throw new NotImplementedException();
    }
}

namespace OOPS_Introduction
{
    class InterfaceDemo
    {

    }
}
