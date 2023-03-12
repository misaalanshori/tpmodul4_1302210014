namespace TPMODUL4_1302210014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kode Pos Kelurahan Margasari adalah " + KodePos.GetKodePos(KodePos.Kelurahan.Margasari));
            
            DoorMachine pintuKosan = new DoorMachine();
            Console.WriteLine("Kondisi pintu saat ini: " + pintuKosan.currentState);
            pintuKosan.activateTrigger(DoorMachine.Trigger.BUKAPINTU);
            Console.WriteLine("Kondisi pintu saat ini: " + pintuKosan.currentState);
            pintuKosan.activateTrigger(DoorMachine.Trigger.BUKAPINTU);
            Console.WriteLine("Kondisi pintu saat ini: " + pintuKosan.currentState);
            pintuKosan.activateTrigger(DoorMachine.Trigger.KUNCIPINTU);
            Console.WriteLine("Kondisi pintu saat ini: " + pintuKosan.currentState);
            pintuKosan.activateTrigger(DoorMachine.Trigger.KUNCIPINTU);
            Console.WriteLine("Kondisi pintu saat ini: " + pintuKosan.currentState);
        }
    }
}