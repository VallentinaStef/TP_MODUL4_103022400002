using System;
using TP_MODUL4_103022400002;

class Program
{
    static void Main(string[] args)
    {
        KodePos kodePos = new KodePos();

        Console.WriteLine(kodePos.getKodePos("Batununggal"));
        Console.WriteLine(kodePos.getKodePos("Maleer"));

        DoorMachine door = new DoorMachine();
        door.BukaPintu();
        door.KunciPintu();
    }
}