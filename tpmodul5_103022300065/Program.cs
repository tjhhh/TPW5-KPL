// See https://aka.ms/new-console-template for more information

using System;
using tpmodul5_103022300065;
class Program
{
    static void Main(string[] args)
    {
        string user;
        user = Console.ReadLine();
        HaloGeneric halo = new HaloGeneric();
        halo.sapaUser(user);
    }
}
