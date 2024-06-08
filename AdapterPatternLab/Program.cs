using AdapterPatternLab;

class Program
{
    static void Main()
    {
        ComputerGame computerGame = new ComputerGame(
            "Super Game",
            PegiAgeRating.P16,
            60.0,
            4096,
            50,
            16,
            8,
            3.5
        );

        // создание адаптера
        IPCGame pcGame = new ComputerGameAdapter(computerGame);

        Console.WriteLine("Title: " + pcGame.getTitle());
        Console.WriteLine("PEGI Age: " + pcGame.getPegiAllowedAge());
        Console.WriteLine("Is Triple A: " + pcGame.isTripleAGame());
        Requirements requirements = pcGame.getRequirements();
        Console.WriteLine("GPU Memory (GB): " + requirements.getGpuGb());
        Console.WriteLine("HDD Space (GB): " + requirements.getHDDGb());
        Console.WriteLine("RAM (GB): " + requirements.getRAMGb());
        Console.WriteLine("CPU Speed (GHz): " + requirements.getCpuGhz());
        Console.WriteLine("CPU Cores: " + requirements.getCoresNum());
    }
}